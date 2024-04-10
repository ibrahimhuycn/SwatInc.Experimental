using Destructurama.Attributed;
using Serilog.Core;
using Serilog.Events;
using System.Security.Cryptography;



namespace SerilogMaskingAndEncrytion;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Person Created {@PersonCreatedEvent} in {Time}", PersonCreatedEvent.GetPersonCreatedEvent(), DateTime.Now);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}

public class PersonCreatedEvent
{
    [LogMasked]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = "Ibrahim";
    [LogMasked]
    public string LastName { get; set; } = "Hussain";
    [LogEncrypted]
    public string NationalId { get; set; } = "A309254";

    public static PersonCreatedEvent GetPersonCreatedEvent() { return new PersonCreatedEvent(); }
}


/// <summary>
/// Apply to a property to apply a encryption to the logged value.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class LogEncryptedAttribute : Attribute, IPropertyDestructuringAttribute
{
    public bool TryCreateLogEventProperty(string name, object? value, ILogEventPropertyValueFactory propertyValueFactory, out LogEventProperty? property)
    {
        if (value == null)
        {
            property = new(name, ScalarValue.Null);
            return true;
        }

        if (value is string s)
        {
            property = new LogEventProperty(name, EncryptValue(s));
            return true;
        }

        property = null;
        return false;
    }

    private static LogEventPropertyValue EncryptValue(string value)
    {
        return new ScalarValue(AesEncryption.EncryptString(value));
    }
}

public static class CryptoUtilities
{
    private static readonly RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

    public static byte[] GenerateRandomBytes(int size)
    {
        byte[] randomBytes = new byte[size];
        rngCsp.GetBytes(randomBytes);
        return randomBytes;
    }
}



public static class AesEncryption
{
    private static readonly byte[] _key = CryptoUtilities.GenerateRandomBytes(16);
    private static readonly byte[] _iV = CryptoUtilities.GenerateRandomBytes(16);

    public static string EncryptString(string plainText)
    {
        using Aes aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _iV;

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using var msEncrypt = new MemoryStream();
        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        using (var swEncrypt = new StreamWriter(csEncrypt))
        {
            swEncrypt.Write(plainText);
        }
        return Convert.ToBase64String(msEncrypt.ToArray());
    }

    public static string DecryptString(string cipherText)
    {
        using Aes aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _iV;

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        using var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText));
        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        using (var srDecrypt = new StreamReader(csDecrypt))
        {
            return srDecrypt.ReadToEnd();
        }
    }
}

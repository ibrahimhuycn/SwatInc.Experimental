Public Class Person

    Public Overridable Property NationalIdCardNumber As String
    Public Overridable Property FirstName As String
    Public Overridable Property LastName As String
    Public Overridable Property Address As Address
    Public Overridable Property ContactDetails As Contact

    Public Shared Sub GetPerson(id As String)
        Dim person As Person = New Person With {.FirstName = "Ibrahim",
            .LastName = "Hussain",
            .Address = New Address With {.State = "Addu", .District = "Hithadhoo", .Street = "Ghaazee Magu", .Building = "Fari Building", .Country = "Maldives"},
            .ContactDetails = New Contact With {.ContactType = ContactType.Mobile, .Value = "7657111"},
            .NationalIdCardNumber = "A569586"}

        PersonView._viewModel.FirstName = person.FirstName
        PersonView._viewModel.LastName = person.LastName
        PersonView._viewModel.Address = person.Address
    End Sub

End Class

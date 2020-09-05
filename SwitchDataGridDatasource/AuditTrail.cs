using System;

namespace SwitchDataGridDatasource
{
    public class AuditTrail
    {
        public DateTimeOffset EventTime { get; set; }
        public string Details { get; set; }
    }


}

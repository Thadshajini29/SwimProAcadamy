using System;

namespace SwimProAcadamy.Models
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public int? UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}

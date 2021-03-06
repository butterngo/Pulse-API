﻿namespace Pulse.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class KioskSecurity : IEntity, IAudits
    {
        [Key]
        public int Id { get; set; }
        public string MachineId { get; set; }
        public string ClientId { get; set; }
        public string LicenseKey { get; set; }
        public string MacAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int EncryptionUserId { get; set; }
        public virtual EncryptionUser EncryptionUser { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string Note { get; set; }

        public string Photo { get; set; }

    }
}

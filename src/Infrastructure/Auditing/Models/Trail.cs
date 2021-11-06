using DN.WebApi.Domain.Contracts;
using System;

namespace DN.WebApi.Infrastructure.Auditing.Models
{
    public class Trail : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string AffectedColumns { get; set; }
        public string PrimaryKey { get; set; }
    }
}
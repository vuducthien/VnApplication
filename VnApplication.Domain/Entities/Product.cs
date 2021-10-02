using System;
using System.Collections.Generic;
using System.Text;
using VnApplication.Domain.Common;

namespace VnApplication.Domain.Entities
{
    public class Product : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}

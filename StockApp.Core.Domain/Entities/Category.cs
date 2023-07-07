using StockApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Domain.Entities
{
    public class Category : AuditableBaseEntity
    {    
        public string Name { get; set; }
        public string Description { get; set; }

        //navigation property
        public ICollection<Product>? Products { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekSite.Models
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}

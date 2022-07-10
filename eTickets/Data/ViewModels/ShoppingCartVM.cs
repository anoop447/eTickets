using eTickets.Data.Cart;
using System;
using System.Linq;

namespace eTickets.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}

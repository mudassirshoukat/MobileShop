using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models.response
{
    public  class OrderResponseViewModel
    {
        public  List<OrderResponseModel> Listorder { get; set; }
        public  int TotalOrders { get; set; }
        public  int PendingOrders { get; set; }
        public  int CompleatedOders { get; set; }
        public  double TotalSale { get; set; }

    }
}

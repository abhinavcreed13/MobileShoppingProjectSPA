using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileShoppingProject.Models
{
    public class MobilePhoneDataViewModel
    {
        public int DeviceNumer { get; set; }
        public string DeviceName { get; set; }
        public string Brand { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool IsAddedToCart { get; set; }
    }
}
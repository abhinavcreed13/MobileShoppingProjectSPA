using MobileShoppingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileShoppingProject.Controllers
{
    public class DataApiController : ApiController
    {
        testEntities _db = new testEntities();

        public static List<MobilePhoneDataViewModel> cartItems = new List<MobilePhoneDataViewModel>();
        
        public string Get()
        {
            return "Welcome to mobile shop!";
        }

        public List<MobilePhoneDataViewModel> GetPhoneData()
        {
            var data = _db.MobilePhoneDatas.ToList();
            var dataToSend = data.Select(row => new MobilePhoneDataViewModel
            {
                DeviceName = row.DeviceName,
                DeviceNumer = row.DeviceNumer,
                Brand = row.Brand,
                Price = row.Price,
                Status = row.Status,
                Type = row.Type,
                IsAddedToCart = cartItems.Any(item => item.DeviceNumer == row.DeviceNumer)
            }).ToList();
            return dataToSend;
        }

        [HttpPost]
        public object AddToCart(MobilePhoneDataViewModel phoneObject)
        {
            cartItems.Add(phoneObject);
            return new
            {
                added = true
            };
        }
    }
}

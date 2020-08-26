using RestSharp;
using System;
using System.Collections.Generic;

namespace ShoppingDataDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shopping Data Dumper");

            string url = "https://fonoapi.freshpixl.com/v1/getlatest";

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            var data = new
            {
                token = "c84016d59ba2400da792af890599012e7e98df9a08bd335d"
            };

            request.AddJsonBody(data);

            var response = client.Execute<List<MobilePhoneDataModel>>(request);

            using var context = new ShoppingDbContext();
            Random _random = new Random();
            foreach(MobilePhoneDataModel d in response.Data)
            {
                Console.WriteLine("Adding ->" + d.DeviceName);
                d.Price = _random.Next(400, 1400).ToString();
                context.MobilePhoneData.Add(d);
            }

            // update database
            context.SaveChanges();
        }
    }
}

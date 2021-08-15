using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebApplicationDZ3
{
    public class CustomConfig
    {
       
        public SecondV SecondV { get; set; }
      
        public int First { get; set; }
        public string Second { get; set; }
        public float Third { get; set; }
        public DateTime Fourth { get; set; }

        

        public  string FirstAction()
        {
            
            var rnd = new Random();
            var gg = rnd.Next(0, First);
           return gg.ToString();
        }
            

    }
}

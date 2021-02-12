using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.Models
{
    public class covid19
    {
        public string id { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string Slug { get; set; }
        public int newConfirmed { get; set; }
        public int totalcomfirmed { get; set; }
        public int  NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int newrecovered { get; set; }
        public int totalrecovered { get; set; }
        public int Date { get; set; }
      
        
    }
}

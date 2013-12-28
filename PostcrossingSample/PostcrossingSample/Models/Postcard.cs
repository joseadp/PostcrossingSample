using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostcrossingSample.Models
{
    public class Postcard
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public int PostcardNumber { get; set; }
        public DateTime SentDate { get; set; }
        public string ToMember { get; set; }
        public string DestinationCountry { get; set; }
    }
}
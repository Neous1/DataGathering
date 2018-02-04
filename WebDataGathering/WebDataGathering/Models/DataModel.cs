using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDataGathering.Models
{
    public class DataModel
    {
        public int Id { get; set; }
        public DateTime PullTime { get; set; }
        public string Symbol { get; set; }
        public string LastPrice { get; set; }
        public string ChangePerc { get; set; }
        public string Volume { get; set; }
        public string VolumeAvg { get; set; }
    }
}
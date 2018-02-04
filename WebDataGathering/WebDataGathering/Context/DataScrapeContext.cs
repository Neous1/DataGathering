using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebDataGathering.Models;

namespace WebDataGathering.Context
{
    public class DataScrapeContext: DbContext
    {
        public DataScrapeContext() : base()
        {
        }

        public DbSet<DataModel> DataModels { get; set; }
    }
    
}
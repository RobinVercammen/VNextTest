using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WebApi.Models
{
    public class Timesheet
    {
        public BsonObjectId _id { get; set; }
        public DateTime Date { get; set; }

        public string Company { get; set; }
        public string Consultant { get; set; }
        public string File { get; set; }
        public TimsheetStatusEnum Status { get; set; }
    }
        
    public enum TimsheetStatusEnum
    {
        Accepted = 0,
        Rejected = 1,
        Pending = 2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApp.Models
{
    public enum Status
    {
        Draft,
        Aprovel,
        Processing,
        Done,
        Rejected
    }

    public class Request
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Status Status { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }

    }
}

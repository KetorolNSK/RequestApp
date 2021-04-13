using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApp.Models
{
    public interface IRepository
    {
        IEnumerable<Request> Requests { get; }
        Request GetRequest(int key);

        void AddRequest(Request request);

        void UpdateRequest(Request request);

        void DeleteRequest(Request request);
    }
}

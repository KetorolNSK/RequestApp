using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApp.Models
{
    public class DataRepository : IRepository
    {
        private DataContext context;
        public DataRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Request> Requests => context.Requests;
        public Request GetRequest(int key) => context.Requests.Find(key);

        public void AddRequest(Request request)
        {
            context.Requests.Add(request);
            context.SaveChanges();
        }

        public void UpdateRequest(Request request)
        {
            //context.Requests.Update(request);
            //context.SaveChanges();

            Request p = GetRequest(request.Id);
            p.DateCreate = request.DateCreate;
            p.DateUpdate = request.DateUpdate;
            p.Status = request.Status;
            p.Topic = request.Topic;
            p.Text = request.Text;
            context.SaveChanges();
        }

        public void DeleteRequest(Request request)
        {
            context.Requests.Remove(request);
            context.SaveChanges();
        }
    }
}

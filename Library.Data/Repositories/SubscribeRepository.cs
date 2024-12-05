using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class SubscribeRepository:ISubscribeRepository
    {
        private readonly DataContext _context;
        public SubscribeRepository(DataContext context)
        {
            _context = context;
        }

        public List<Subscribe> GetAll() => _context.SubscribeList.ToList();            
        public Subscribe GetSubscribeById( string? id, string? name) => _context.SubscribeList.FirstOrDefault(s => s.SubscriberId == id || s.Name == name);
        public void AddSubscriber(Subscribe subscribe)=>_context.SubscribeList.Add(subscribe);
        public void UpdateSubscriber(string id, Subscribe subscribe)
        {
            Subscribe ?subscriber = _context.SubscribeList.FirstOrDefault(sub => sub.SubscriberId == id);
            if (subscriber != null)
            {
                subscriber.Name = subscribe.Name;
                subscriber.SubscriberId = subscribe.SubscriberId;
                subscriber.Phone = subscribe.Phone;
                subscriber.Address = subscribe.Address;


            }
        }
        public void DeleteSubscriber(string id) {
            Subscribe ?subscriber = _context.SubscribeList.FirstOrDefault(sub => sub.SubscriberId == id);
            if (subscriber != null)
            {
                subscriber.IsActive = false;
            }
        }

    }
}

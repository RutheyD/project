using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class SubscribeService:ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository;
        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }

        public List<Subscribe> GetAll()=>_subscribeRepository.GetAll();
        public Subscribe GetSubscribeById(string? id, string? name)=>_subscribeRepository.GetSubscribeById(id, name);
       public void AddSubscriber(Subscribe subscribe)=>_subscribeRepository.AddSubscriber(subscribe);
       public void UpdateSubscriber(string id, Subscribe subscribe)=>_subscribeRepository.UpdateSubscriber(id, subscribe);  
        public void DeleteSubscriber(string id)=>_subscribeRepository.DeleteSubscriber(id);
    }
}

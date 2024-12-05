using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface ISubscribeRepository
    {
        List<Subscribe> GetAll();
        Subscribe GetSubscribeById(string? id, string? name);
        void AddSubscriber(Subscribe subscribe);
        void UpdateSubscriber(string id, Subscribe subscribe);
        void DeleteSubscriber(string id);
    }
}

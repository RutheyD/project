
using Library.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Librery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly IDataContext _allLists;
        public SubscribeController(IDataContext context)
        {
            _allLists = context;
        }
        // GET: api/<SubscribeCollector>
        [HttpGet]
        public IEnumerable<Subscribe> Get()
        {
            return _allLists.SubscribeList;
        }

        // GET api/<SubscribeCollector>/5
        //מחזיר מנוי לפי מזהה
        [HttpGet("with id")]
        public ActionResult<Subscribe> Get([FromQuery] string? id, [FromQuery] string? name)
        {
            Subscribe subscribers = _allLists.SubscribeList.FirstOrDefault(s => s.Id == id || s.Name == name);
            if (subscribers == null)
                return NotFound();
            return Ok(subscribers);
        }

        // POST api/<SubscribeCollector>
        //הכנסת מנוי חדש
        [HttpPost]
        public void Post([FromBody] Subscribe subscribe)
        {
            _allLists.SubscribeList.Add(subscribe);
        }


        // PUT api/<SubscribeCollector>/5
        //שינוי פרטי מנוי
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Subscribe subscribe)
        {
            Subscribe subscriber = _allLists.SubscribeList.FirstOrDefault(sub => sub.Id == id);
            if (subscriber != null)
            {
                subscriber.Name = subscribe.Name;
                subscriber.Id = subscribe.Id;
                subscriber.Phone = subscribe.Phone;
                subscriber.Address = subscribe.Address;


            }
        }

        // DELETE api/<SubscribeCollector>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Subscribe subscriber = _allLists.SubscribeList.FirstOrDefault(sub => sub.Id == id);
            if (subscriber != null)
            {
                subscriber.IsActive = false;
            }
        }
    }
}

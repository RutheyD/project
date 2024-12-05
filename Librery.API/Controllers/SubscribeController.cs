
using Library.Core.Models;
using Library.Core.Services;
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
        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        // GET: api/<SubscribeCollector>
        [HttpGet]
        public IEnumerable<Subscribe> Get()
        {
            return _subscribeService.GetAll();
        }

        // GET api/<SubscribeCollector>/5
        //מחזיר מנוי לפי מזהה
        [HttpGet("with id")]
        public ActionResult<Subscribe> Get([FromQuery] string? id, [FromQuery] string? name)
        {
            Subscribe subscriber = _subscribeService.GetSubscribeById(id, name);
            if (subscriber == null)
                return NotFound();
            return Ok(subscriber);
        }

        // POST api/<SubscribeCollector>
        //הכנסת מנוי חדש
        [HttpPost]
        public void Post([FromBody] Subscribe subscribe)
        {
            _subscribeService.AddSubscriber(subscribe);
        }


        // PUT api/<SubscribeCollector>/5
        //שינוי פרטי מנוי
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Subscribe subscribe)
        {
            _subscribeService.UpdateSubscriber(id, subscribe);
        }

        // DELETE api/<SubscribeCollector>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _subscribeService.DeleteSubscriber(id);
        }
    }
}

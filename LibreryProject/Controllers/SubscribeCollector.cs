using LibreryProject.Lists;
using LibreryProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibreryProject.Controllers.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeCollector : ControllerBase
    {
        public SubscribeCollector()
        {

        }
        // GET: api/<SubscribeCollector>
        [HttpGet]
        public IEnumerable<Subscribe> Get()
        {
            return Lists_Of_The_Librery.Subscriptions;
        }

        // GET api/<SubscribeCollector>/5
        //מחזיר מנוי לפי מזהה
        [HttpGet("with id")]
        public IEnumerable<Subscribe> Get([FromQuery] string ?id,[FromQuery] string ?name)
        {
            return Lists_Of_The_Librery.Subscriptions.Where(s => s.Id == id ||s.Name==name).ToList();
        }
        
        // POST api/<SubscribeCollector>
        //הכנסת מנוי חדש
        [HttpPost]
        public void Post([FromBody] Subscribe subscribe)
        {
            Lists_Of_The_Librery.Subscriptions.Add(subscribe);
        }


        // PUT api/<SubscribeCollector>/5
        //שינוי פרטי מנוי
        [HttpPut("{id}")]
        public void Put(string id,[FromBody]Subscribe subscribe)
        {
             Subscribe subscriber=Lists_Of_The_Librery.Subscriptions.FirstOrDefault(sub=>sub.Id==id);
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
            Subscribe subscriber = Lists_Of_The_Librery.Subscriptions.FirstOrDefault(sub =>  sub.Id == id);
            if(subscriber != null)
            {
                subscriber.IsActive = false;
            }
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PaymentsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        // GET: api/Payments
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "payment1", "payment2" };
        }

        // GET: api/Payments/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Payment-{id}";
        }

        // POST: api/Payments
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Payments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

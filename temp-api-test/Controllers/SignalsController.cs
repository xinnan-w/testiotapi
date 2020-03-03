using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using tempapitest.Contracts;

namespace temp_api_test.Controllers
{
    [Route("api/[controller]")]
    public class SignalsController : Controller
    {

        private static List<Signals> signalList = new List<Signals>()
        {
            new Signals
            {
                id = 1,
                Signal = "000028b4"
            },
            new Signals
            {
                id = 2,
                Signal = "00002979"
            },
            new Signals
            {
                id = 3,
                Signal = "000028ce"
            }
        };

        // GET api/signals
        [HttpGet]
        public JsonResult Get()
        {
            return Json(signalList);
        }

        // GET api/signals/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Signals signals = signalList.Single(p => p.id == id);
            return Json(signals);
        }

        // POST api/signals
        [HttpPost]
        public JsonResult Post([FromBody]Signals newSignal)
        {
            signalList.Add(newSignal);
            return Json(signalList);
        }

        // PUT api/signals/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody]string value)
        {
            Signals signals = signalList.Single(p => p.id == id);
            return Json(signals);
        }

        // DELETE api/singals/5
        [HttpDelete("{id}")]
        public void Delete(int id)

        {
            Signals signals = signalList.Single(p => p.id == id);
            signalList.Remove(signals);
        }
    }
}

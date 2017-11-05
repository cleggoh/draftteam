using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using draftteam.data;
using draftteam.models;

namespace drafttean.Controllers
{
    [Route("api/[controller]")]
    public class SchedulesController : Controller
    {
        private readonly IScheduleRepository _repo;

        public SchedulesController(IScheduleRepository repo)
        {
            _repo = repo;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetScheduledGames(DateTime scheduleDate)
        {
            var schedule = _repo.GetScheduledGames(scheduleDate);

            return Ok(schedule);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

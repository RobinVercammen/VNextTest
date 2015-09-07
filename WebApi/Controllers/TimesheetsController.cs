using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApi.Models;
using WebApi.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TimesheetsController : Controller
    {
        private readonly ITimesheetService _timesheetService;

        public TimesheetsController(ITimesheetService timesheetService)
        {
            _timesheetService = timesheetService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Timesheet>> Get()
        {
            return await _timesheetService.getTimesheets();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Timesheet> Get(string id)
        {
            return await _timesheetService.getTimesheet(id);
        }

        // POST api/values
        [HttpPost]
        public async Task<bool> Post([FromBody]Timesheet timesheet)
        {
            return await _timesheetService.addTimesheet(timesheet);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<Timesheet> Put(string id, [FromBody] Timesheet updatedTimesheet)
        {
            return await _timesheetService.updateTimesheet(id, updatedTimesheet);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

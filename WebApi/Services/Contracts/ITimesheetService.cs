using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface ITimesheetService
    {
        Task<bool> addTimesheet(Timesheet timesheet);
        Task<IEnumerable<Timesheet>> getTimesheets();
        Task<bool> removeTimesheet(Timesheet timesheet);
        Task<Timesheet> getTimesheet(string id);
        Task<Timesheet> updateTimesheet(string id, Timesheet timesheet);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using WebApi.Models;
using MongoDB.Driver;

namespace WebApi.Services
{
    public class TimesheetService : ITimesheetService
    {
        private IMongoCollection<Timesheet> _collection;
        private readonly IMongoDatabase _database;

        public TimesheetService(IMongoDatabase database)
        {
            _database = database;
            _collection = _database.GetCollection<Timesheet>("timesheets");
        }

        public async Task<bool> addTimesheet(Timesheet timesheet)
        {
            try
            {
                await _collection.InsertOneAsync(timesheet);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<Timesheet> getTimesheet(BsonObjectId id)
        {
            return new Timesheet();
        }

        public async Task<IEnumerable<Timesheet>> getTimesheets()
        {
            return await (await _collection.FindAsync(x => true)).ToListAsync();
        }

        public async Task<bool> removeTimesheet(Timesheet timesheet)
        {
            try
            {
                await _collection.DeleteOneAsync(x => x._id == timesheet._id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Timesheet> updateTimesheet(Timesheet timesheet)
        {
            return null;
            try
            {
            }
            catch (Exception)
            {
            }
        }
    }
}

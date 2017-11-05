using draftteam.models;
using System;
using System.Collections.Generic;

namespace draftteam.data
{
    public class ScheduleRepository : IScheduleRepository
    {
        public Schedule GetScheduledGames(DateTime scheduleDate)
        {
            return new Schedule(scheduleDate, new List<Game>());
        }
    }
}

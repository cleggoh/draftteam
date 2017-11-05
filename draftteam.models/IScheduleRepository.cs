using System;
using System.Collections.Generic;
using System.Text;

namespace draftteam.models
{
    public interface IScheduleRepository
    {
        Schedule GetScheduledGames(DateTime scheduleDate);
    }
}

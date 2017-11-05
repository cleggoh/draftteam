using System;
using System.Collections.Generic;

namespace draftteam.models
{
    public class Schedule
    {
        public Schedule(DateTime scheduleDate, IEnumerable<Game> games)
        {

        }

        public IEnumerable<Game> Games { get; }
    }
}

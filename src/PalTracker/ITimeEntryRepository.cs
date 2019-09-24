using System.Collections.Generic;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Update(long id,TimeEntry timeEntry);
        TimeEntry Find(long id);
        void Delete(long id);
        IEnumerable<TimeEntry> List();
        bool Contains(long id);        

    }
    
}
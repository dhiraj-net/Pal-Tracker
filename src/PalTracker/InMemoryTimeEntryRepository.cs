using System.Collections.Generic;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository:ITimeEntryRepository
    {
        private readonly IDictionary<long,TimeEntry> _timeEntryRepository=new Dictionary<long,TimeEntry>();
        private int _count=0;
        public TimeEntry Create(TimeEntry timeEntry)
        {
            timeEntry.Id=++_count;
            _timeEntryRepository.Add(_count,timeEntry);
            return timeEntry;
        }
        public TimeEntry Update(long id,TimeEntry timeEntry)
        {
            timeEntry.Id=id;
            _timeEntryRepository[id]=timeEntry;
            return timeEntry;
        }
        public TimeEntry Find(long id)
        {
            return _timeEntryRepository[id];
        }
        public void Delete(long id)
        {
            _timeEntryRepository.Remove(id);
        }
        public IEnumerable<TimeEntry> List()
        {
            return _timeEntryRepository.Values;
        }
        public bool Contains(long id)
        {
            return _timeEntryRepository.ContainsKey(id);
        }      
         

    }
    
}
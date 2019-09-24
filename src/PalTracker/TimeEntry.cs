using System;
namespace PalTracker
{
    public struct TimeEntry
    {
        public long? Id{get;set;}
        public long ProjectId{get;set;}
        public long UserId{get;set;}
        public DateTime Date{get;set;}
        public int Hours{get;set;}

        public TimeEntry(long id,long pid,long uid,DateTime date,int hours)
        {
            this.Id=id;
            this.ProjectId=pid;
            this.UserId=uid;
            this.Date=date;
            this.Hours=hours;
        }
        public TimeEntry(long pid,long uid,DateTime date,int hours)
        {
            this.Id=null;
            this.ProjectId=pid;
            this.UserId=uid;
            this.Date=date;
            this.Hours=hours;
        }

    }
}

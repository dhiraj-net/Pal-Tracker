using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("time-entries")]
    public class TimeEntryController:ControllerBase
    {
        private readonly ITimeEntryRepository _repository;
        public TimeEntryController(ITimeEntryRepository repo)
        {
            this._repository=repo;
        }
        [HttpPost]
        public IActionResult Create([FromBody]TimeEntry timeEntry)
        {
            TimeEntry createdTimeEntry=_repository.Create(timeEntry);
            return CreatedAtRoute("GetTimeEntry",new {Id=createdTimeEntry.Id},createdTimeEntry);
        }
        [HttpPut("{Id}")]
        public IActionResult Update(long id,[FromBody]TimeEntry timeEntry)
        {
            return _repository.Contains(id)?(IActionResult)Ok(_repository.Update(id,timeEntry)):NotFound();
        }
        [HttpGet("{Id}",Name="GetTimeEntry")]
        public IActionResult Read(long id)
        {
            return _repository.Contains(id)?(IActionResult)Ok(_repository.Find(id)):NotFound();
        }
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.List());
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(long id)
        {
            if(!_repository.Contains(id))
            {
                return NotFound();                
            }
            _repository.Delete(id);
            return NoContent();
        }
    } 
    
}
// ActivityController.cs
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2001MicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ActivityController : ControllerBase
    {
        private readonly EFDbContext _context;

        public ActivityController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/Activity
        [HttpGet]
        public IActionResult GetActivities()
        {
            var activities = _context.Activities.ToList();
            return Ok(activities);
        }

        // GET: api/Activity/5
        [HttpGet("{id}")]
        public IActionResult GetActivity(int id)
        {
            var activity = _context.Activities.Find(id);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }

        // POST: api/Activity
        [HttpPost]
        public IActionResult PostActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetActivity), new { id = activity.ActivityID }, activity);
        }

        // PUT: api/Activity/5
        [HttpPut("{id}")]
        public IActionResult PutActivity(int id, Activity activity)
        {
            if (id != activity.ActivityID)
            {
                return BadRequest();
            }

            _context.Entry(activity).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Activity/5
        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(int id)
        {
            var activity = _context.Activities.Find(id);

            if (activity == null)
            {
                return NotFound();
            }

            _context.Activities.Remove(activity);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

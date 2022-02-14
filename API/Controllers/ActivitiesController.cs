using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseAPIController
    {
        private  readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() => await _context.Activities.ToListAsync();

        [HttpGet("{id}")] // activities
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            return await _context.Activities.FindAsync(id);
        }
        
    }
}
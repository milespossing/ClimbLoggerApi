using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClimbLogger.Api.DAL;
using ClimbLogger.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClimbLogger.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClimbApiController : Controller
    {
        private ClimbEntryDbContext _climbEntryDbContext;

        public ClimbApiController(ClimbEntryDbContext climbEntryDbContext)
        {
            _climbEntryDbContext = climbEntryDbContext;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<ClimbEntry>> Index()
        {
            return await _climbEntryDbContext.ClimbEntries.ToListAsync();
        }

        [HttpPost]
        public async Task Post(ClimbEntry entry)
        {
            if (entry.Id == default) entry.Id = Guid.NewGuid();
            _climbEntryDbContext.ClimbEntries.Add(entry);
            await _climbEntryDbContext.SaveChangesAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SetApi.Context;
using SetApi.Models;

namespace SetApi.Controllers
{
    [Route("api/AvatarCharts")]
    [ApiController]
    public class AvatarChartsController : ControllerBase
    {
        private readonly AvatarChartContext _context;

        public AvatarChartsController(AvatarChartContext context)
        {
            _context = context;
        }

        // GET: api/AvatarCharts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvatarChart>>> GetAvatarCharts()
        {
            return await _context.AvatarCharts.ToListAsync();
        }

        // GET: api/AvatarCharts/5
        [HttpGet("{modelId}")]
        public async Task<ActionResult<AvatarChart>> GetAvatarChart(long modelId)
        {
            var avatarChart = await _context.AvatarCharts.FindAsync(modelId);

            if (avatarChart == null)
            {
                return NotFound();
            }

            return avatarChart;
        }

        // PUT: api/AvatarCharts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{modelId}")]
        public async Task<IActionResult> PutAvatarChart(long modelId, AvatarChart avatarChart)
        {
            if (modelId != avatarChart.modelId)
            {
                return BadRequest();
            }

            _context.Entry(avatarChart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvatarChartExists(modelId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AvatarCharts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AvatarChart>> PostAvatarChart( AvatarChart avatarChart)
        {
            _context.AvatarCharts.Add(avatarChart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAvatarChart", new { modelId = avatarChart.modelId }, avatarChart);
        }

        // DELETE: api/AvatarCharts/5
        [HttpDelete("{modelId}")]
        public async Task<IActionResult> DeleteAvatarChart(long modelId)
        {
            var avatarChart = await _context.AvatarCharts.FindAsync(modelId);
            if (avatarChart == null)
            {
                return NotFound();
            }

            _context.AvatarCharts.Remove(avatarChart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AvatarChartExists(long modelId)
        {
            return _context.AvatarCharts.Any(e => e.modelId == modelId);
        }
    }
}

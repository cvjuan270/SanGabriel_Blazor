using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanGabriel_Blazor.Server.Data;
using SanGabriel_Blazor.Shared.Psico;

namespace SanGabriel_Blazor.Server.Controllers.Psico
{
    [Route("api/[controller]")]
    [ApiController]
    public class LSB_50Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LSB_50Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LSB_50
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LSB_50>>> GetLSB_50()
        {
            return await _context.LSB_50.ToListAsync();
        }

        // GET: api/LSB_50/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LSB_50>> GetLSB_50(int id)
        {
            var lSB_50 = await _context.LSB_50.FindAsync(id);

            if (lSB_50 == null)
            {
                return NotFound();
            }

            return lSB_50;
        }

        // PUT: api/LSB_50/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLSB_50(int id, LSB_50 lSB_50)
        {
            if (id != lSB_50.IdLSB_50)
            {
                return BadRequest();
            }

            _context.Entry(lSB_50).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LSB_50Exists(id))
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

        // POST: api/LSB_50
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LSB_50>> PostLSB_50(LSB_50 lSB_50)
        {
            _context.LSB_50.Add(lSB_50);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLSB_50", new { id = lSB_50.IdLSB_50 }, lSB_50);
        }

        // DELETE: api/LSB_50/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLSB_50(int id)
        {
            var lSB_50 = await _context.LSB_50.FindAsync(id);
            if (lSB_50 == null)
            {
                return NotFound();
            }

            _context.LSB_50.Remove(lSB_50);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LSB_50Exists(int id)
        {
            return _context.LSB_50.Any(e => e.IdLSB_50 == id);
        }
    }
}

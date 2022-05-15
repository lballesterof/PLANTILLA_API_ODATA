using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeTablasController : ControllerBase
    {
        //private readonly DataContext _context;

        //public OpeTablasController(DataContext context)
        //{
        //    _context = context;
        //}

        private readonly IOpeTablaServices opeTablaServices;

        public OpeTablasController(IOpeTablaServices opeTablaServices) =>
            this.opeTablaServices = opeTablaServices;




        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeTabla>> GetAllStudents()
        {
            IQueryable<OpeTabla> retrievedStudents =
                this.opeTablaServices.RetrieveAllTablas();

            return Ok(retrievedStudents);
        }


        //[HttpGet]
        //[EnableQuery]
        //public ActionResult<IQueryable<OpeTabla>> GetAllStudents()
        //{
        //    IQueryable<OpeTabla> retrievedStudents =
        //        this.opeTablaServices.RetrieveAllTablas();

        //    return Ok(retrievedStudents);
        //}

        // GET: api/OpeTablas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<OpeTabla>> GetOpeTabla(string id)
        //{
        //    var opeTabla = await _context.OpeTablas.FindAsync(id);

        //    if (opeTabla == null)
        //    {
        //        return NotFound();
        //    }

        //    return opeTabla;
        //}

        // PUT: api/OpeTablas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOpeTabla(string id, OpeTabla opeTabla)
        //{
        //    if (id != opeTabla.Codigo)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(opeTabla).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OpeTablaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/OpeTablas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<OpeTabla>> PostOpeTabla(OpeTabla opeTabla)
        //{
        //    _context.OpeTablas.Add(opeTabla);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (OpeTablaExists(opeTabla.Codigo))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetOpeTabla", new { id = opeTabla.Codigo }, opeTabla);
        //}

        // DELETE: api/OpeTablas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOpeTabla(string id)
        //{
        //    var opeTabla = await _context.OpeTablas.FindAsync(id);
        //    if (opeTabla == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.OpeTablas.Remove(opeTabla);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool OpeTablaExists(string id)
        //{
        //    return _context.OpeTablas.Any(e => e.Codigo == id);
        //}
    }
}

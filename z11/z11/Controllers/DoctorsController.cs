using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using z11.Modeles;
using z11.Services;

namespace z11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDbService _context;

        public DoctorsController(IDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            try
            {
                return Ok(_context.GetDoctors());
            }
            catch (Exception exc)
            {
                return StatusCode(400, exc.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            try
            {
                _context.AddDoctor(doctor);
                return Ok();
            }
            catch (Exception exc)
            {
                return StatusCode(400, exc.Message);
            }
        }

        [HttpDelete]
        public IActionResult RemoveDoctor(Doctor doctor)
        {
            try
            {
                _context.DeleteDoctor(doctor);
                return Ok();
            }
            catch (Exception exc)
            {
                return StatusCode(400, exc.Message);
            }
        }

        [Route("update")]
        [HttpPost]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            try
            {
                _context.MidifyDoctor(doctor);
                return Ok();
            }
            catch (Exception exc)
            {
                return StatusCode(400, exc.Message);
            }
        }
    }
}
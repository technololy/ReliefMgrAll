using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COVID19Relief.Middleware.Model;

namespace COVID19Relief.Middleware.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly COVONENINEContext _context;

        public UsersController(COVONENINEContext context)
        {
            _context = context;
        }


        [HttpGet]

        // GET: Users
        [Route("GetAllUsers")]

        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Users.ToListAsync());
        }
        [HttpGet]
        [Route("GetUserDetails")]
        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.UsersId == id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        //[HttpGet]
        //// GET: Users/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("CreateUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsersId,FirstName,MiddleName,LastName,Bvn,BvnIsValidated,Email,EmailIsValidated,PhoneNumber,PhoneNumberIsValidated,AccountNumber,AccountNumberIsValidated,BankId,StateId,CreatedOn,CreatedBy")] Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Ok(users);
        }
        //[HttpGet]

        //// GET: Users/Edit/5
        //[Route("EditUser")]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var users = await _context.Users.FindAsync(id);
        //    if (users == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(users);
        //}

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("EditUser")]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsersId,FirstName,MiddleName,LastName,Bvn,BvnIsValidated,Email,EmailIsValidated,PhoneNumber,PhoneNumberIsValidated,AccountNumber,AccountNumberIsValidated,BankId,StateId,CreatedOn,CreatedBy")] Users users)
        {
            if (id != users.UsersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.UsersId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Ok(users);
        }


        //[HttpGet]

        //// GET: Users/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var users = await _context.Users
        //        .FirstOrDefaultAsync(m => m.UsersId == id);
        //    if (users == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(users);
        //}

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("DeleteUser")]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.UsersId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using CarInsurance.ViewModels;
using Microsoft.Data.SqlClient;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InsureeManagerDb;Trusted_Connection=True;TrustServerCertificate=True";
        public IActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets, CoverageType, Quote FROM Insuree";

            List<Insuree> insurees = new List<Insuree>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var insuree = new Insuree();
                    insuree.Id = Convert.ToInt32(reader["ID"]);
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insuree.DateOfBirth = DateOnly.FromDateTime(Convert.ToDateTime(reader["DateOfBirth"]));
                    insuree.CarYear = Convert.ToInt32(reader["CarYear"]);
                    insuree.CarMake = reader["CarMake"].ToString();
                    insuree.CarModel = reader["CarModel"].ToString();
                    insuree.DUI = Convert.ToBoolean(reader["DUI"]);
                    insuree.SpeedingTickets = Convert.ToInt32(reader["SpeedingTickets"]);
                    insuree.CoverageType = reader["CoverageType"].ToString();
                    insuree.Quote = Convert.ToDecimal(reader["Quote"]);
                    insurees.Add(insuree);
                }
            }
            var insureeVms = new List<AdminVm>();
            foreach (var insuree in insurees)
            {
                var insureeVm = new AdminVm();
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
                insureeVm.Quote = insuree.Quote;
                insureeVms.Add(insureeVm);
            }

            return View(insureeVms);
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal baseQuote = 50m;
            decimal quote = baseQuote;

            // Calculate age
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > DateOnly.FromDateTime(DateTime.Now.AddYears(-age))) age--;

            // Age-based adjustments
            if (age < 19) quote += 100m;
            else if (age > 18 && age < 26) quote += 50m;
            else quote += 25m;

            // Car year-based adjustments
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015) quote += 25m;

            // Car make/model-based adjustments
            if (insuree.CarMake.ToLower() == "porsche") quote += 25m;
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera") quote += 25m;

            // DUI-based adjustments
            if (insuree.DUI) quote *= 1.25m;

            // Speeding ticket-based adjustments
            quote += insuree.SpeedingTickets * 10m;

            // Coverage type-based adjustments
            if (insuree.CoverageType.ToLower() == "full") quote *= 1.5m;

            return quote;
        }

        private readonly InsureeContext _context;

        public InsureeController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insuree
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insuree/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insuree/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree);
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(int id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }
    }
}

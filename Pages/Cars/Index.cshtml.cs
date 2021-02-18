using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMasini.Data;
using ProiectMasini.Models;

namespace ProiectMasini.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly ProiectMasini.Data.ProiectMasiniContext _context;

        public IndexModel(ProiectMasini.Data.ProiectMasiniContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}

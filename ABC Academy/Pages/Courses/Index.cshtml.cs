using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ABC_Academy.Data;
using ABC_Academy.Model;

namespace ABC_Academy.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ABC_Academy.Data.ABC_AcademyContext _context;

        public IndexModel(ABC_Academy.Data.ABC_AcademyContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ModelStateError.Models;

namespace ModelStateError
{
    public class IndexModel : PageModel
    {
        private readonly ModelStateError.Data.ModelStateErrorContext _context;

        public IndexModel(ModelStateError.Data.ModelStateErrorContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact.ToListAsync();
            }
        }
    }
}

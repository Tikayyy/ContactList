using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactList.Data;

namespace ContactList.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ContactList.Data.ContactListContext _context;

        public DeleteModel(ContactList.Data.ContactListContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactModel ContactModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactModel = await _context.ContactModel.FirstOrDefaultAsync(m => m.Id == id);

            if (ContactModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactModel = await _context.ContactModel.FindAsync(id);

            if (ContactModel != null)
            {
                _context.ContactModel.Remove(ContactModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

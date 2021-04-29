using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactList.Data;

namespace ContactList.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ContactList.Data.ContactListContext _context;

        public CreateModel(ContactList.Data.ContactListContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactModel ContactModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactModel.Add(ContactModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

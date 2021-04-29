using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactList.Data;

namespace ContactList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ContactList.Data.ContactListContext _context;

        public IndexModel(ContactList.Data.ContactListContext context)
        {
            _context = context;
        }

        public IList<ContactModel> ContactModel { get;set; }
        // Search
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
      
        [BindProperty(SupportsGet = true)]
        public DateTime SearchDate { get; set; }

        public async Task OnGetAsync()
        {
            var contact = from m in _context.ContactModel select m;

            if (!string.IsNullOrEmpty(SearchString) || SearchDate != default)
                {
                    contact = contact.Where(s => s.Name.Contains(SearchString) || s.Surname.Contains(SearchString) || s.Patronymic.Contains(SearchString)
                    || s.Company.Contains(SearchString) || s.Position.Contains(SearchString) || s.Phone.Contains(SearchString) || s.DopPhone.Contains(SearchString)
                    || s.Email.Contains(SearchString) || s.DopEmail.Contains(SearchString) || s.Skype.Contains(SearchString) || s.DopSkype.Contains(SearchString)
                    || s.Other.Contains(SearchString) || s.Birthday == SearchDate);
                }
            
            ContactModel = await contact.ToListAsync();
        }
    }
}

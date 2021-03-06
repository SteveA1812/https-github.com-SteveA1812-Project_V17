﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_V17.Data;
using Project_V17.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace Project_V17.Pages
{
    public class ApplicationCreateModel : PageModel
    {
        private readonly Project_V17.Data.ApplicationDbContext _context;

        public ApplicationCreateModel(Project_V17.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public FSApp FSApp { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
          
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FSApp.Add(FSApp);
            await _context.SaveChangesAsync();
            Message = $"Thank you, your application has now been created.  Your manager will review the application form and approve or deny. Once this has been completed all approved applications will be sent to the Executive for approval.";
            return RedirectToPage("Confirmation");
        }

       

    }
}
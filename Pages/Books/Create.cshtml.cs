﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rosculet_Cosmin_Laborator2.Data;
using Rosculet_Cosmin_Laborator2.Models;

namespace Rosculet_Cosmin_Laborator2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Rosculet_Cosmin_Laborator2.Data.Rosculet_Cosmin_Laborator2Context _context;

        public CreateModel(Rosculet_Cosmin_Laborator2.Data.Rosculet_Cosmin_Laborator2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

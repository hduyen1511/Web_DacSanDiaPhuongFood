﻿using Do_an_co_so.Data;
using Microsoft.AspNetCore.Mvc;

namespace Do_an_co_so.Models
{
    public class feature_productViewComponent:ViewComponent
    {

        private readonly Do_an_co_soContext _context;

        public feature_productViewComponent(Do_an_co_soContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_context.Categories.ToList());
        }
    }
}
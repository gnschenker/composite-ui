using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace VueDemo.Pages
{
    public class UserCardGridModel : PageModel
    {
        private readonly ILogger _logger;

        public UserCardGridModel(ILogger<UserCardGridModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

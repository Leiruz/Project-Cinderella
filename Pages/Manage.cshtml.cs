using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Cinderella.Pages
{
    [Authorize(Roles = "Admin, Staff")]
    public class ManageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Cinderella.Models;
using Microsoft.AspNetCore.Authorization;

namespace Cinderella.Pages.Roles
{
     [Authorize(Roles = "Admin")]
     public class IndexModel : PageModel
     {
          private readonly RoleManager<ApplicationRole> _roleManager;

          public IndexModel(RoleManager<ApplicationRole> roleManager)
          {
               _roleManager = roleManager;
          }

          public List<ApplicationRole> ApplicationRole { get; set; }

          public async Task OnGetAsync()
          {
               // Get a list of roles
               ApplicationRole = await _roleManager.Roles.ToListAsync();

          }
     }
}


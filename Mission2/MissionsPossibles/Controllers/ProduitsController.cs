using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission.Data;
using Mission.ViewModels;
using Mission.Models;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Connections;

namespace Mission.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly MissionDbContext _context;

        public ProduitsController(MissionDbContext context)
        {
            _context = context;
        }

        // GET: Produits
        public async Task<IActionResult> Index()
        {
            // COMPLÉTER ICI
            var missionDbContext = _context.Produits.Include(prop => prop.Categorie);
            return View(missionDbContext);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Moody.Context;

namespace Moody.Controllers
{
    public class TeamController : Controller
    {
        public ActionResult Manage()
        {
            List<Team> teams;
            using (var context = new MoodyContext())
            {
                teams = context.Teams.ToList();
            }
            return View(teams);
        }
        // GET: Team
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string teamName)
        {
            if (ModelState.IsValid)
            {
                var teams = new List<Team>();
                using (var context = new MoodyContext())
                {
                    context.Teams.Add(new Team
                    {
                        TeamName = teamName
                    });
                    context.SaveChanges();
                    teams = context.Teams.ToList();
                }
                return View("Manage", teams);
            }
            return View();
        }
    }
}
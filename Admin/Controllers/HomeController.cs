﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Admin.Models;

namespace SpeedLinkAdminPortal.Controllers
{
    [Route("Home")]
   
    [Authorize(Roles="admin")]
    public class HomeController : Controller
    {
        dbContext db = new dbContext();
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        RoleManager<IdentityRole> roleManager;
        public HomeController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        [Route("Dashboard")]
        [Route("")]
        public async Task<IActionResult> Dashboard(string date_from, string date_to)
        {
            ViewBag.title = "Dashboard";

            try
            {

                ViewBag.date_from = date_from;
                ViewBag.date_to = date_to;

            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error fetching data from server";
                TempData["type"] = "error";
                TempData["ex"] = ex.Message;
            }

            return View();
        }



        [HttpGet("AllRoles")]
        public IActionResult AllRoles()
        {
            ViewBag.title = "All Roles";
            var roles = roleManager.Roles.ToList();
            ViewBag.roles = roles;
            return View();
        }


    }
}

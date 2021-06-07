using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Admin.Models;

namespace Admin.Controllers
{
    [Route("CaseReports")]
    [Route("")]
    [Authorize(Roles = "admin")]
    public class CaseReportsController : Controller
    {
        dbContext db = new dbContext();
        private string source = "Admin.Controllers.ClientsController.";
        UserManager<IdentityUser> userManager;
        RoleManager<IdentityRole> roleManager;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        public CaseReportsController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet("ajaxListCaseReports")]
        public IActionResult ajaxListCaseReports()
        {
            ViewBag.title = "CaseReports";
            var case_reports = db.CaseReport.ToList();
            ViewBag.case_reports = case_reports;
            return View();
        }

        [HttpGet("Index")]
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.title = "CaseReports";
            return View();
        }

        [HttpGet("DeleteCaseReport/{id}")]
        public async Task<IActionResult> DeleteCaseReport(string id)
        {
            ViewBag.title = "Delete CaseReport";
            try
            {
                var case_report = db.CaseReport.Where(i => i.Id == id).FirstOrDefault();
                db.Remove(case_report);
                await db.SaveChangesAsync();
                TempData["type"] = "success";
                TempData["msg"] = "Deleted";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = "Error: " + ex.Message;
                return RedirectToAction("Index");
            }
        }


        [HttpGet("CreateCaseReport")]
        public IActionResult CreateCaseReport()
        {
            ViewBag.title = "Create CaseReport";

            //create a case report
            CaseReport _caseReport = new CaseReport();
            _caseReport.Id = Guid.NewGuid().ToString();

            CaseReportClientInformation _caseReportClientInformation = new CaseReportClientInformation();
            _caseReportClientInformation.CaseId = _caseReport.Id;

            CaseReportDescriptionOfTheCaseProblem _caseReportDescriptionOfTheCaseProblem = new CaseReportDescriptionOfTheCaseProblem();
            _caseReportDescriptionOfTheCaseProblem.CaseId = _caseReport.Id;

            CaseReportNeedsAssesment _caseReportNeedsAssesment = new CaseReportNeedsAssesment();
            _caseReportNeedsAssesment.CaseId = _caseReport.Id;

            CaseReportNextOfKin _caseReportNextOfKin = new CaseReportNextOfKin();
            _caseReportNextOfKin.CaseId = _caseReport.Id;

            CaseReportParentsGuardiansSpousesInformation _caseReportParentsGuardiansSpousesInformation = new CaseReportParentsGuardiansSpousesInformation();
            _caseReportParentsGuardiansSpousesInformation.CaseId = _caseReport.Id;

            db.CaseReport.Add(_caseReport);
            db.CaseReportClientInformation.Add(_caseReportClientInformation);
            db.CaseReportDescriptionOfTheCaseProblem.Add(_caseReportDescriptionOfTheCaseProblem);
            db.CaseReportNeedsAssesment.Add(_caseReportNeedsAssesment);
            db.CaseReportNextOfKin.Add(_caseReportNextOfKin);
            db.CaseReportParentsGuardiansSpousesInformation.Add(_caseReportParentsGuardiansSpousesInformation);

            db.SaveChanges();

            ViewBag.caseReport = _caseReport;
            ViewBag.caseReportClientInformation = _caseReportClientInformation;
            ViewBag.caseReportDescriptionOfTheCaseProblem = _caseReportDescriptionOfTheCaseProblem;
            ViewBag.caseReportNeedsAssesment = _caseReportNeedsAssesment;
            ViewBag.caseReportNextOfKin = _caseReportNextOfKin;
            ViewBag.caseReportParentsGuardiansSpousesInformation = _caseReportParentsGuardiansSpousesInformation;

            return View();
        }

        [HttpPost("CreateUpDateCaseReport")]
        public async Task<IActionResult> CreateUpDateCaseReport
            (
              CaseReport _caseReport,
              CaseReportClientInformation _caseReportClientInformation,
              CaseReportDescriptionOfTheCaseProblem _caseReportDescriptionOfTheCaseProblem,
              CaseReportNeedsAssesment _caseReportNeedsAssesment,
              CaseReportNextOfKin _caseReportNextOfKin,
              CaseReportParentsGuardiansSpousesInformation _caseReportParentsGuardiansSpousesInformation
              )
        {
            ViewBag.title = "Create UpDateCaseReport";

            try
            {

                {
                    try
                    {
                        var caseReport = db.CaseReport.Where(i => i.Id == _caseReport.Id).Any();
                        if (!caseReport)
                        {
                            db.CaseReport.Add(_caseReport);
                        }
                        else
                        {
                            db.Entry(_caseReport).State = EntityState.Modified;
                        }
                        //
                        var caseReportClientInformation = db.CaseReportClientInformation.Where(i => i.Id == _caseReportClientInformation.Id).Any();
                        if (!caseReportClientInformation)
                        {
                            db.CaseReportClientInformation.Add(_caseReportClientInformation);
                        }
                        else
                        {
                            db.Entry(_caseReportClientInformation).State = EntityState.Modified;
                        }
                        //
                        var caseReportDescriptionOfTheCaseProblem = db.CaseReportDescriptionOfTheCaseProblem.Where(i => i.Id == _caseReportDescriptionOfTheCaseProblem.Id).Any();
                        if (!caseReportDescriptionOfTheCaseProblem)
                        {
                            db.CaseReportDescriptionOfTheCaseProblem.Add(_caseReportDescriptionOfTheCaseProblem);
                        }
                        else
                        {
                            db.Entry(_caseReportDescriptionOfTheCaseProblem).State = EntityState.Modified;
                        }
                        //
                        var caseReportNeedsAssesment = db.CaseReportNeedsAssesment.Where(i => i.Id == _caseReportNeedsAssesment.Id).Any();
                        if (!caseReportNeedsAssesment)
                        {
                            db.CaseReportNeedsAssesment.Add(_caseReportNeedsAssesment);
                        }
                        else
                        {
                            db.Entry(_caseReportNeedsAssesment).State = EntityState.Modified;
                        }
                        //
                        var caseReportNextOfKin = db.CaseReportNextOfKin.Where(i => i.Id == _caseReportNextOfKin.Id).Any();
                        if (!caseReportNextOfKin)
                        {
                            db.CaseReportNextOfKin.Add(_caseReportNextOfKin);
                        }
                        else
                        {
                            db.Entry(_caseReportNextOfKin).State = EntityState.Modified;
                        }
                        //
                        var caseReportParentsGuardiansSpousesInformation = db.CaseReportParentsGuardiansSpousesInformation.Where(i => i.Id == _caseReportParentsGuardiansSpousesInformation.Id).Any();
                        if (!caseReportParentsGuardiansSpousesInformation)
                        {
                            db.CaseReportParentsGuardiansSpousesInformation.Add(_caseReportParentsGuardiansSpousesInformation);
                        }
                        else
                        {
                            db.Entry(_caseReportParentsGuardiansSpousesInformation).State = EntityState.Modified;
                        }

                        await db.SaveChangesAsync();
                        //transaction.Commit();
                        TempData["type"] = "success";
                        TempData["msg"] = "Record Saved";
                        return RedirectToAction("Index");

                    }
                    catch (Exception ex)
                    {
                        TempData["type"] = "error";
                        TempData["msg"] = "Error " + ex.Message;
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = "Error " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet("EditCaseReport/{id}")]
        public IActionResult EditCaseReport(string id)
        {
            ViewBag.title = "Edit CaseReport";
            var caseReport = db.CaseReport.Where(i => i.Id == id).FirstOrDefault();
            var caseReportClientInformation = db.CaseReportClientInformation.Where(i => i.CaseId == id).FirstOrDefault();
            var caseReportDescriptionOfTheCaseProblem = db.CaseReportDescriptionOfTheCaseProblem.Where(i => i.CaseId == id).FirstOrDefault();
            var caseReportNeedsAssesment = db.CaseReportNeedsAssesment.Where(i => i.CaseId == id).FirstOrDefault();
            var caseReportNextOfKin = db.CaseReportNextOfKin.Where(i => i.CaseId == id).FirstOrDefault();
            var caseReportParentsGuardiansSpousesInformation = db.CaseReportParentsGuardiansSpousesInformation.Where(i => i.CaseId == id).FirstOrDefault();

            ViewBag.caseReport = caseReport;
            ViewBag.caseReportDescriptionOfTheCaseProblem = caseReportDescriptionOfTheCaseProblem;
            ViewBag.caseReportClientInformation = caseReportClientInformation;
            ViewBag.caseReportNeedsAssesment = caseReportNeedsAssesment;
            ViewBag.caseReportNextOfKin = caseReportNextOfKin;
            ViewBag.caseReportParentsGuardiansSpousesInformation = caseReportParentsGuardiansSpousesInformation;

            return View("CreateCaseReport");
        }




    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace MobileApi.Controllers
{
    [Route("mobile_api/v1")]
    public class MobileAPIController : Controller
    {
        private readonly ILogger _logger;

        public MobileAPIController(ILoggerFactory logFactory)
        {
            _logger = logFactory.CreateLogger<MobileAPIController>();
        }


        private readonly dbContext db = new dbContext();
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }



        [HttpPost("UpdateCaseReport")]
        public async Task<JsonResult> UpdateCaseReport
           (
           string __caseReport,
           string __caseReportClientInformation,
           string __caseReportDescriptionOfTheCaseProblem,
           string __caseReportNeedsAssesment,
           string __caseReportNextOfKin,
           string __caseReportCareGiver,
           string __caseReportParentsGuardiansSpousesInformation
           )
        {
            _logger.LogInformation("__caseReport: " + __caseReport);
            _logger.LogInformation("__caseReportClientInformation: " + __caseReportClientInformation);
            _logger.LogInformation("__caseReportDescriptionOfTheCaseProblem: " + __caseReportDescriptionOfTheCaseProblem);
            _logger.LogInformation("__caseReportNeedsAssesment: " + __caseReportNeedsAssesment);
            _logger.LogInformation("__caseReportNextOfKin: " + __caseReportNextOfKin);
            _logger.LogInformation("__caseReportCareGiver: " + __caseReportCareGiver);
            _logger.LogInformation("__caseReportParentsGuardiansSpousesInformation: " + __caseReportParentsGuardiansSpousesInformation);

            try
            {
                CaseReport _caseReport = JsonConvert.DeserializeObject<CaseReport>(__caseReport);
                CaseReportClientInformation _caseReportClientInformation = JsonConvert.DeserializeObject<CaseReportClientInformation>(__caseReportClientInformation);
                CaseReportDescriptionOfTheCaseProblem _caseReportDescriptionOfTheCaseProblem = JsonConvert.DeserializeObject<CaseReportDescriptionOfTheCaseProblem>(__caseReportDescriptionOfTheCaseProblem);
                CaseReportNeedsAssesment _caseReportNeedsAssesment = JsonConvert.DeserializeObject<CaseReportNeedsAssesment>(__caseReportNeedsAssesment);
                CaseReportNextOfKin _caseReportNextOfKin = JsonConvert.DeserializeObject<CaseReportNextOfKin>(__caseReportNextOfKin);
                CareReportCareGiver _caseReportCareGiver = JsonConvert.DeserializeObject<CareReportCareGiver>(__caseReportCareGiver);
                CaseReportParentsGuardiansSpousesInformation _caseReportParentsGuardiansSpousesInformation = JsonConvert.DeserializeObject<CaseReportParentsGuardiansSpousesInformation>(__caseReportParentsGuardiansSpousesInformation);


                //using (var transaction = db.Database.BeginTransaction())
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
                        var careReportCareGiver = db.CareReportCareGiver.Where(i => i.Id == _caseReportCareGiver.Id).Any();
                        if (!careReportCareGiver)
                        {
                            db.CareReportCareGiver.Add(_caseReportCareGiver);
                        }
                        else
                        {
                            db.Entry(_caseReportCareGiver).State = EntityState.Modified;
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
                        return Json(new
                        {
                            res = "ok",
                            msg = "case report updated",
                        });
                    }
                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        return Json(new
                        {
                            res = "err",
                            msg = ex.Message
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    msg = ex.Message
                });
            }
        }


        }//.
}//.

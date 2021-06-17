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
            String __casePlanCaseLog,
            String __casePlanCaseWorkplan,
            String __caseReport,
            String __caseReportCareGiver,
            String __caseReportCasePlanAndFollowUp,
            String __caseReportClientInformation,
            String __caseReportDescriptionOfTheCaseProblem,
            String __caseReportJustificationReportForAttendedCases,
            String __caseReportNeedsAssesment,
            String __caseReportNextOfKin,
            String __caseReportParentsGuardiansSpousesInformation,
            String __caseReportPaymentsToBeneficiaries
           )
        {
            //_logger.LogInformation("__caseReport: " + __caseReport);
            //_logger.LogInformation("__caseReportClientInformation: " + __caseReportClientInformation);
            //_logger.LogInformation("__caseReportDescriptionOfTheCaseProblem: " + __caseReportDescriptionOfTheCaseProblem);
            //_logger.LogInformation("__caseReportNeedsAssesment: " + __caseReportNeedsAssesment);
            //_logger.LogInformation("__caseReportNextOfKin: " + __caseReportNextOfKin);
            //_logger.LogInformation("__caseReportCareGiver: " + __caseReportCareGiver);
            //_logger.LogInformation("__caseReportParentsGuardiansSpousesInformation: " + __caseReportParentsGuardiansSpousesInformation);

            try
            {
                CaseReport _caseReport = JsonConvert.DeserializeObject<CaseReport>(__caseReport);
                CaseReportClientInformation _caseReportClientInformation = JsonConvert.DeserializeObject<CaseReportClientInformation>(__caseReportClientInformation);
                CaseReportDescriptionOfTheCaseProblem _caseReportDescriptionOfTheCaseProblem = JsonConvert.DeserializeObject<CaseReportDescriptionOfTheCaseProblem>(__caseReportDescriptionOfTheCaseProblem);
                CaseReportNeedsAssesment _caseReportNeedsAssesment = JsonConvert.DeserializeObject<CaseReportNeedsAssesment>(__caseReportNeedsAssesment);
                CaseReportNextOfKin _caseReportNextOfKin = JsonConvert.DeserializeObject<CaseReportNextOfKin>(__caseReportNextOfKin);
                CareReportCareGiver _caseReportCareGiver = JsonConvert.DeserializeObject<CareReportCareGiver>(__caseReportCareGiver);
                CaseReportParentsGuardiansSpousesInformation _caseReportParentsGuardiansSpousesInformation = JsonConvert.DeserializeObject<CaseReportParentsGuardiansSpousesInformation>(__caseReportParentsGuardiansSpousesInformation);

                List<CasePlanCaseLog> _casePlanCaseLog = JsonConvert.DeserializeObject<List<CasePlanCaseLog>>(__casePlanCaseLog);
                List<CasePlanCaseWorkplan> _casePlanCaseWorkplan = JsonConvert.DeserializeObject<List<CasePlanCaseWorkplan>>(__casePlanCaseWorkplan);
                CaseReportCasePlanAndFollowUp _caseReportCasePlanAndFollowUp = JsonConvert.DeserializeObject<CaseReportCasePlanAndFollowUp>(__caseReportCasePlanAndFollowUp);
                List<CaseReportJustificationReportForAttendedCases> _caseReportJustificationReportForAttendedCases = JsonConvert.DeserializeObject<List<CaseReportJustificationReportForAttendedCases>>(__caseReportJustificationReportForAttendedCases);
                List<CaseReportPaymentsToBeneficiaries> _caseReportPaymentsToBeneficiaries = JsonConvert.DeserializeObject<List<CaseReportPaymentsToBeneficiaries>>(__caseReportPaymentsToBeneficiaries);

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
                        if (_caseReportCasePlanAndFollowUp != null)
                        {
                            var caseReportCasePlanAndFollowUp = db.CaseReportCasePlanAndFollowUp.Where(i => i.Id == _caseReportCasePlanAndFollowUp.Id).Any();
                            if (!caseReportCasePlanAndFollowUp)
                            {
                                db.CaseReportCasePlanAndFollowUp.Add(_caseReportCasePlanAndFollowUp);
                            }
                            else
                            {
                                db.Entry(_caseReportCasePlanAndFollowUp).State = EntityState.Modified;
                            }
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

                        //clear all list items
                        db.CasePlanCaseLog.RemoveRange(db.CasePlanCaseLog.Where(i => i.CaseId == _caseReport.Id).ToList());
                        db.CasePlanCaseWorkplan.RemoveRange(db.CasePlanCaseWorkplan.Where(i => i.CaseId == _caseReport.Id).ToList());
                        db.CaseReportJustificationReportForAttendedCases.RemoveRange(db.CaseReportJustificationReportForAttendedCases.Where(i => i.CaseId == _caseReport.Id).ToList());
                        db.CaseReportPaymentsToBeneficiaries.RemoveRange(db.CaseReportPaymentsToBeneficiaries.Where(i => i.CaseId == _caseReport.Id).ToList());

                        //add all lists
                        db.CasePlanCaseLog.AddRange(_casePlanCaseLog);
                        db.CasePlanCaseWorkplan.AddRange(_casePlanCaseWorkplan);
                        db.CaseReportJustificationReportForAttendedCases.AddRange(_caseReportJustificationReportForAttendedCases);
                        db.CaseReportPaymentsToBeneficiaries.AddRange(_caseReportPaymentsToBeneficiaries);

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

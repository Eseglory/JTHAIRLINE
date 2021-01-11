using Hangfire;
using HangFire.EventQueue.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFire.EventQueue.System.Controllers
{
    [Route("api/hangfire")]
    public class HangFireController : Controller
    {
        private IHangFireService _hangFireService;
        public HangFireController(IHangFireService hangFireService)
        {
            _hangFireService = hangFireService;
        }
        public IActionResult Index()
        {
            RecurringJob.AddOrUpdate("MAILER-JOB", () =>_hangFireService.RunHangFireTask(), Cron.Minutely);
            return Ok();
        }
    }
}

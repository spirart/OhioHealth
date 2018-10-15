using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BabysitterWageCalculater.API.Models;

namespace BabysitterWageCalculater.API.Controllers
{
    public class WageCalcuatorController : ApiController
    {
        [Route("api/WageCalcuator/GetBabysitterWage/{startTime:DateTime}/{beginTime:DateTime}/{bedTime:DateTime}")]
        [HttpPost]
        public decimal GetBabysitterWage(DateTime startTime, DateTime endTime, DateTime bedTime)
        {
            TimeSpan timeDifference = endTime.Subtract(startTime);
            long hourDifference = timeDifference.Hours;
            DateTime hourWorked = DateTime.MinValue;
            decimal hourlyWagesSum = 0;
            List<Models.HourlyRate> hourlyRates = new List<HourlyRate>();

            for (int i = 0; i <= hourDifference; ++i)
            {
                var hourlyRate = new HourlyRate( startTime.AddHours(i), bedTime);
                hourlyRates.Add(hourlyRate);
            }

            hourlyWagesSum = hourlyRates.Select(x => x.wage).Sum();

            return hourlyWagesSum;
        }     
    }
}

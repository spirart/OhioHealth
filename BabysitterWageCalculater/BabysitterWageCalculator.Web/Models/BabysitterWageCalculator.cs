using System;
using System.ComponentModel.DataAnnotations;

namespace BabysitterWageCalculator.Web.Models
{
    public class BabysitterWageCalculator
    {
        private DateTime _startTime = DateTime.MinValue;
        private DateTime _endTime = DateTime.MinValue;
        private DateTime _bedTime = DateTime.MinValue;
        private Decimal _totalWage = 0;

        public BabysitterWageCalculator()
        {
        }

        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime bedTime { get; set; }
        public Decimal totalWage { get; set; }
    }
}
using System;

namespace BabysitterWageCalculater.API.Models
{
    public class HourlyRate

    {
        private DateTime _hour = DateTime.MinValue;
        private Decimal _wage = 0;
        private DateTime _bedTime = DateTime.MinValue;
        private TimeSpan _midnight = new TimeSpan(24, 0, 0);

        public HourlyRate(DateTime hour, DateTime kidsBedTime)
        {
            this.hour = hour;
            this.bedtime = kidsBedTime;
            SetWage();
        }
        
        public DateTime hour { get; set; }

        public DateTime bedtime { get; set; }

        /// <summary>
        /// A babyitter gets paid for the full hour.
        /// So the wage is rounded up.
        /// </summary>
        public Decimal wage { get { return Math.Ceiling(_wage); } }

        private void SetWage()
        {
            if (this.hour.TimeOfDay <= bedtime.TimeOfDay)
            {
                _wage = 12;
            }

            if ((this.hour.TimeOfDay < bedtime.TimeOfDay) & (this.hour.TimeOfDay >= _midnight))
            {
                _wage = 8;
            }

            if (this.hour.TimeOfDay > _midnight) 
            {
                _wage = 16;
            }
        }


    }
}
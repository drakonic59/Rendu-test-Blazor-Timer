using System;
using System.ComponentModel.DataAnnotations;


namespace tp
{
    public class TimerForm
    {

        [Required]
        [Range(1, 59, ErrorMessage = "Enter a number between 1 and 59 (seconds).")]
        public int interval { get; set; }

        public int getInterval() {
            return interval;
        }

    }
}

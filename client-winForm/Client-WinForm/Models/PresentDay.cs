﻿

using Client_WinForm.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_WinForm.Models
{
    public class PresentDay
    {
        public PresentDay()
        {
        }
        [Key]

        public int IdPresentDay { get; set; }
        [ValidDateTimeBegin]
        public DateTime TimeBegin { get; set; }

       //TODO: [ValidDateTimeEnd]
        public DateTime TimeEnd { get; set; }

        public decimal sumHoursDay { get; set; }

        public int WorkerId { get; set; }

        public int ProjectId { get; set; }



    }
}

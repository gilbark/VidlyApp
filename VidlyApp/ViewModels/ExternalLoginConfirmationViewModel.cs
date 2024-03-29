﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace VidlyApp.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
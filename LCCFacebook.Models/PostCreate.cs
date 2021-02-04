﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCFacebook.Models
{
    public class PostCreate
    {
        [Required, MinLength(1, ErrorMessage = "Please enter at least one character.")]
        public string Content { get; set; }
    }
}

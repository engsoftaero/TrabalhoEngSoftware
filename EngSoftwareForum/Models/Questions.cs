﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EngSoftwareForum.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Question { get; set; }
    }
}

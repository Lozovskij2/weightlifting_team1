﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeightliftingTeam1.ModelsForOutput
{
    public class Record
    {
        public string Competition { get; set; }

        public string Excercise { get; set; }

        [Display(Name = "Category")]
        public string WeightCategory { get; set; }

        public float Result { get; set; }

        [Display(Name = "Type")]
        public string RecordType { get; set; }

        [Display(Name = "Name")]
        public string AthleteName { get; set; }
    }
}

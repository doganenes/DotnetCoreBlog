﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoreBlog.EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }     
        public virtual ICollection<Match> HomeMatches {  get; set; }
        public virtual ICollection<Match> AwayMatches {  get; set; }

    }
}

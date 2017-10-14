using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorPractice.Models
{
    public class Album
    {
        public string Artist { get; set; }
        public string Song { get; set; }
        public int ReleaseDate { get; set; } 
        public double Price { get; set; }

    }
}
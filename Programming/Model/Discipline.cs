using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        public string Name {  get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public int Hours { get; set; } = 0;
        public Discipline() { }

        public Discipline(string name, string faculty, int hours)
        {
            Name = name;
            Faculty = faculty;
            Hours = hours;
        }
    }
}

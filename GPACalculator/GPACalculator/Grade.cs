using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    internal class Grade
    {
        private int creditHours;
        private String letterGrade;

        public Grade() { }

        public Grade(int creditHours, String letterGrade)
        {
            this.creditHours = creditHours;
            this.letterGrade = letterGrade;
        }

        public int getCreditHours()
        {
            return creditHours;
        }

        public void setCreditHours(int creditHours)
        {
            this.creditHours = creditHours;
        }

        public String getLetterGrade()
        {
            return letterGrade;
        }

        public void setLetterGrade(String letterGrade)
        {
            this.letterGrade = letterGrade;
        }
    }
}

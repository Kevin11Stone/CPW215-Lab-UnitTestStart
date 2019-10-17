using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte _numberOfCredits;
        private string _courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course in question
        /// </summary>
        public string InstructorName { get; set; }



        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        {
            get
            {
                return _courseName;
            }
            set
            {
                if ( value == null )
                {
                    throw new ArgumentNullException("Course name cannot be null");
                }
                _courseName = value;
            }
        }


        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get
            {
                return _numberOfCredits;
            }
            set
            {
                if ( value >= 30 || value <= 0 )
                {
                    throw new ArgumentException("Number of credits must be " +
                        "between 0 and 30 inclusive.");
                }
                _numberOfCredits = value;
            }
        }

    }
}

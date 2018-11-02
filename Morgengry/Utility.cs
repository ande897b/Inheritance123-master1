using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        double value = 0;
        public double LowQualityValue
        {
            get {  return value; }
            set { value = 12.5; }
        }
        public double MediumQualityValue
        {
            get { return value; }
            set { value = 20; }
        }
        public double HighQualityValue
        {
            get { return value; }
            set { value = 27.5; }
        }
        public double CourseHourValue
        {
            get { return value; }
            set { value = 825; }
        }





        public static double GetValueOfCourse(Course course)
        {
            double initialPrice = 875;
            double coursePrice = 0.0;
            for (int i = 0; i < course.DurationInMinutes / 60; i++)
            {
                coursePrice += 875;
            }

            if (course.DurationInMinutes == 0)
            {
                return 0;
            }
            else
            {
                return coursePrice + initialPrice;
            }

        }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            
            if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;

                if (amulet.getQuality() == Amulet.Level.low)
                {
                    value = 12.5;
                }
                else if (amulet.getQuality() == Amulet.Level.medium)
                {
                    value = 20.0;
                }
                else
                {
                    value = 27.5;
                }
            }
            else if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                value = book.Price;
            }
            else
            {
                value = 0;
            }
            return value;
        }


    }
}

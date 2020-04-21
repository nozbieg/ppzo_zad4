﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppzo_zad4
{
    class OpisDaty
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public OpisDaty(int day, int month, int year)
        {
           
            this.Day = day;
            this.Month = month;
            this.Year = year;
            try
            {
                if (dateValidation() == false)
                {
                    Console.WriteLine("Błędnie skonstruowana data");
                }

            }catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public bool dateValidation()
        {
            bool confirm = false;
            if (this.Day > MonthLength() || this.Month >12)
            {
                confirm = false;
            }
            else
            {
                confirm = true;
            }
            return confirm;
        }

        public string ShowData()
        {
            string fullData = Day + "." + Month + "." + Year;

            return fullData;
        }
        public bool LeapYearCheck(int year)
        {
            bool leapCheck = false;
            if (year % 4 == 0)
            {
                return leapCheck = true;
            }
            else
            {
                leapCheck = false;
            }
            return leapCheck;
        }
        public int MonthLength()
        {
            int monthLength;
            switch (this.Month)
            {
                case 1:
                    monthLength = 31;
                    break;
                case 2:
                    if (LeapYearCheck(this.Year) == true)
                    {
                        monthLength = 29;
                    }
                    else
                    {
                        monthLength = 28;
                    }
                    break;
                case 3:
                    monthLength = 31;
                    break;
                case 4:
                    monthLength = 30;
                    break;
                case 5:
                    monthLength = 31;
                    break;
                case 6:
                    monthLength = 30;
                    break;
                case 7:
                    monthLength = 31;
                    break;
                case 8:
                    monthLength = 31;
                    break;
                case 9:
                    monthLength = 30;
                    break;
                case 10:
                    monthLength = 31;
                    break;
                case 11:
                    monthLength = 30;
                    break;
                case 12:
                    monthLength = 31;
                    break;
                default:
                    monthLength = 31;
                    break;

            }
            return monthLength;
        }
         public void addWeek()
        {
            int day = this.Day;
            day += 7;
            if (day > MonthLength())
            {
                day = day - MonthLength();
                this.Month++;
                
            }
            this.Day = day;
            
            if (this.Month > 12)
            {
                this.Year++;
                this.Month = 1;
            }
        }

        public void subWeek()
        {
            int day = this.Day;
            day-= 7;
            if (day <= 0)
            {
                if (day == 0)
                {
                    this.Month--;
                    day = MonthLength();
                }
                if(day < 0)
                {
                    this.Month--;
                    day = MonthLength() -( day * (-1));

                }
                          
            }
            this.Day = day;

            if (this.Month < 1)
            {
                this.Year--;
                this.Month = 12;
            }
        }
        public int MonthLength(int month)
        {
            int monthLength;
            switch (month)
            {
                case 1:
                    monthLength = 31;
                    break;
                case 2:
                    if (LeapYearCheck(this.Year) == true)
                    {
                        monthLength = 29;
                    }
                    else
                    {
                        monthLength = 28;
                    }
                    break;
                case 3:
                    monthLength = 31;
                    break;
                case 4:
                    monthLength = 30;
                    break;
                case 5:
                    monthLength = 31;
                    break;
                case 6:
                    monthLength = 30;
                    break;
                case 7:
                    monthLength = 31;
                    break;
                case 8:
                    monthLength = 31;
                    break;
                case 9:
                    monthLength = 30;
                    break;
                case 10:
                    monthLength = 31;
                    break;
                case 11:
                    monthLength = 30;
                    break;
                case 12:
                    monthLength = 31;
                    break;
                default:
                    monthLength = 31;
                    break;

            }
            return monthLength;
        }


    }
}
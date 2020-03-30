using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        private int differenceBetweenDates;

        public int DifferenceBetweenDates
        {
            get
            {
                return this.differenceBetweenDates;
            }
         
        }

        public int Calculate(string date1,string date2)
        {
            var parsedDate1 = date1.Split();
            var dateFirst = DateTime.Parse($"{parsedDate1[1]}/{parsedDate1[0]}/{parsedDate1[2]}");
            var parsedDate2 = date1.Split();
            var dateSecond = DateTime.Parse($"{parsedDate2[1]}/{parsedDate2[0]}/{parsedDate2[2]}");

            return 0;
        }
    }
}

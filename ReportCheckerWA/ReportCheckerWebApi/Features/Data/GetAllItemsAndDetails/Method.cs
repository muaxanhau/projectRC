using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.GetAllItemsAndDetails
{
    public class Method
    {
        public List<List<string>> Execute()
        {
            var dataCollection = new List<List<string>>();

            var DBDateAndlistItems = DBEntity.Method.getAllDateAndListItems();
            var dateAndListItemsGrouped = DBDateAndlistItems.GroupBy(p => p.Item);
            foreach (var dateAndListItems in dateAndListItemsGrouped)
            {
                var itemFiltered = new List<string>();
                itemFiltered.Add(dateAndListItems.ElementAt(0).Item.Name);

                int totals = dateAndListItems.Sum(p => p.Quantity);
                itemFiltered.Add(totals.ToString());

                var date = DateTime.Now;

                //=============================================

                int dayBegin = date.Day;
                int dayMonthBegin = date.Month;
                int dayYearBegin = date.Year;
                int daySum = 0;
                var dayGrouped = dateAndListItems.GroupBy(p => new {p.Day, p.Month, p.Year});
                foreach (var day in dayGrouped)
                {
                    int dayTmp = day.ElementAt(0).Day;
                    int monthTmp = day.ElementAt(0).Month;
                    int yearTmp = day.ElementAt(0).Year;
                    if (yearTmp < date.Year || (monthTmp < date.Month && yearTmp == date.Year) || (dayTmp < date.Day && monthTmp == date.Month && yearTmp == date.Year)) {
                        if (yearTmp < dayYearBegin) {
                            dayBegin = dayTmp;
                            dayMonthBegin = monthTmp;
                            dayYearBegin = yearTmp;
                        } else if (monthTmp < dayMonthBegin && yearTmp == dayYearBegin) {
                            dayBegin = dayTmp;
                            dayMonthBegin = monthTmp;
                        } else if (dayTmp < dayBegin && monthTmp == dayMonthBegin && yearTmp == dayYearBegin) {
                            dayBegin = dayTmp;
                        }
                        daySum += day.Sum(p => p.Quantity);
                    }
                }
                if (dayBegin == date.Day && dayMonthBegin == date.Month && dayYearBegin == date.Year) {
                    itemFiltered.Add("-1");
                } else {
                    DateTime nowDate = new DateTime(date.Year, date.Month, date.Day);
                    DateTime beginDate = new DateTime(dayYearBegin, dayMonthBegin, dayBegin);
                    int dayCounter = (int)(nowDate.Subtract(beginDate)).TotalDays;
                    float averageDay = (float)daySum / (float)dayCounter;
                    itemFiltered.Add(averageDay.ToString("n1"));
                }

                //=============================================

                int monthBegin = date.Month;
                int monthYearBegin = date.Year;
                int monthSum = 0;
                var monthGrouped = dateAndListItems.GroupBy(p => new {p.Month, p.Year});
                foreach (var month in monthGrouped)
                {
                    int monthTmp = month.ElementAt(0).Month;
                    int yearTmp = month.ElementAt(0).Year;
                    if (yearTmp < date.Year || (monthTmp < date.Month && yearTmp == date.Year)) {
                        if (yearTmp < monthYearBegin) {
                            monthBegin = monthTmp;
                            monthYearBegin = yearTmp;
                        } else if (monthTmp < monthBegin && yearTmp == monthYearBegin) {
                            monthBegin = monthTmp;
                            monthYearBegin = yearTmp;
                        }
                        monthSum += month.Sum(p => p.Quantity);
                    }
                }
                if (monthBegin == date.Month && monthYearBegin == date.Year) {
                    itemFiltered.Add("-1");
                } else {
                    int monthCounter = (date.Year - monthYearBegin) * 12 + date.Month - monthBegin;
                    
                    float averageMonth = (float)monthSum / (float)monthCounter;
                    itemFiltered.Add(averageMonth.ToString("n1"));
                }

                //=============================================

                int yearBegin = date.Year;
                int yearSum = 0;
                var yearGrouped = dateAndListItems.GroupBy(p => p.Year);
                foreach (var year in yearGrouped)
                {
                    int yearTmp = year.ElementAt(0).Year;
                    if (yearTmp < date.Year) {
                        yearBegin = (yearTmp < yearBegin) ? yearTmp : yearBegin;
                        yearSum += year.Sum(p => p.Quantity);
                    }
                }
                if (yearBegin == date.Year) {
                    itemFiltered.Add("-1");
                } else {
                    float averageYear = (float)yearSum / (float)(date.Year - yearBegin);
                    itemFiltered.Add(averageYear.ToString("n1"));
                }
                
                dataCollection.Add(itemFiltered);
            }

            float avrMonthMax = 0;
            float avrMonthSum = 0;
            int avrMonthCounter = 0;
            foreach(var item in dataCollection) {
                float avrMonth;
			    float.TryParse(item[3], out avrMonth);
                avrMonthMax = avrMonth > avrMonthMax ? avrMonth : avrMonthMax;
                avrMonthSum += avrMonth;
                avrMonthCounter += avrMonth == 0 ? 0 : 1;
            }
            float avrMonthAverage = (float)avrMonthSum / avrMonthCounter;

            float rank1 = 0.1f;
            float rank2 = avrMonthAverage / 5;
            float rank3 = avrMonthAverage / 5 * 4;
            float rank4 = avrMonthAverage + (avrMonthMax - avrMonthAverage) / 5;
            float rank5 = avrMonthAverage + (avrMonthMax - avrMonthAverage) / 5 * 4;
            
            foreach(var item in dataCollection) {
                float avrMonth;
			    float.TryParse(item[3], out avrMonth);
                
                item.Add((avrMonth >= rank5) ? "5" : 
                    ((avrMonth >= rank4) ? "4" : 
                    ((avrMonth >= rank3) ? "3" : 
                    ((avrMonth >= rank2) ? "2" : 
                    ((avrMonth >= rank1) ? "1" : "-1")))));
            }

            return dataCollection;
        }
    }
}
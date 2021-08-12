using System;
using System.Text;
using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.Store
{
    public class Method
    {
        public bool Execute(List<CItem> items)
        {
            foreach (var item in items)
            {
                foreach (var color in item.Colors)
                {
                    foreach (var size in color.Sizes)
                    {
                        bool isSuccess = DBEntity.Method.addDateAndItem(item.Name, color.Name, size.Name, Convert.ToInt16(size.Quantity));
                        if (!isSuccess)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
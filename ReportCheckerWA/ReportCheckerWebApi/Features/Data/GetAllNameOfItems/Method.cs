using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.GetAllNameOfItems
{
    public class Method
    {
        public List<string> Execute()
        {
            var DBItems = DBEntity.Method.getAllItems();
            
            return DBItems.Select(p => p.Name).ToList();
        }
    }
}
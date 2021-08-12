using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.GetItemDetailByName
{
    public class Method
    {
        public List<List<string>> Execute(string name)
        {
            var dataCollection = new List<List<string>>();

            var DBDateAndlistItems = DBEntity.Method.getAllDateAndListItems();
            var itemFiltered = DBDateAndlistItems.Where(p => p.Item.Name == name).ToList();

            foreach (var item in itemFiltered)
            {
                var itemLine = new List<string>();
                itemLine.Add(item.Item.Name);
                itemLine.Add(item.Color.Name);
                itemLine.Add(item.Size.Name);
                itemLine.Add(item.Quantity.ToString());
                itemLine.Add(item.Day.ToString());
                itemLine.Add(item.Month.ToString());
                itemLine.Add(item.Year.ToString());

                dataCollection.Add(itemLine);
            }
            return dataCollection;
        }
    }
}
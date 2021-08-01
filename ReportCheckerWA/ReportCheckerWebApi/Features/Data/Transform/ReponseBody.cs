using System.Collections.Generic;
using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.Data.Transform
{
    public class ReponseBody
    {
        public List<CItem> Items { get; set; }

        public ReponseBody()
        {

        }
        public ReponseBody(List<CItem> items)
        {
            this.Items = items;
        }
    }
}
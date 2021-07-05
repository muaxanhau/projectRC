using ReportCheckerWebApi.Features.Commons.Classes;
using System.Collections.Generic;

namespace ReportCheckerWebApi.Features.StringData.Transform
{
    public class DataStructure
    {
        public List<CItem> Items { get; set; }

        public DataStructure()
        {
            this.Items = new List<CItem>();
        }
    }
    public class ReponseBody : CReponseBody
    {
        public DataStructure Data { get; set; }
        public ReponseBody(string status)
        {
            this.Data = new DataStructure();
            base.Status = status.ToLower();
        }
    }
}
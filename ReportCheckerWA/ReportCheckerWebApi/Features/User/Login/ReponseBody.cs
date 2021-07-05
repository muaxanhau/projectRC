using ReportCheckerWebApi.Features.Commons.Classes;

namespace ReportCheckerWebApi.Features.User.Login
{
    public class DataStructure
    {
        public string Token { get; set; }

        public DataStructure()
        {
            this.Token = "";
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
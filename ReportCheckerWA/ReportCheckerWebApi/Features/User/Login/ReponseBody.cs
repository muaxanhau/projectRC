namespace ReportCheckerWebApi.Features.User.Login
{
    public class ReponseBody
    {
        public string Token { get; set; }

        public ReponseBody(string token)
        {
            this.Token = token;
        }
    }
}
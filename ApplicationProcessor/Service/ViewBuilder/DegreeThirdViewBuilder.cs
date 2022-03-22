using System.Text;

namespace ULaw.ApplicationProcessor
{
    public class DegreeThirdViewBuilder : IViewBuilder
    {
        public string Build(Application application)
        {
            var result = new StringBuilder();
            result.Append("<html><body><h1>Your Recent Application from the University of Law</h1>");
            result.Append($"<p> Dear {application.FirstName}, </p>");
            result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
            result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}

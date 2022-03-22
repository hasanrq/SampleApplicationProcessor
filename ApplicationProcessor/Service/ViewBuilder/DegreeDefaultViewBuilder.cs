using System.Text;

namespace ULaw.ApplicationProcessor
{
    public class DegreeDefaultViewBuilder : IViewBuilder
    {
        public string Build(Application application)
        {
            var result = new StringBuilder();
            result.Append("<html><body><h1>Your Recent Application from the University of Law</h1>");
            result.Append($"<p> Dear {application.FirstName}, </p>");
            result.Append($"<p/> Further to your recent application for our course reference: {application.CourseCode} starting on {application.StartDate.ToLongDateString()}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.");
            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}

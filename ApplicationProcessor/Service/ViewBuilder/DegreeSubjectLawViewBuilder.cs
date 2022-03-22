using System.Text;

namespace ULaw.ApplicationProcessor
{
    public class DegreeSubjectLawViewBuilder : IViewBuilder
    {
        public string Build(Application application)
        {
            decimal depositAmount = 350.00M;
            var result = new StringBuilder();
            result.Append("<html><body><h1>Your Recent Application from the University of Law</h1>");
            result.Append($"<p> Dear {application.FirstName}, </p>");
            result.Append($"<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {application.CourseCode} starting on {application.StartDate.ToLongDateString()}.");
            result.Append($"<br/> This offer will be subject to evidence of your qualifying {application.DegreeSubject.ToDescription()} degree at grade: {application.DegreeGrade.ToDescription()}.");
            result.Append($"<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{depositAmount} deposit fee to secure your place.");
            result.Append("<br/> We look forward to welcoming you to the University,");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor.Tests.Unit
{
    [TestClass]
    public class ViewBuilderTests
    {
        [TestMethod]
        public void DegreeDefaultViewBuilder_ReturnsValidView()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoOne;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.maths;

            var viewBuilder = new DegreeDefaultViewBuilder();
            string emailHtml = viewBuilder.Build(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }

        [TestMethod]
        public void DegreeSubjectLawViewBuilder_ReturnsValidView()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoOne;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.law;

            var viewBuilder = new DegreeSubjectLawViewBuilder();
            string emailHtml = viewBuilder.Build(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.OfferEmailForTwoOneLawDegreeResult);
        }

        [TestMethod]
        public void DegreeThirdViewBuilder_ReturnsValidView()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.third;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.maths;

            var viewBuilder = new DegreeThirdViewBuilder();
            string emailHtml = viewBuilder.Build(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.RejectionEmailForAnyThirdDegreeResult);
        }

        [TestMethod]
        public void DegreeTwoTwoViewBuilder_ReturnsValidView()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoTwo;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.English;

            var viewBuilder = new DegreeTwoTwoViewBuilder();
            string emailHtml = viewBuilder.Build(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ULaw.ApplicationProcessor.Enums;


namespace ULaw.ApplicationProcessor.Tests
{

    [TestClass]
    public class ApplicationSubmissionTests
    {

        [TestMethod]
        public void ApplicationSubmissionWithFirstLawDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.first;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.law;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.OfferEmailForFirstLawDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithFirstLawAndBusinessDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.first;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.lawAndBusiness;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.OfferEmailForFirstLawAndBusinessDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithFirstEnglishDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.first;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.English;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneLawDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoOne;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.law;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.OfferEmailForTwoOneLawDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneMathsDegree()
        {

            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoOne;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.maths;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoOneLawAndBusinessDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoOne;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.lawAndBusiness;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.OfferEmailForTwoOneLawAndBusinessDegreeResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoTwoEnglishDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoTwo;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.English;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithTwoTwoLawDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.twoTwo;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.law;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.FurtherInfoEmailResult);
        }

        [TestMethod]
        public void ApplicationSubmissionWithThirdDegree()
        {
            Application thisSubmission = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);

            thisSubmission.DegreeGrade = DegreeGradeEnum.third;
            thisSubmission.DegreeSubject = DegreeSubjectEnum.maths;

            var factory = new ViewBuilderFactory();
            var service = new ApplicationService(factory);

            string emailHtml = service.Process(thisSubmission);
            Assert.AreEqual(emailHtml, Constants.RejectionEmailForAnyThirdDegreeResult);
        }
    }

}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ULaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor.Tests.Unit
{
    [TestClass]
    public class ViewBuilderFactoryTests
    {
        [TestMethod]
        public void ViewBuilderFactory_ReturnsValidViewBuilder()
        {
            var application = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);
            application.DegreeGrade = DegreeGradeEnum.twoTwo;
            application.DegreeSubject = DegreeSubjectEnum.English;
            var factory = new ViewBuilderFactory();

            var viewBuilder = factory.GetViewBuilder(application);

            //Assert.AreEqual(viewBuilder.GetType(), typeof(DegreeTwoTwoViewBuilder));
            Assert.IsInstanceOfType(viewBuilder, typeof(DegreeTwoTwoViewBuilder));
        }
    }
}

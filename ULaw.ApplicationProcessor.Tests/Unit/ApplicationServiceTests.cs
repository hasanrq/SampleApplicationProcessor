using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace ULaw.ApplicationProcessor.Tests.Unit
{
    [TestClass]
    public class ApplicationServiceTests
    {
        [TestMethod]
        public void ApplicationService_CallsViewBuilder()
        {
            var application = new Application("Law", "ABC123", new DateTime(2019, 9, 22), "Mr", "Test", "Tester", new DateTime(1991, 08, 14), false);
            var factory = Substitute.For<IViewBuilderFactory>();
            var viewBuilder = Substitute.For<IViewBuilder>();

            factory.GetViewBuilder(application).Returns(viewBuilder);
            var expectedResult = "view builder result";
            viewBuilder.Build(application).Returns(expectedResult);

            var service = new ApplicationService(factory);
            var result = service.Process(application);

            factory.Received(1).GetViewBuilder(application);
            viewBuilder.Received(1).Build(application);
            Assert.AreEqual(result, expectedResult);

        }
    }
}

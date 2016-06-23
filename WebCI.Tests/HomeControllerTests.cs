namespace WebCI.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Controllers;
    using Models;

    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexModelTest()
        {
            var homeController = new HomeController();
            var view = homeController.Index() as System.Web.Mvc.ViewResult;
            Assert.IsNotNull(view);
            var model = view.Model as IndexModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("foo", model.Foo);
            Assert.AreEqual("bar", model.Bar);

        }
    }
}

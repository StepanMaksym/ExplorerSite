using System;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ExplorerLviv.Controllers;
using ExplorerLviv.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExplorerLviv.Tests.Controllers
{
    [TestClass]
    public class DatabaseControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            DatabaseController controller = new DatabaseController();

            // Act
            ViewResult result = controller.Index() as ViewResult;
            DatabaseModel model = (DatabaseModel) result.Model;
            
            // Assert
            Assert.AreEqual("This is Database controller", model.Description);
            Assert.IsInstanceOfType(result.Model, typeof(DatabaseModel));
            Assert.IsInstanceOfType(result.Model, typeof(string));

        }
    }
}

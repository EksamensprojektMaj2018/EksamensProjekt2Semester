
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupportTicketSystem.Model.Catalog;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
	        //Arrange
	        TicketCatalog tc = new TicketCatalog();

			//Act
	        int noOfTickets = tc.All.Count;

			//Assert
	        Assert.AreEqual(4, noOfTickets);
        }

		[TestMethod]
	    public void TestMethod2()
	    {
		    //Arrange
			UserCatalog uc = new UserCatalog();

			//Act
		    int noOfUsers = uc.All.Count;

		    //Assert
			Assert.AreEqual(4, noOfUsers);
	    }
    }
}

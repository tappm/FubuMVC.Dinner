// -----------------------------------------------------------------------
// <copyright file="GetHandlerTests.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FubDinner.Web.Test.Handles.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using NUnit.Framework;
    using FubuDinner.Web.Handles.Home;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class GetHandlerTests
    {
        [Test]
        public void WhenCallingHomeGetViewModelsReturnWithHelloMsg()
        {
            

            var returnModel = new GetHandler().Execute();
            Assert.AreEqual("Hello Workshop", returnModel.HelloMsg);
        }

    }
}

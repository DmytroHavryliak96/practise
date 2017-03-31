using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication1;
using FluentAssert;
using Moq;


namespace ConsoleApplication.Tests
{
    [TestFixture]
    public class NotifierTests
    {
        [Test]
        public void Email_contests_should_be_ok()
        {
            var senderMock = new Mock<IEmailSender>();
            senderMock.Setup(it)
            var notifier = 
        }
    }

    [TestFixture]
    public class WarehouseTests
    {
        [Test]
        public void When_Name_Does_Not_Contain_Food_Then_Storage_should_save_item()
        {
            var warehouse = new Warehouse();

            warehouse.Add("Book");

            warehouse.Count().ShouldBeEqualTo<uint>(1); 
        }

        [Test]
        public void When_Name_Contains_Food_Then_Storage_should_throw_item()
        {
            var warehouse = new Warehouse();

            Assert.Throws<InvalidOperationException>(() => new Warehouse().Add("Food"));
        }

        [Test]
        public void When_try_to_remove_non_existent_item_should_throw()
        {
            var warehouse = new Warehouse(new string[] { "Spoon" });

            warehouse.Count().ShouldBeEqualTo<uint>(1);

            warehouse.Remove("Spoon");

            warehouse.Count().ShouldBeEqualTo<uint>(0); 

        }
    }
}

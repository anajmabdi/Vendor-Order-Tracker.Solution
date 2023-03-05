using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace VendorOrder.Tests
{

    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void
        OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            string title = "Tea Party";
            string description = "too many pastries";
            int price = 350;

            Order newOrder = new Order(title, description, price);

            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void
        SetProperties_DefinesPropertiesForObjectInstances_Order()
        {
            string title = "Tea Party";
            string description = "too many pastries";
            int price = 350;
            Order newOrder = new Order(title, description, price);

            string titleCheck = newOrder.Title;
            string descriptionCheck = newOrder.Description;
            int priceCheck = newOrder.Price;

            Assert.AreEqual(title, titleCheck);
            Assert.AreEqual(description, descriptionCheck);
            Assert.AreEqual(price, priceCheck);
        }

        [TestMethod]
        public void GetDate_AccessDateTimeClass_Order()
        {
            DateTime date = DateTime.Today;

            Order newOrder = new Order("title", "description", 5);

            DateTime result = newOrder.Today;

            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void GetAll_GetsAllOrders_Order()
        {
            Order order1 = new Order("title", "description", 5);
            Order order2 = new Order("title", "description", 5);
            List<Order> newList = new List<Order> { order1, order2 };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(result, newList);
        }

        [TestMethod]
        public void GetId_OrdersInstantiateWithId_Int()
        {
            Order order1 = new Order("title", "description", 5);

            int result = order1.Id;

            Assert.AreEqual(1, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            string test1 = "test";
            string test2 = "test";
            Vendor newVendor = new Vendor(test1, test2);
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetNameAndDescription_SavesDescriptionAndNameOfVendor_Vendor()
        {
            string name = "Suzie's Cafe";
            string description = "Coffee Shop";
            Vendor newVendor = new Vendor(name, description);

            string nameCheck = newVendor.Name;
            string descriptionCheck = newVendor.Description;

            Assert.AreEqual(name, nameCheck);
            Assert.AreEqual(description, descriptionCheck);
        }

        [TestMethod]
        public void GetAll_GetsAllVendors_Vendor()
        {
            Vendor vendor1 = new Vendor("name", "description");
            Vendor vendor2 = new Vendor("name", "description");
            List<Vendor> newList = new List<Vendor> { vendor1, vendor2 };

            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(result, newList);
        }
        [TestMethod]
        public void GetId_VendorsInstantiateWithId_Int()
        {
            Vendor vendor1 = new Vendor("name", "description");

            int result = vendor1.Id;

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_GrabsCorrectVendor_Vendor()
        {
            Vendor newVendor1 = new Vendor("name", "description");
            Vendor newVendor2 = new Vendor("name", "description");

            //Act
            Vendor result = Vendor.Find(2);

            //Assert
            Assert.AreEqual(newVendor2, result);
        }
    }
}

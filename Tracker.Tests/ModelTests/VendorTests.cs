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
            Vendor Vendor1 = new Vendor("name", "description");
            Vendor Vendor2 = new Vendor("name", "description");
            List<Vendor> newList = new List<Vendor> { Vendor1, Vendor2 };

            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(result, newList);
        }
    }
}

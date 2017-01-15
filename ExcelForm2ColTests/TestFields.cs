using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcelForm2Col;
using Ninject;

namespace ExcelForm2ColTests
{
    [TestClass]
    public class TestFields
    {
        static IKernel kernel;
        [ClassInitialize]
        public static void onStart(TestContext ctx)
        {
            kernel = Kernel.Load();
            Assert.IsNotNull(kernel);
        }

        [TestMethod]
        public void TestFieldCreation()
        {
            IField field = kernel.Get<IField>();
            Assert.IsNotNull(field);
        }

        [TestMethod]
        public void TestFieldProperties()
        {
            IField field = kernel.Get<IField>();
            Assert.IsNotNull(field);

            field.Address = "E7:E37";
            field.Name = "Ingredient";
            field.CellType = CellType.Chaine;

            Assert.AreEqual(field.Address, "E7:E37");
            Assert.AreEqual(field.Name, "Ingredient");
            Assert.AreEqual(field.CellType, CellType.Chaine);
        }

        [TestMethod]
        public void TestFieldAddress()
        {
            IField field = kernel.Get<IField>();
            Assert.IsNotNull(field);

            field.Address = "E7:E37";
            Assert.AreEqual(field.FirstColumn, 5);
            Assert.AreEqual(field.FirstRow, 7);
            Assert.AreEqual(field.SecondColumn, 5);
            Assert.AreEqual(field.SecondRow, 37);
            Assert.AreEqual(field.Depth, 37 - 7);

            field.Address = "EA7:EA37";
            Assert.AreEqual(field.FirstColumn, 131);
            Assert.AreEqual(field.FirstRow, 7);
            Assert.AreEqual(field.SecondColumn, 131);
            Assert.AreEqual(field.SecondRow, 37);
            Assert.AreEqual(field.Depth, 37 - 7);

        }

        [TestMethod]
        [ExpectedException(typeof(MalformedRangeException), "Malformed Range")]
        public void TestMalformedField()
        {
            IField field = kernel.Get<IField>();
            Assert.IsNotNull(field);

            field.Address = "A1:B10";
        }

        [TestMethod]
        [ExpectedException(typeof(MalformedRangeException), "Malformed Range")]
        public void TestMalformedRowField()
        {
            IField field = kernel.Get<IField>();
            Assert.IsNotNull(field);

            field.Address = "A10:Z10";
        }
    }
}

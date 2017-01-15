using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using ExcelForm2Col;
using Ninject.Parameters;

namespace ExcelForm2ColTests
{
    /// <summary>
    /// Description résumée pour TestEF2C
    /// </summary>
    [TestClass]
    public class TestEF2C
    {
        public TestEF2C()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        static IKernel kernel;
        [ClassInitialize]
        public static void onStart(TestContext ctx)
        {
            kernel = Kernel.Load();
            Assert.IsNotNull(kernel);
        }

        [TestMethod]
        public void TestEF2CConstructor()
        {
            IEF2C ef2c = kernel.Get<IEF2C>();
            Assert.IsNotNull(ef2c);
            Assert.IsNotNull(ef2c.Excel);
            
        }


        [TestMethod]
        [ExpectedException(typeof(MalformedRangeException), "Malformed Range")]
        public void TestFieldDepthFail()
        {
            using (var ef2c = kernel.Get<IEF2C>())
            {
                // IEF2C ef2c = kernel.Get<IEF2C>();
                Assert.IsNotNull(ef2c);
                Assert.IsNotNull(ef2c.Excel);
                ef2c.Mapping.AddSheetName("Pizza aux épinards et à la féta");
                ef2c.Mapping.Fields.Add(new Field { Address = "E7:E19", Name = "Ingredients", CellType = CellType.Chaine });
                ef2c.Mapping.Fields.Add(new Field { Address = "F7:F20", Name = "Instructions", CellType = CellType.Chaine });
               
            }

        }

        [TestMethod]
        public void TestFieldDepthOk()
        {
            using (var ef2c = kernel.Get<IEF2C>())
            {
                // IEF2C ef2c = kernel.Get<IEF2C>();
                Assert.IsNotNull(ef2c);
                Assert.IsNotNull(ef2c.Excel);
                ef2c.Mapping.AddSheetName("Pizza aux épinards et à la féta");
                ef2c.Mapping.Fields.Add(new Field { Address = "E7:E20", Name = "Ingredients", CellType = CellType.Chaine });
                ef2c.Mapping.Fields.Add(new Field { Address = "F7:F20", Name = "Instructions", CellType = CellType.Chaine });

            }

        }

        [TestMethod]
        public void TestWorksheetEnumeration()
        {
            using (var ef2c = kernel.Get<IEF2C>())
            {
                // IEF2C ef2c = kernel.Get<IEF2C>();
                Assert.IsNotNull(ef2c);
                Assert.IsNotNull(ef2c.Excel);
                ef2c.Mapping.AddSheetName("Pizza aux épinards et à la féta");
                ef2c.Mapping.AddSheetName("Recette vide 1");
                ef2c.Mapping.Fields.Add(new Field { Address = "E7:E19", Name = "Ingredients", CellType = CellType.Chaine });
                ef2c.Mapping.Fields.Add(new Field { Address = "F7:F19", Name = "Instructions", CellType = CellType.Chaine });
                //ef2c.SourceType = SourceType.File;
                ef2c.SourceType = SourceType.Directory;
                ef2c.Source = @"C:\Users\jc\Desktop\recettes";

                ef2c.Start();

              //  Assert.IsTrue(ef2c.Columns.ByName("Ingredients").Count == 26);

                var destination = kernel.Get<IDestination>(new ConstructorArgument("filename", @"C:\Users\jc\Desktop\newfile.xlsx"), new ConstructorArgument("sheetname", "newSheet"), new ConstructorArgument("addToExistingFile", false), new ConstructorArgument("addToExistingSheet", false));
                Assert.IsNotNull(destination);

                destination.Save(ef2c.Columns);
            }
           
        }
    }
}

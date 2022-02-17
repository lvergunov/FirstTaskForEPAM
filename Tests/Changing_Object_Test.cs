using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstTaskForEPAM;

namespace Tests
{
    /// <summary>
    /// A class that tests the process of moving paintings from storage to the hall and back
    /// </summary>
    [TestClass]
    public class Changing_Object_Test
    {
        /// <summary>
        /// A method that tests the process of moving paintings from storage to the hall and back
        /// </summary>
        [TestMethod]
        public void Changing_Object_Test1()
        {
            List<Painting> testList = TestObjectsCreator();
            PaintingStorage.PutUpPainting(testList[1],1,3);
            Assert.IsTrue(PaintingStorage.paintings[PaintingStorage.paintings.Count-1] is PaintingInExhibitionHall);
            PaintingStorage.HidePainting(testList[2]);
            Assert.IsTrue(PaintingStorage.paintings[PaintingStorage.paintings.Count - 1] is PaintingInStoreroom);
        }
        /// <summary>
        /// A test that checks if an object stores information about its past exhibitions
        /// </summary>
        [TestMethod]
        public void Storing_Information_Test1()
        {
            TestObjectsCreator();
            Painting pt3 = Searcher.FindPaintingByName("Unknown")[0];
            PaintingStorage.HidePainting(pt3);
            Painting pt3_1 = Searcher.FindPaintingByName("Unknown")[0];
            PaintingStorage.PutUpPainting(pt3_1, 1, 5);
            pt3_1 = Searcher.FindPaintingByName("Unknown")[0];
            pt3_1 = PaintingStorage.paintings[InformationCollector.FindIndexOfObject(pt3_1)];
            Assert.AreEqual(2022, pt3_1.exhibitions[0].DateOfEnding.Year);
            if (pt3_1 is PaintingInExhibitionHall ph)
                Assert.AreEqual(2022, ph.ExhibitionBeginning.DateOfBeginning.Year);
            PaintingStorage.HidePainting(pt3_1);
            Assert.AreEqual(2, PaintingStorage.paintings[PaintingStorage.paintings.Count - 1].exhibitions.Count);
        }
        /// <summary>
        /// Method to clean up static classes after test
        /// </summary>
        [TestCleanup]
        public void CleanStorage()
        {
            PaintingStorage.paintings.Clear();
            ExhibitionHallStorage.halls.Clear();
        }
        /// <summary>
        /// Method that creates a list of objects for the test
        /// </summary>
        /// <returns>List of objects for the test</returns>
        private static List<Painting> TestObjectsCreator()
        {
            IExhibitionHall exhibitionHallOne = new ExhibitionHall(1);
            PaintingInStoreroom pt1 = new PaintingInStoreroom("Mona Lisa", "Da Vinci", "Portrait", "humanism", 1505);
            PaintingInStoreroom pt2 = new PaintingInStoreroom("Starlight Night", "Van Gogh", "Landscape", "Modernism", 1889);
            PaintingInExhibitionHall pt3 = new PaintingInExhibitionHall("Unknown", "Kramskoy", "Portrait", "Realism", 1883, exhibitionHallOne, 1);
            PaintingInExhibitionHall pt4 = new PaintingInExhibitionHall("The Last Supper", "Da Vinci", "Historical", "Humanism", 1498, exhibitionHallOne, 2);
            List<Painting> tempPainting = new List<Painting>();
            tempPainting.AddRange(new Painting[] {pt1,pt2,pt3,pt4 });
            return tempPainting;
        }
    }
}
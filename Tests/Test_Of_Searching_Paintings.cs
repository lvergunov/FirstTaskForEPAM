using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstTaskForEPAM;

namespace Tests
{
    /// <summary>
    /// Class to test search for specific pictures
    /// </summary>
    [TestClass]
    public class Test_Of_Searching_Paintings
    {
        /// <summary>
        /// Test for displaying pictures in a specific hall
        /// </summary>
        [TestMethod]
        public void Test_Of_Searching_1()
        {
            IExhibitionHall hall1 = new ExhibitionHall(1);
            IExhibitionHall hall2 = new ExhibitionHall(2);
            IExhibitionHall hall3 = new ExhibitionHall(3);
            PaintingInStoreroom pt1 = new PaintingInStoreroom("Unknown", "Kramskoy", "Portrait", "Realism", 1883);
            PaintingInExhibitionHall pt2 = new PaintingInExhibitionHall("Mona Lisa", "Da Vinci", "Portrait", "Humanism", 1505, hall1, 1);
            PaintingInExhibitionHall pt3 = new PaintingInExhibitionHall("Starlight Night", "Van Gogh", "Landscape", "Modernism", 1889, hall1, 2);
            PaintingInExhibitionHall pt4 = new PaintingInExhibitionHall("The Last Supper", "Da Vinci", "Historical", "Humanism", 1498, hall2, 1);
            PaintingInStoreroom pt5 = new PaintingInStoreroom("Clock", "Dali", "Allegory", "Surrealism", 1931);
            PaintingInExhibitionHall pt6 = new PaintingInExhibitionHall("Dream", "Dali", "Allegory", "Surrealism", 1937, hall1, 3);
            PaintingInStoreroom pt7 = new PaintingInStoreroom("Gernica", "Picasso", "Abstraction", "Surrealism", 1936);
            List<Painting> testList = new List<Painting>(3);
            testList.AddRange(new Painting[] { pt2, pt3, pt6 });
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(testList[i], InformationCollector.GetPaintingsByTheirHall(1)[i]);
            }
        }
        /// <summary>
        /// Test to search for a picture by author
        /// </summary>
        [TestMethod]
        public void Test_Of_Searching_2()
        {
            List<Painting> testList = new List<Painting>(2);
            testList.AddRange(new Painting[] { PaintingStorage.paintings[1], PaintingStorage.paintings[3] });
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(testList[i], Searcher.FindPaintingByAuthor("da vinci")[i]);
            }
        }
        /// <summary>
        /// Test for finding a picture by its name
        /// </summary>
        [TestMethod]
        public void Test_Of_Searching_3()
        {
            Assert.AreEqual(PaintingStorage.paintings[0], Searcher.FindPaintingByName("unknown")[0]);
        }
        /// <summary>
        /// Test to find similar paintings
        /// </summary>
        [TestMethod]
        public void Test_Of_Searching_4()
        {
            List<Painting> testList = new List<Painting>(2);
            List<Painting> expected = Searcher.FindSimilar(PaintingStorage.paintings[5]);
            testList.AddRange(new Painting[] { PaintingStorage.paintings[4], PaintingStorage.paintings[6] });
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(testList[i], expected[i]);
            }
            testList.Clear();
            Painting testPt = PaintingStorage.paintings[1];
            expected = Searcher.FindSimilar(PaintingStorage.paintings[3]);
            Assert.AreEqual(1, expected.Count);
            Assert.AreEqual(testPt, expected[0]);
        }
        /// <summary>
        /// Test of the mechanics of the adding technique of painting execution
        /// </summary>
        [TestMethod]
        public void Test_Of_Searching_5()
        {
            IPainingTechniques technique = new PainingTechniques();
            IPaintingWithHerTechiques paintingWithTech = new PaintingWithHerTechiques(PaintingStorage.paintings[0],technique);
            PaintingTechniquesStorage.techniquesStorage[0].HerTechniques.AddTechniques("Tech1","Tech2");
            Assert.AreEqual("Tech1", PaintingTechniquesStorage.techniquesStorage[0].HerTechniques.Techniques[0]);
            Assert.AreEqual("Too lot of params", PaintingTechniquesStorage.techniquesStorage[0].HerTechniques.AddTechniques("Tech3","Tech4"));
        }
    }
}

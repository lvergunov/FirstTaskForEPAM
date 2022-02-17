using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Class which stores all instances of painting
    /// </summary>
    public static class PaintingStorage
    {
        /// <summary>
        /// List which stores all instances of painting
        /// </summary>
        public static List<Painting> paintings = new List<Painting>();
        /// <summary>
        /// Method that moves a painting from the store to the hall
        /// </summary>
        /// <param name="painting">Instance of painting</param>
        /// <param name="numberOfHall">Number of hall where painting must be placed</param>
        /// <param name="position">Number of position where painting must be placed</param>
        /// <returns>A line indicating whether the painting has been moved or not and why</returns>
        public static string PutUpPainting(Painting painting, ushort numberOfHall, ushort position)
        {
            if (InformationCollector.DoesHallExists(numberOfHall))
            {
                IExhibitionHall exhibitionHall = InformationCollector.GetExhibitionHallObject(numberOfHall);
                if (paintings.Contains(painting)&& painting is PaintingInStoreroom pt)
                {
                    try
                    {
                        return ChangeTypeOfObject(pt, exhibitionHall, position);
                    }
                    catch(Exception ex)
                    {
                        return ex.Message;
                    }
                }
                else return "The specified picture is not in the database";
            }
            else return "The hall with the specified number is not in the database";
        }
        /// <summary>
        /// Method that moves a painting from the hall to the store
        /// </summary>
        /// <param name="painting">An instance of painting which must be replaced</param>
        /// <returns></returns>
        public static string HidePainting(Painting painting) {
            if (painting is PaintingInExhibitionHall pt)
                return ChangeTypeOfObject(pt);
            else return "Error";
        }
        /// <summary>
        /// Method that turn type PaintingInExhibitionHall to PaintingInStoreroom
        /// </summary>
        /// <param name="painting">An instance</param>
        /// <returns>Was object turned or not</returns>
        private static string ChangeTypeOfObject(PaintingInExhibitionHall painting)
        {
            int i = 0;
            while (paintings[i] != painting) i++;
            paintings.RemoveAt(i);
            painting.AddHistoryOfExhibition(painting.ExhibitionBeginning.DateOfBeginning, DateTime.Today);
            PaintingInStoreroom tempPainting =  new PaintingInStoreroom(painting);
            paintings.Add(tempPainting);
            return "Painting is handed to a storeroom";
        }
        /// <summary>
        /// Method that turn type PaintingInStoreroom to PaintingInExhibitionHall 
        /// </summary>
        /// <param name="painting">An instance of painting</param>
        /// <param name="exhibitionHall">An instance of hall</param>
        /// <param name="position">Postion in the hall</param>
        /// <returns></returns>
        private static string ChangeTypeOfObject(PaintingInStoreroom painting, IExhibitionHall exhibitionHall, ushort position)
        {
            int i = 0;
            while (paintings[i] != painting) i++;
            paintings.RemoveAt(i);
            PaintingInExhibitionHall tempPainting = new PaintingInExhibitionHall(painting,exhibitionHall,position);
            paintings.Add(tempPainting);
            DateTime day = DateTime.Today;
            return $"Painting is placed in hall number {exhibitionHall.NumberOfHall} on position {position}";
        }
    }
}

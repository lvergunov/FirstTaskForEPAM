using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    public class PaintingsComparer : IComparer<Painting>
    {
        public int Compare(Painting? p1,Painting? p2)
        {
            if(p1 != null &&p2 != null)
            {
                int stepOfEqualitiy = 0;
                if (p1.NameOfPainting == p2.NameOfPainting)
                    stepOfEqualitiy++;
                if (p1.NameOfAuthor == p2.NameOfAuthor)
                    stepOfEqualitiy++;
                if (p1.Genre == p2.Genre)
                    stepOfEqualitiy++;
                if (p1.Direction == p2.Direction)
                    stepOfEqualitiy++;
                if (p1.YearOfCreation == p2.YearOfCreation)
                    stepOfEqualitiy++;
                return stepOfEqualitiy;
            }
            else throw new ArgumentException("Invalid params");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// A class that adds additional functionality to the main class "picture" without changing it
    /// </summary>
    public abstract class PaintingExtensionForPaintingInHall : PaintingInExhibitionHall
    {
        /// <summary>
        /// Property that contains and returns list of techniques which were used 
        /// </summary>
        public List<string> PaintingTechniques { get; private set; }
        public PaintingExtensionForPaintingInHall(PaintingInExhibitionHall pt, IExhibitionHall eh, ushort pos) : base(pt, eh, pos) { }
        /// <summary>
        /// Method that adds 2-3 techniques to current object of painting
        /// </summary>
        /// <param name="techniques">String params of techniques</param>
        /// <returns></returns>
        public string TryAddTechnique(params string[] techniques)
        {
            if (this.PaintingTechniques.Count + techniques.Length < 4&&this.PaintingTechniques.Count+techniques.Length>1)
            {
                this.PaintingTechniques.AddRange(techniques);
                return "Added successfully";
            }
            else if (this.PaintingTechniques.Count + techniques.Length>3)
                return "Too much params";
            else return "Too few params";
        }
    }
}

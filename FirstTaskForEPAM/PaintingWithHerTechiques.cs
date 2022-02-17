using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskForEPAM
{
    /// <summary>
    /// Interface representing a class-link of a painting and its techniques
    /// </summary>
    public class PaintingWithHerTechiques : IPaintingWithHerTechiques
    {
        /// <summary>
        /// A property that returns the picture to which the techniques belong
        /// </summary>
        public Painting CurrentPainting { get; }
        /// <summary>
        /// Property returning a list of performance techniques
        /// </summary>
        public IPainingTechniques HerTechniques { get; }
        /// <summary>
        /// Binding class constructor
        /// </summary>
        /// <param name="ptng">Instance of painting</param>
        /// <param name="techniques">List of paintings</param>
        public PaintingWithHerTechiques(Painting ptng, IPainingTechniques techniques)
        {
            CurrentPainting = ptng;
            HerTechniques = techniques;
            PaintingTechniquesStorage.techniquesStorage.Add(this);
        }
    }
}

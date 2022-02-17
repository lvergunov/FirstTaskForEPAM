namespace FirstTaskForEPAM
{
    /// <summary>
    /// Interface representing a class-link of a painting and its techniques
    /// </summary>
    public interface IPaintingWithHerTechiques
    {
        /// <summary>
        /// A property that returns the picture to which the techniques belong
        /// </summary>
        Painting CurrentPainting { get; }
        /// <summary>
        /// Property returning a list of performance techniques
        /// </summary>
        IPainingTechniques HerTechniques { get; }
    }
}
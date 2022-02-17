
namespace FirstTaskForEPAM
{
    /// <summary>
    /// An interface representing list execution technique
    /// </summary>
    public interface IPainingTechniques
    {
        /// <summary>
        /// Property returning a list of performance techniques
        /// </summary>
        List<string> Techniques { get; }
        /// <summary>
        /// A method that adds several performance techniques
        /// </summary>
        /// <param name="techniques">List of params</param>
        /// <returns>Was added or not</returns>
        string AddTechniques(params string[] techniques);
    }
}
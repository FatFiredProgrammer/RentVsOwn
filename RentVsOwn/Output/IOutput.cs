namespace RentVsOwn.Output
{
    /// <summary>
    ///     Interface defining our output method.
    /// </summary>
    public interface IOutput
    {
        void Flush();

        /// <summary>
        ///     Informative text
        /// </summary>
        /// <param name="text">The text.</param>
        string VerboseLine(string text);

        /// <summary>
        ///     The succinct text which describes the basics of the simulation.
        /// </summary>
        /// <param name="text">The text.</param>
        string WriteLine(string text);
    }
}

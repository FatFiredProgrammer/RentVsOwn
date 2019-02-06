using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace RentVsOwn.Output
{
    /// <summary>
    ///     Output to verbose console/debug.
    ///     Our standard output method.
    /// </summary>
    [PublicAPI]
    public sealed class VerboseOutput : IOutput
    {
        /// <inheritdoc />
        public void Flush()
        {
        }

        /// <inheritdoc />
        public string VerboseLine(string text)
        {
            text = text ?? string.Empty;
            Console.WriteLine(text);
            Debug.WriteLine(text);
            return text;
        }

        /// <inheritdoc />
        public string WriteLine(string text)
        {
            text = text ?? string.Empty;
            Console.WriteLine(text);
            Debug.WriteLine(text);
            return text;
        }
    }
}

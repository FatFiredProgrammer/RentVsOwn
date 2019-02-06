using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace RentVsOwn.Output
{
    /// <summary>
    ///     Output to console/debug.
    ///     Our standard output method.
    /// </summary>
    [PublicAPI]
    public sealed class ConsoleOutput : IOutput
    {
        /// <inheritdoc />
        public void Flush()
        {
        }

        /// <inheritdoc />
        public string VerboseLine(string text)
            => text ?? string.Empty;

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

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using JetBrains.Annotations;

namespace RentVsOwn.Output
{
    /// <summary>
    ///     Output to console/debug.
    ///     Our standard output method.
    /// </summary>
    [PublicAPI]
    public sealed class TempFileOutput : IOutput
    {
        private StringBuilder _text = new StringBuilder();

        /// <inheritdoc />
        public void Flush()
        {
            try
            {
                var fileName = Path.GetTempFileName() + ".txt";
                File.WriteAllText(fileName, _text.ToString());
                Debug.WriteLine($"Data written to {fileName}");
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }

            _text = new StringBuilder();
        }

        /// <inheritdoc />
        public string VerboseLine(string text)
        {
            text = text ?? string.Empty;
            _text.AppendLine(text);
            Debug.WriteLine(text);
            return text;
        }

        /// <inheritdoc />
        public string WriteLine(string text)
        {
            text = text ?? string.Empty;
            _text.AppendLine(text);
            Console.WriteLine(text);
            Debug.WriteLine(text);
            return text;
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleOutput.cs" company="Weston McNamee">
//   Written by Weston McNamee.
//   Wes@WesHacks.net
// </copyright>
// <summary>
//   The console output.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kakuro.Console.Test
{
    using System;
    using System.IO;

    /// <summary>
    /// The console output.
    /// </summary>
    public class ConsoleOutput : IDisposable
    {
        #region Fields

        /// <summary>
        /// The original output.
        /// </summary>
        private readonly TextWriter originalOutput;

        /// <summary>
        /// The string writer.
        /// </summary>
        private readonly StringWriter stringWriter;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleOutput"/> class.
        /// </summary>
        public ConsoleOutput()
        {
            this.stringWriter = new StringWriter();
            this.originalOutput = Console.Out;
            Console.SetOut(this.stringWriter);
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            Console.SetOut(this.originalOutput);
            this.stringWriter.Dispose();
        }

        /// <summary>
        /// The get output.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetOutput()
        {
            return this.stringWriter.ToString();
        }

        #endregion
    }
}
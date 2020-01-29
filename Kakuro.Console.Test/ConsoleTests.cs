using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kakuro.Console.Test
{
    using System.Linq;

    [TestClass]
    public class ConsoleTests
    {
        [TestMethod]
        public void GivenSumTwoComboPossibilities_ExpectTwoOutputLines()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                Kakuro.Console.Program.Main(new string[] { "-s", "5" });

                var consoleOutputString = consoleOutput.GetOutput();
                var consoleLines = consoleOutputString.Split(
                    new string[] { Environment.NewLine },
                    StringSplitOptions.None);

                Assert.AreEqual(2, consoleLines.Count());
                Assert.AreEqual(" 4  1", consoleLines[0]);
                Assert.AreEqual(" 3  2", consoleLines[1]);
            }
        }
    }
}

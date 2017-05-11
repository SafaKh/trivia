using System;
using System.IO;
using NUnit.Framework;

namespace Trivia.Tests
{
    class QuestionsShould
    {
        [Test]
        public void AllowToPlayWith5Category()
        {
            var stringWriter = new StringWriter();
            var previousConsoleOut = Console.Out;
            Console.SetOut(stringWriter);
            var questions=new Questions(); 
            questions.AskQuestion(4);
            Console.SetOut(previousConsoleOut);
            Assert.That(stringWriter.ToString().Contains("Cinema"));
        }
    }
}

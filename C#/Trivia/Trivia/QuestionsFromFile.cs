using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class QuestionsFromFile : IQuestionsRepository
    {
        public LinkedList<string> GetQuestions(string category)
        {
            var questions = new LinkedList<String>();
            using (var filestream = File.OpenRead(""))
            //StreamReader permet de lire ligne par ligne le fichier .txt
            using (var streamReader = new StreamReader(filestream))
            {
                while (streamReader.EndOfStream)
                {
                    questions.AddLast(streamReader.ReadLine());
                }
            }
            return questions; 


        }

    }
}

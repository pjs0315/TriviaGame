using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
              //The logic for your trivia game happens here
            List<Trivia> AllQuestions = GetTriviaList();
        }
 
 
        /// <summary>
        /// This function gets the full list of trivia questions from the Trivia.txt document
        /// </summary>
        /// <returns>A list of Trivia objects</returns>
        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();
 
            //Each string in the list "contents" is now one line of the Trivia.txt document.
            //make a new list to return all trivia questions
            List<Trivia> returnList = new List<Trivia>();
 
            //Create a for each loop that loops through all the triva questions and creates an object
            //Example: Trivia newTrivia = new Trivia("what is my name?*question");
            foreach (string temp in contents)
            {
                Trivia newTriva = new Trivia(temp);
                returnList.Add(newTriva);
            }
 
            //Return the full list of trivia questions
            return returnList;
        }
    }
 
    class Trivia
    {
        //TODO: Fill out the Trivia Object
 
        //The Trivia Object's two properties (Question and Answer)
        String m_question;
        String m_answer;
 
        //The Constructor for the Trivia object will
        // accept only 1 string parameter.  You will
        // split the question from the answer in your
        // constructor and assign them to the Question
        // and Answer properties
 
        public Trivia(String inputString)
        {
            String[] temp = inputString.Split('*');
            m_question = temp[0];
            m_answer = temp[1];
        }
 
 
    }
}

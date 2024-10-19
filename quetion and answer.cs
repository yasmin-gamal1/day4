using System;
using System.Collections.Generic;

namespace ExamSystem
{
    
    public class Question
    {
        public string QuestionBody { get; set; }
        public int Mark { get; set; }
        public List<string> Tags { get; set; } 
       
        public Question()
        {
            QuestionBody = "Default Question";
            Mark = 1;
            Tags = new List<string> { "General" };
        }

        
        public Question(string questionBody, int mark, List<string> tags = null)
        {
            QuestionBody = questionBody;
            Mark = mark;
            Tags = tags ?? new List<string>();
        }

        
        public Question(Question question)
        {
            QuestionBody = question.QuestionBody;
            Mark = question.Mark;
            Tags = new List<string>(question.Tags); 
        }

        
        public override string ToString()
        {
            string tagsString = Tags.Count > 0 ? $"Tags: {string.Join(", ", Tags)}" : "No Tags";
            return $"Question: {QuestionBody}, Mark: {Mark}, {tagsString}";
        }
    }

  
    public class Answer
    {
        public int Num { get; set; }
        public string ChoiceText { get; set; }
        public bool IsCorrect { get; set; }

    
        public Answer()
        {
            Num = 1;
            ChoiceText = "Default Answer";
            IsCorrect = false;
        }

     
        public Answer(int num, string choiceText, bool isCorrect = false)
        {
            Num = num;
            ChoiceText = choiceText;
            IsCorrect = isCorrect;
        }

      
        public Answer(Answer answer)
        {
            Num = answer.Num;
            ChoiceText = answer.ChoiceText;
            IsCorrect = answer.IsCorrect;
        }

       
        public override string ToString()
        {
            string correctMark = IsCorrect ? "(Correct)" : "(Incorrect)";
            return $"Answer {Num}: {ChoiceText} {correctMark}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Question defaultQuestion = new Question();
            Console.WriteLine("Default Question:");
            Console.WriteLine(defaultQuestion);

            Question paramQuestion = new Question("What is Encapsulation?", 5, new List<string> { "OOP", "Concepts" });
            Console.WriteLine("\nParameterized Question:");
            Console.WriteLine(paramQuestion);

        
            Question copiedQuestion = new Question(paramQuestion);
            Console.WriteLine("\nCopied Question:");
            Console.WriteLine(copiedQuestion);

        
            List<Question> questions = new List<Question>
            {
                new Question("What is OOP?", 5, new List<string> { "Programming", "OOP" }),
                new Question("Explain Polymorphism.", 4, new List<string> { "OOP", "Concepts" }),
                new Question("What is Abstraction?", 4, new List<string> { "OOP" })
            };

         
            Console.WriteLine("\nList of Questions:");
            foreach (var question in questions)
            {
                Console.WriteLine(question);
            }

          
            Answer defaultAnswer = new Answer();
            Console.WriteLine("\nDefault Answer:");
            Console.WriteLine(defaultAnswer);

           
            Answer paramAnswer = new Answer(1, "Object-Oriented Programming", true);
            Console.WriteLine("\nParameterized Answer:");
            Console.WriteLine(paramAnswer);

         
            Answer copiedAnswer = new Answer(paramAnswer);
            Console.WriteLine("\nCopied Answer:");
            Console.WriteLine(copiedAnswer);

          
            Dictionary<Question, List<Answer>> exam = new Dictionary<Question, List<Answer>>();

            
            exam.Add(questions[0], new List<Answer>
            {
                new Answer(1, "Object-Oriented Programming", true),
                new Answer(2, "Functional Programming", false),
                new Answer(3, "Structured Programming", false)
            });

            exam.Add(questions[1], new List<Answer>
            {
                new Answer(1, "Ability to take many forms", true),
                new Answer(2, "Ability to override methods", true),
                new Answer(3, "Only specific to Java", false)
            });

            exam.Add(questions[2], new List<Answer>
            {
                new Answer(1, "Hiding implementation details", true),
                new Answer(2, "Making all variables public", false),
                new Answer(3, "None of the above", false)
            });

          
            Console.WriteLine("\nExam with Questions and Answers:");
            foreach (var entry in exam)
            {
                Console.WriteLine(entry.Key);  
                foreach (var answer in entry.Value)  
                {
                    Console.WriteLine($"  {answer}");
                }
            }
        }
    }
}

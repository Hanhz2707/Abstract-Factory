using static DesignPatterns.MathExam;

namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        public static Printer instance;
        public Printer() { }
        public static Printer GetInstance()
        {
            if (instance == null)
            {
                instance = new Printer();
            }
            return instance;
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
            // Output: print out the string message 
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public interface Exam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
    public class MathExam : Exam
    {
        public void Conduct()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Conducting Math Exam");
            // Output: "Conducting Math Exam", should use Printer class to print the message
        }

        public void Evaluate()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Evaluating Math Exam");
            // Output: "Evaluating Math Exam", should use Printer class to print the message
        }

        public void PublishResults()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Publishing Math Exam Results");
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
        }

        public interface ExamFactory
        {
            Exam CreateExam();
        }

        // Create a concrete MathExamFactory class
        public class MathExamFactory : ExamFactory
        {
            public Exam CreateExam()
            {
                return new MathExam();
            }
        }
        // Create a concrete ScienceExamFactory class
        public class ScienceExamFactory : ExamFactory
        {
            public Exam CreateExam()
            {
                return new ScienceExam();
            }
        }

        // Create a concrete ProgrammingExamFactory class
        public class ProgrammingExamFactory : ExamFactory
        {
            public Exam CreateExam()
            {
                return new ProgrammingExam();
            }
        }

    }

    // TODO#5: Add new ScienceExam class
    public class ScienceExam : Exam
    {
        public void Conduct()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Conducting Science Exam");

        }

        public void Evaluate()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Evaluating Science Exam");

        }

        public void PublishResults()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Publishing Science Exam Results");

        }
    }

    // TODO#6: Add another ProgrammingExam class

    public class ProgrammingExam : Exam
    {
        public void Conduct()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Conducting Programming Exam");

        }

        public void Evaluate()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Evaluating Programming Exam");

        }

        public void PublishResults()
        {
            Printer printing = Printer.GetInstance();
            printing.Print("Publishing Programming Exam Results");


        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.GetInstance();

            // TODO#8: Test that the created Printer works, by calling the Print method
            printer.Print("Testing Printer using Singleton pattern");


            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance
            Printer printer2 = Printer.GetInstance();
            bool Comparing = (printer == printer2);
            Console.WriteLine("Is printer the same with printer2?:" + Comparing);
            
            Console.WriteLine();

            // TODO#10: Use Abstract Factory to create different types of exams.
            ExamFactory mathExamFactory = new MathExamFactory();
            Exam mathExam = mathExamFactory.CreateExam();
            mathExam.Conduct();
            mathExam.Evaluate();
            mathExam.PublishResults();

            Console.WriteLine();

            ExamFactory scienceExamFactory = new ScienceExamFactory();
            Exam scienceExam = scienceExamFactory.CreateExam();
            scienceExam.Conduct();
            scienceExam.Evaluate();
            scienceExam.PublishResults();

            Console.WriteLine();

            ExamFactory programmingExamFactory = new ProgrammingExamFactory();
            Exam programmingExam = programmingExamFactory.CreateExam();
            programmingExam.Conduct();
            programmingExam.Evaluate();
            programmingExam.PublishResults();

        }
    }

}

using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    private int grade = 0;

    public Student(string firstName, string lastName, int identification, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
        testScores = scores;
    }

    public string Calculate()
    {
        for (int i = 0; i < testScores.Length; i++)
        {
            grade += testScores[i];
        }

        if (grade / testScores.Length <= 100 && grade / testScores.Length >= 90)
            return "O";
        else if (grade / testScores.Length < 90 && grade / testScores.Length >= 80)
            return "E";
        else if (grade / testScores.Length < 80 && grade / testScores.Length >= 70)
            return "A";
        else if (grade / testScores.Length < 70 && grade / testScores.Length >= 55)
            return "P";
        else if (grade / testScores.Length < 55 && grade / testScores.Length >= 40)
            return "D";
        else
            return "T";
    }
    class Solution
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}


using CompositePattern.DecisionTree;

namespace CompositePattern;

class Program
{
    static void Main(string[] args)
    {
        // TreeTest();

        FormTest();

    }

    private static void TreeTest()
    {
        Group root = new Group("root");
        root.Add(new Shape("S3"));

        Group groupA = new Group("A");
        root.Add(groupA);

        Group groupB = new Group("B");
        groupA.Add(groupB);

        //Group groupC = new Group("C");
        //groupC.Add(new Shape("S1"));
        //groupC.Add(new Shape("S2"));

        //root.Add(groupA);
        //root.Add(groupB);

        //   groupB.Add(groupC);


        root.Render();
    }

    private static void FormTest()
    {
        //Node component = new Question("Are you developer?",
        //    new Question("Do you know C#?",
        //        new Decision("Welcome on Design Pattern in C# Course!"),
        //        new Decision("The Course is not for you."
        //        ),
        //    new Decision("Have a nice day.")));

        Node q1 = new Question("Do you know C#?",
            new Decision("Welcome on Design Pattern in C# Course!"),
            new Decision("The Course is not for you."));

        Node d2 = new Decision("Have a nice day.");

        Node component = new Question("Are you developer?",
                q1,
                d2);

        component.Operation();

    }
    

    public static bool Response => Console.ReadKey().Key == ConsoleKey.Y;

}

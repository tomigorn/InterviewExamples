namespace InterviewExamples;

public class DelegateClosureTrap
{
    public static void Run()
    {
        Action[] actions = new Action[3];

        for (int i = 0; i < 3; i++)
        {
            // int j = i;
            actions[i] = () => Console.WriteLine(i);
        }

        foreach (var action in actions)
        {
            action();
        }
    }
}

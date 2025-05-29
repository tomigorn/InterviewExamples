namespace InterviewExamples;

public class EventsDelegatesAndMutableStates
{
    public static void Run()
    {

        var publisher = new Publisher();

        var subscribers = new List<Subscriber>();
        for (int i = 0; i < 3; i++)
        {
            var sub = new Subscriber($"Sub{i}");
            sub.Subscribe(publisher);
            subscribers.Add(sub);
        }

        for (int i = 0; i < 3; i++)
        {
            publisher.Send($"Hello {i}");
        }

        Console.WriteLine("Summary:");

        foreach (var sub in subscribers)
        {
            Console.WriteLine($"{sub.Name} got {sub.ReceivedMessages.Count} messages.");
        }
    }
}

class Publisher
{
    public event Action<string> OnMessage;

    public void Send(string msg)
    {
        OnMessage?.Invoke(msg);
    }
}

class Subscriber
{
    public string Name { get; }
    public List<string> ReceivedMessages { get; } = new();

    public Subscriber(string name)
    {
        Name = name;
    }

    public void Subscribe(Publisher pub)
    {
        pub.OnMessage += (msg) =>
        {
            Console.WriteLine($"{Name} received: {msg}");
            ReceivedMessages.Add(msg);
        };
    }
}

using System;

namespace ConsoleApp1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      QueueHelper.SendMessage("test", "message1");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message2");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message3");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message4");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message5");
    }
  }
}

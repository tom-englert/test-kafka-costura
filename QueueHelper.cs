﻿using System;
using System.IO;
using System.Linq;
using System.Net;
using Confluent.Kafka;

 namespace ConsoleApp1
{
  public static class QueueHelper
  {
    private const string QueueAddressesList = "kafka:9200";

    public static void SendMessage(string topic, string message)
    {
      LoadNativeKafkaLib();
      var producer = new ProducerBuilder<Null, string>(new ProducerConfig
      {
        ClientId = Dns.GetHostName(),
        BootstrapServers = QueueAddressesList
      }).Build();
      producer.Produce(topic, new Message<Null, string> {Value = message});
    }

    private static void LoadNativeKafkaLib()
    {
      //var tmpDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "Costura"));
      //var costuraPath = Path.Combine(tmpDirectory
      //  .GetDirectories().First().FullName, Environment.Is64BitProcess ? "64" : "32");
      //Library.Load(Path.Combine(costuraPath, "librdkafka.dll"));
      Library.Load("librdkafka.dll");
    }
  }
}

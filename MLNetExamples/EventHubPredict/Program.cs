﻿using Microsoft.Azure.EventHubs;
using System;

namespace EventHubPredict
{
    class Program
    {
        private static EventHubClient client;
        private const string EventHubConnectionString = "{Event Hubs connection string}";
        private const string EventHubName = "{Event Hub path/name}";

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}

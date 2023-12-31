﻿using AutoImplemented_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            Publisher publisher = new Publisher();

            publisher.MyEvent += subscriber.Add;

            publisher.RaiseEvent(10, 20);

            Console.ReadKey();
        }
    }
}

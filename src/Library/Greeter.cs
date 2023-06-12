using System;

namespace Library
{
    public class Greeter
    {
        private Greeter()
        {
            // Intentionally left blank
        }

        private static Greeter instance;

        public static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

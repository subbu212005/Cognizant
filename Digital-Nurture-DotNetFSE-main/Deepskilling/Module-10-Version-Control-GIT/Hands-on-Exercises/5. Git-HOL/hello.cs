using System;

namespace GitLab
{
    public class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from master branch!");
            Console.WriteLine("This is the master branch version.");
            Greet();
        }

        public static void Greet()
        {
            Console.WriteLine("Hello from GitWork branch!");
            Console.WriteLine("Updating content for step 3.");
        }
    }
}

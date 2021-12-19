using HelloWorld.Library;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            IContentProvider provider = new ContentProvider();
            Console.WriteLine(provider.GetContent());
        }
    }
}

using System;

namespace HelloWorld.Library
{
    public class ContentProvider : IContentProvider
    {
        public string GetContent()
        {
            return "Hello World from " + Environment.MachineName;
        }
    }
}

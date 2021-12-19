using System;

namespace HelloWorld.Library
{
    public class ContentProvider : IContentProvider
    {
        public string GetContent()
        {
            return string.Empty; // "Hello World!";
        }
    }
}

using HelloWorld.Library;
using Moq;
using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class ContentProviderTest
    {
        ContentProvider sut;

        public ContentProviderTest()
        {
            sut = new ContentProvider();
        }

        [Fact]
        public void ContentProvider_returns_not_empty_string()
        {
            var result = sut.GetContent();
             
            Assert.NotEmpty(result);
        }

        [Fact]
        public void ContentProvider_returns_not_null()
        {
            var result = sut.GetContent();

            Assert.NotNull(result); 
        }

        [Fact]
        public void AlwaysTrue()
        {
            Assert.True(true);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using Xunit;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class CheckNullExtensionsUnitTests
    {
        [Fact]
        public void NullDoAction()
        {
            var actual = 0;

            var xs = new List<string> { null };

            xs
                .FirstOrDefault()
                .NullDo(() => actual = 1);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void NotNullDoAction()
        {
            var actual = "";

            var xs = new List<string> { "some string" };

            xs
                .FirstOrDefault()
                .NotNullDo(x => actual = x);

            Assert.Equal("some string", actual);
        }

        [Fact]
        public void NotNullDoFunc()
        {
            var actual = 0;

            var xs = new List<string> { "some string" };

            actual = 
                xs
                    .FirstOrDefault()
                    .NotNullDo(x => x.Length);

            Assert.Equal(11, actual);
        }
    }
}

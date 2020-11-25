using Balloons;
using Xunit;

namespace BaloonsTests
{
    public class SearcherTests
    {
        [Fact]
        public void CanInitSearcherObject()
        {
            _ = new Searcher("test");
        }

        [Theory]
        [InlineData("a", 3)]
        [InlineData("aa", 1)]
        [InlineData("abc", 3)]
        [InlineData("abcdd", 1)]
        [InlineData("z", 0)]
        [InlineData("%", 0)]
        [InlineData("     a", 0)]
        [InlineData("zaaa", 0)]
        [InlineData("a a", 0)]
        [InlineData("a\ta", 0)]
        [InlineData("a\na", 0)]
        public void CallingSearchReturnsCorrectResult(string search, int expectedResult)
        {
            // Arrange
            var searcher = new Searcher("aaabbbcccddd");

            // Act
            int result = searcher.Search(search);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}

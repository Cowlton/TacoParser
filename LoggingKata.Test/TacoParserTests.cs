using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...", -84.683302)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.145076,-86.749777,Taco Bell Caler...", -86.749777)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            
            var tacoParser = new TacoParser();

            //Act
            
            var actual = tacoParser.Parse(line);

            //Assert
            
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        
        
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth...", 34.035985)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", 34.376395)]
        [InlineData("33.145076,-86.749777,Taco Bell Caler...", 33.145076)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            
            var tacoParser = new TacoParser();

            //Act
            
            var actual = tacoParser.Parse(line);

            //Assert
            
            Assert.Equal(expected, actual.Location.Latitude);
        }


    }
}

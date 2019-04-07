using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringRotation
{
    public class Test
    {
        [Fact]
        public void IsSubstringShouldReturnTrue_WhenFirstStringHello_AndStringToBeCheckedHell()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.IsSubString("hello", "hell");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsSubStringShouldReturnTrue_WhenFirstStringHelloWorld_AndStringToBeCheckedoWo()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.IsSubString("HelloWorld", "oWo");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsSubStringShouldReturnFalse_WhenStringToBeCheckedNull()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.IsSubString("HelloWorld", null);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsSubStringShouldReturnFalse_WhenFirstStringNull()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.IsSubString(null, "oWo");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void MySolutionShouldReturnTrue_WhenOriginalWaterbottle_AndItemToBeCheckederbottleWat()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.MySolution("waterbottle", "erbottlewat");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void MySolutionShouldReturnTrue_WhenOriginalHello_AndItemToBeCheckedoHell()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.MySolution("Hello", "oHell");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void MySolutionShouldReturnTrue_WhenOriginalcomputer_AndItemToBeCheckedutercomp()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.MySolution("computer", "utercomp");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void MySolutionShouldReturnTrue_WhenOriginalutercomp_AndItemToBeCheckedcomputer()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.MySolution("utercomp", "computer");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void MySolutionShouldReturnTrue_WhenOriginalcomputer_AndItemToBeCheckedcomputer()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.MySolution("computer", "computer");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void BookSolutionShouldReturnTrue_WhenOriginalwaterbottle_AndItemToBeCheckederbottlewat()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.BookSolution("waterbottle", "erbottlewat");
            //Assert
            Assert.True(result);
        }
    }
}

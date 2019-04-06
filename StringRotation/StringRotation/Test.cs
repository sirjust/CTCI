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
        public void stringRotationShouldReturnTrue_WhenOriginalWaterbottle_AndItemToBeCheckederbottleWat()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.stringRotation("waterbottle", "erbottlewat");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void stringRotationShouldReturnTrue_WhenOriginalHello_AndItemToBeCheckedoHell()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.stringRotation("Hello", "oHell");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void stringRotationShouldReturnTrue_WhenOriginalcomputer_AndItemToBeCheckedutercomp()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.stringRotation("computer", "utercomp");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void stringRotationShouldReturnTrue_WhenOriginalutercomp_AndItemToBeCheckedcomputer()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.stringRotation("utercomp", "computer");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void stringRotationShouldReturnTrue_WhenOriginalcomputer_AndItemToBeCheckedcomputer()
        {
            //Arrange
            var stringRotation = new StringRotation();

            //Act
            var result = stringRotation.stringRotation("computer", "computer");
            //Assert
            Assert.True(result);
        }
    }
}

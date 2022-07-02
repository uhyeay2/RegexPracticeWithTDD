using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegexPractice;

namespace RegexPracticeTests
{
    public class RegexTests
    {
        private readonly RegexHelper _helper = new();

        #region Lesson One Tests

        [Theory]
        [InlineData("abcdefg")]
        [InlineData("abcde")]
        [InlineData("abc")]
        public void LessonOne_Given_StringContains_ABC_Should_ReturnTrue(string input)
        {

            // Arrange
            //var reg = new RegexHelper();

            // Act
            //var result = reg.LessonOne(input);

            // Assert
            //Assert.True(result);

            // We refactored our test after creating the second one to reduce the code needed.
            // First we created the private readonly RegexHelper property for this test class.
            //              - Make sure to initialize it too!

            // Then instead of storing the result to assert that it is true,
            // we call the method we are testing inside of the Assert.True() method.

            // This achieves the same result as storing the result and then passing it in,
            // but it saves us the step of having to store the result.

            Assert.True(_helper.LessonOne(input));
        }

        [Theory]
        [InlineData("123")]
        [InlineData("xyz")]
        [InlineData("hef")]
        public void LessonOne_Given_StringDoesNotContain_ABC_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonOne(input));
        }

        #endregion

        #region LessonOneAndAHalf Tests

        [Theory]
        [InlineData("abc123xyz")]
        [InlineData("var g = 123")]
        [InlineData("define 123")]
        public void LessonOneAndAHalf_Given_StringContains_AnyNumber_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonOneAndAHalf(input));
        }


        [Theory]
        [InlineData("abc")]
        [InlineData("var g ")]
        [InlineData("define")]
        public void LessonOneAndAHalf_Given_StringContains_NoNumber_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonOneAndAHalf(input));
        }

        #endregion

        #region Lesson Two Tests

        [Theory]
        [InlineData("cat.")]
        [InlineData("896.")]
        [InlineData("?=+.")]
        public void LessonTwo_Given_FourthCharacter_IsDot_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonTwo(input));
        }

        [Theory]
        [InlineData("abc1")]
        [InlineData("abca")]
        [InlineData("abcb")]
        public void LessonTwo_Given_FourthCharacter_IsNotDot_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonTwo(input));
        }

        #endregion

        #region Lesson Three Tests

        [Theory]
        [InlineData("can")]
        [InlineData("man")]
        [InlineData("fan")]
        public void LessonThree_Given_StringStartsWith_CMF_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonThree(input));
        }

        [Theory]
        [InlineData("dan")]
        [InlineData("ran")]
        [InlineData("pan")]
        public void LessonThree_Given_StringDoesNot_StartWith_CMF_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonThree(input));
        }


        #endregion

        #region Lesson Four Tests

        [Theory]
        [InlineData("hog")]
        [InlineData("dog")]
        public void LessonFour_Given_StringIsNotBog_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonFour(input));
        }

        [Theory]
        [InlineData("bog")]
        public void LessonFour_Given_StringIsBog_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonFour(input));
        }

        #endregion

        #region Lesson Five Tests

        [Theory]
        [InlineData("Ana")]
        [InlineData("Bob")]
        [InlineData("Cpc")]
        public void LessonFive_Given_StringHas_Lowercase_nop_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonFive(input));
        }

        #endregion

        #region Lesson Six Tests

        [Theory]
        [InlineData("wazzzzzup")]
        [InlineData("wazzzup")]
        public void LessonSix_Given_StringContains_ThreeZs_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonSix(input));
        }

        [Theory]
        [InlineData("wazup")]
        [InlineData("wazzdzup")]
        public void LessonSix_Given_StringDoesNotContain_ThreeZs_Should_ReturnFalse(string input)
        {
            Assert.False(_helper.LessonSix(input));
        }

        #endregion

        #region Lesson Seven Tests

        [Theory]
        [InlineData("aaaabcc")]
        [InlineData("aabbbbc")]
        [InlineData("aacc")]
        public void LessonSeven_Given_StringContainsTwoAs_Should_ReturnTrue(string input)
        {
            Assert.True(_helper.LessonSeven(input));
        }

        #endregion
    }
}

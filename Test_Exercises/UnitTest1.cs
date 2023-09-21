using C__methods_exercises.Exercises;

namespace Test_Exercises
{
    public class UnitTest1
    {
        [Fact]
        public void ExerciseFiveTest()
        {
            string expected = "Mendizabal, Jon";
            string actual = Exercises.UserInfo("Jon", "Mendizabal");
            Assert.Equal(expected, actual);
        }
    }
}
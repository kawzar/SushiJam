using UnityEngine.Assertions;

namespace RookBirdTools.Design_By_Contract_Tools
{
    public static class Asserts {

        /// <summary>
        /// Assert number in range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Included)</param>
        /// <param name="max">(Excluded)</param>
        public static void InRange(this float number, float min, float max)
        {
            Assert.IsTrue(number>=min && number<max);
        }
        /// <summary>
        /// Assert number in range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Included)</param>
        /// <param name="max">(Excluded)</param>
        public static void InRange(this int number, int min, int max)
        {
            Assert.IsTrue(number>=min && number<max);
        }
        /// <summary>
        /// Assert number in range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Included)</param>
        public static void InRange(this float number, float min)
        {
            Assert.IsTrue(number>=min);
        }
        
        
        
        
        
        /// <summary>
        /// Assert number out of range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Excluded)</param>
        /// <param name="max">(Included)</param>
        public static void OutRange(this float number, float min, float max)
        {
            Assert.IsTrue(number<min && number>=max);
        }
        /// <summary>
        /// Assert number out of range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Excluded)</param>
        /// <param name="max">(Included)</param>
        public static void OutRange(this int number, int min, int max)
        {
            Assert.IsTrue(number<min && number>=max);
        }
        /// <summary>
        /// Assert number out of range
        /// </summary>
        /// <param name="number">referenced number</param>
        /// <param name="min">(Excluded)</param>
        public static void OutRange(this int number, float min)
        {
            Assert.IsTrue(number<min);
        }
        
        
        
    
    }
}

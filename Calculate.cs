using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    /// <summary>
    /// Provides basic arithmetic operations.
    /// </summary>
    internal class Calculate : ICalculate
    {
        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="number1">The dividend.</param>
        /// <param name="number2">The divisor.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
        public int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return number1 / number2;
        }

        /// <summary>
        /// Subtracts the second number from the first number.
        /// </summary>
        /// <param name="number1">The minuend.</param>
        /// <param name="number2">The subtrahend.</param>
        /// <returns>The difference of the two numbers.</returns>
        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The product of the two numbers.</returns>
        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The sum of the two numbers.</returns>
        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

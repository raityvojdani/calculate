using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    /// <summary>
    /// Provides methods for basic arithmetic operations.
    /// </summary>
    internal interface ICalculate
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The sum of the two numbers.</returns>
        int Plus(int number1, int number2);

        /// <summary>
        /// Subtracts the second number from the first number.
        /// </summary>
        /// <param name="number1">The minuend.</param>
        /// <param name="number2">The subtrahend.</param>
        /// <returns>The difference of the two numbers.</returns>
        int Minus(int number1, int number2);

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The product of the two numbers.</returns>
        int Multiple(int number1, int number2);

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="number1">The dividend.</param>
        /// <param name="number2">The divisor.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
        int Divide(int number1, int number2);
    }
}

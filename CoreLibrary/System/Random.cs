//
// Copyright (c) 2017 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using System.Runtime.CompilerServices;

namespace System
{
    /// <summary>
    /// Represents a pseudo-random number generator, a device that produces a
    /// sequence of numbers that meet certain statistical requirements for
    /// randomness.
    /// </summary>
    public class Random
    {
        private object _random;

        /// <summary>
        /// Initializes a new instance of the Random class, using a time-
        /// dependent default seed value.
        /// </summary>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern Random();

        /// <summary>
        /// Initializes a new instance of the Random class, using the specified
        /// seed value.
        /// </summary>
        /// <param name="seed">A number used to calculate a starting value for
        /// the pseudo-random number sequence.</param>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern Random(int seed);

        /// <summary>
        /// Returns a nonnegative random number.
        /// </summary>
        /// <returns>A 32-bit signed integer greater than or equal to zero and
        /// less than MaxValue.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public virtual extern int Next();

        /// <summary>
        /// Returns a nonnegative random number less than the specified maximum.
        /// </summary>
        /// <param name="maxValue">The exclusive upper bound of the random number
        /// to be generated. maxValue must be greater than or equal to zero.</param>
        /// <returns>A 32-bit signed integer greater than or equal to zero, and
        /// less than maxValue.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public virtual extern int Next(int maxValue);

        /// <summary>
        /// Returns a random number between 0.0 and 1.0.
        /// </summary>
        /// <returns>A double-precision floating point number greater than or equal
        /// to 0.0, and less than 1.0.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public virtual extern double NextDouble();

        /// <summary>
        /// Fills the elements of a specified array of bytes with random numbers.
        /// </summary>
        /// <param name="buffer">An array of bytes to contain random numbers.</param>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public virtual extern void NextBytes(byte[] buffer);
    }
}

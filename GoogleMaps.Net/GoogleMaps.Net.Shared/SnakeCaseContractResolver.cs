// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SnakeCaseContractResolver.cs" company="Sanu Sathyaseelan">
//   The MIT License (MIT)
//   
//   Copyright (c) 2016 Sanu Sathyaseelan
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//   SOFTWARE.
// </copyright>
// <summary>
//   The snake case contract resolver.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared
{
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// The snake case contract resolver.
    /// </summary>
    public class SnakeCaseContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// The resolve property name.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        protected override string ResolvePropertyName(string propertyName)
        {
            return GetSnakeCase(propertyName);
        }

        /// <summary>
        /// The get snake case.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var buffer = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                var isLast = i == input.Length - 1;
                var isSecondFromLast = i == input.Length - 2;

                var curr = input[i];
                var next = !isLast ? input[i + 1] : '\0';
                var afterNext = !isSecondFromLast && !isLast ? input[i + 2] : '\0';

                buffer += char.ToLower(curr);

                if (!char.IsDigit(curr) && char.IsUpper(next))
                {
                    if (char.IsUpper(curr))
                    {
                        if (!isLast && !isSecondFromLast && !char.IsUpper(afterNext))
                            buffer += "_";
                    }
                    else
                        buffer += "_";
                }

                if (!char.IsDigit(curr) && char.IsDigit(next))
                    buffer += "_";
                if (char.IsDigit(curr) && !char.IsDigit(next) && !isLast)
                    buffer += "_";
            }

            return buffer;
        }
    }
}
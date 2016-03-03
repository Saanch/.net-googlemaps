// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlaceSearchServiceTests.cs" company="Sanu Sathyaseelan">
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
//   The place search service tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Places.Tests
{
    using NUnit.Framework;
    using Shared.Response;

    /// <summary>
    /// The place search service tests.
    /// </summary>
    [TestFixture]
    public class PlaceSearchServiceTests
    {
        /// <summary>
        /// The returns status ok when valid place id provided.
        /// </summary>
        [Test]
        public void ReturnsStatusOkWhenValidPlaceIdProvided()
        {
            var placeId = "ChIJN1t_tDeuEmsRUsoyG83frY4";
            using (var client = new GoogleMapsApiClient("AIzaSyAkQzokNWcuyH4wa6nT5mclfsmdpMAjOZc"))
            {
                var places = client.PlaceSearch;
                var result = places.Details(placeId).Result;
                Assert.AreEqual(ResultStatus.OK, result.Status);
            }
        }
    }
}
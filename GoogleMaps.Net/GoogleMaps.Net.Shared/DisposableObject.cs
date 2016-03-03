// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisposableObject.cs" company="Sanu Sathyaseelan">
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
//   Base class for disposable objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GoogleMaps.Net.Shared
{
    using System;

    /// <summary>
    /// Base class for disposable objects.
    /// </summary>
    public abstract class DisposableObject : IDisposable
    {
        /// <summary>
        /// Has the object been disposed?
        /// </summary>
        private bool _isDisposed;

        /// <summary>
        /// Has the object been disposed?
        /// </summary>
        protected bool IsDisposed
        {
            get { return _isDisposed; }
        }

        /// <summary>
        /// Dispose of resources being used by the disposable object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

            _isDisposed = true;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="DisposableObject"/> class. 
        /// Finalises an instance of the <see cref="DisposableObject"/> class. 
        /// Finaliser for <see cref="DisposableObject"/>.
        /// </summary>
        ~DisposableObject()
        {
            Dispose(false);
        }

        /// <summary>
        /// Dispose of resources being used by the disposable object.
        /// </summary>
        /// <param name="disposing">
        /// Explicit disposal?
        /// </param>
        protected abstract void Dispose(bool disposing);

        /// <summary>
        /// Check if the object has been disposed.
        /// </summary>
        /// <exception cref="ObjectDisposedException">
        /// The object has been disposed.
        /// </exception>
        protected void CheckDisposed()
        {
            if (!_isDisposed)
                return;

            throw new ObjectDisposedException(GetType().Name);
        }
    }
}
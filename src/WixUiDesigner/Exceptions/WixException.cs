﻿/*
 *
 * Published under MIT license as described in the LICENSE.md file.
 *
 */

using System;

#nullable enable

namespace WixUiDesigner.Exceptions
{
    public sealed class WixException : Exception
    {
        public WixException(string message) : base(message){}
    }
}

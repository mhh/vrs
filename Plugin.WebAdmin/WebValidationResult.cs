﻿// Copyright © 2015 onwards, Andrew Whewell
// All rights reserved.
//
// Redistribution and use of this software in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//    * Neither the name of the author nor the names of the program's contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHORS OF THE SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualRadar.Interface.View;

namespace VirtualRadar.Plugin.WebAdmin
{
    /// <summary>
    /// Similar to <see cref="ValidationResult"/> but replaces references to objects with references
    /// to their identifier and <see cref="ValidationField"/> enums with their names.
    /// </summary>
    public class WebValidationResult
    {
        /// <summary>
        /// Gets or sets the name of the type of record that failed validation. This should be null for top-level objects.
        /// </summary>
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the record that failed validation. This should be null if <see cref="RecordType"/> is null.
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// Gets or sets a value that identifies the field that failed validation.
        /// </summary>
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or sets a message that describes the problem with the field.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the severity of the problem.
        /// </summary>
        public bool IsWarning { get; set; }

        /// <summary>
        /// See base docs.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}: {1}", FieldId, Message ?? "<null>");
        }
    }
}

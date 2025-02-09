// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Key information. </summary>
    internal partial class KeyInfo
    {
        /// <summary> Initializes a new instance of <see cref="KeyInfo"/>. </summary>
        /// <param name="expiry"> The date-time the key expires in ISO 8601 UTC time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expiry"/> is null. </exception>
        public KeyInfo(string expiry)
        {
            if (expiry == null)
            {
                throw new ArgumentNullException(nameof(expiry));
            }

            Expiry = expiry;
        }

        /// <summary> Initializes a new instance of <see cref="KeyInfo"/>. </summary>
        /// <param name="start"> The date-time the key is active in ISO 8601 UTC time. </param>
        /// <param name="expiry"> The date-time the key expires in ISO 8601 UTC time. </param>
        internal KeyInfo(string start, string expiry)
        {
            Start = start;
            Expiry = expiry;
        }

        /// <summary> The date-time the key is active in ISO 8601 UTC time. </summary>
        public string Start { get; set; }
        /// <summary> The date-time the key expires in ISO 8601 UTC time. </summary>
        public string Expiry { get; }
    }
}

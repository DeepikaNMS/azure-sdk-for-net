// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents an administrative division. e.g. state or province. </summary>
    public partial class PhoneNumberAdministrativeDivision
    {
        /// <summary> Initializes a new instance of <see cref="PhoneNumberAdministrativeDivision"/>. </summary>
        /// <param name="localizedName"> Represents the localized name of the administrative division of the locality. e.g. state or province localized name. </param>
        /// <param name="abbreviatedName"> Represents the abbreviated name of the administrative division of the locality. e.g. state or province abbreviation such as WA (Washington). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localizedName"/> or <paramref name="abbreviatedName"/> is null. </exception>
        internal PhoneNumberAdministrativeDivision(string localizedName, string abbreviatedName)
        {
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }
            if (abbreviatedName == null)
            {
                throw new ArgumentNullException(nameof(abbreviatedName));
            }

            LocalizedName = localizedName;
            AbbreviatedName = abbreviatedName;
        }

        /// <summary> Represents the localized name of the administrative division of the locality. e.g. state or province localized name. </summary>
        public string LocalizedName { get; }
        /// <summary> Represents the abbreviated name of the administrative division of the locality. e.g. state or province abbreviation such as WA (Washington). </summary>
        public string AbbreviatedName { get; }
    }
}

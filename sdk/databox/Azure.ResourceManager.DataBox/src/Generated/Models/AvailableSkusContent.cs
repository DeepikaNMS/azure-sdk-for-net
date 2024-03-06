// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The filters for showing the available skus. </summary>
    public partial class AvailableSkusContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableSkusContent"/>. </summary>
        /// <param name="transferType"> Type of the transfer. </param>
        /// <param name="country"> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </param>
        /// <param name="location"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="country"/> is null. </exception>
        public AvailableSkusContent(DataBoxJobTransferType transferType, string country, AzureLocation location)
        {
            if (country == null)
            {
                throw new ArgumentNullException(nameof(country));
            }

            TransferType = transferType;
            Country = country;
            Location = location;
            SkuNames = new ChangeTrackingList<DataBoxSkuName>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableSkusContent"/>. </summary>
        /// <param name="transferType"> Type of the transfer. </param>
        /// <param name="country"> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </param>
        /// <param name="location"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuNames"> Sku Names to filter for available skus. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableSkusContent(DataBoxJobTransferType transferType, string country, AzureLocation location, IList<DataBoxSkuName> skuNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TransferType = transferType;
            Country = country;
            Location = location;
            SkuNames = skuNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AvailableSkusContent"/> for deserialization. </summary>
        internal AvailableSkusContent()
        {
        }

        /// <summary> Type of the transfer. </summary>
        public DataBoxJobTransferType TransferType { get; }
        /// <summary> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </summary>
        public string Country { get; }
        /// <summary> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </summary>
        public AzureLocation Location { get; }
        /// <summary> Sku Names to filter for available skus. </summary>
        public IList<DataBoxSkuName> SkuNames { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Parameters of move resources. </summary>
    public partial class ResourcesMoveContent
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

        /// <summary> Initializes a new instance of <see cref="ResourcesMoveContent"/>. </summary>
        public ResourcesMoveContent()
        {
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourcesMoveContent"/>. </summary>
        /// <param name="resources"> The IDs of the resources. </param>
        /// <param name="targetResourceGroupId"> The target resource group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourcesMoveContent(IList<string> resources, ResourceIdentifier targetResourceGroupId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resources = resources;
            TargetResourceGroupId = targetResourceGroupId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IDs of the resources. </summary>
        public IList<string> Resources { get; }
        /// <summary> The target resource group. </summary>
        public ResourceIdentifier TargetResourceGroupId { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The network rule set for a container registry. </summary>
    public partial class ContainerRegistryNetworkRuleSet
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNetworkRuleSet"/>. </summary>
        /// <param name="defaultAction"> The default action of allow or deny when no other rules match. </param>
        public ContainerRegistryNetworkRuleSet(ContainerRegistryNetworkRuleDefaultAction defaultAction)
        {
            DefaultAction = defaultAction;
            IPRules = new ChangeTrackingList<ContainerRegistryIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNetworkRuleSet"/>. </summary>
        /// <param name="defaultAction"> The default action of allow or deny when no other rules match. </param>
        /// <param name="ipRules"> The IP ACL rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryNetworkRuleSet(ContainerRegistryNetworkRuleDefaultAction defaultAction, IList<ContainerRegistryIPRule> ipRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultAction = defaultAction;
            IPRules = ipRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNetworkRuleSet"/> for deserialization. </summary>
        internal ContainerRegistryNetworkRuleSet()
        {
        }

        /// <summary> The default action of allow or deny when no other rules match. </summary>
        public ContainerRegistryNetworkRuleDefaultAction DefaultAction { get; set; }
        /// <summary> The IP ACL rules. </summary>
        public IList<ContainerRegistryIPRule> IPRules { get; }
    }
}

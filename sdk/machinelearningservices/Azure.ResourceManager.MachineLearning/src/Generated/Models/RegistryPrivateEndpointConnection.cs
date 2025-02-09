// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Private endpoint connection definition. </summary>
    public partial class RegistryPrivateEndpointConnection
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

        /// <summary> Initializes a new instance of <see cref="RegistryPrivateEndpointConnection"/>. </summary>
        public RegistryPrivateEndpointConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RegistryPrivateEndpointConnection"/>. </summary>
        /// <param name="id">
        /// This is the private endpoint connection name created on SRP
        /// Full resource id: /subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.MachineLearningServices/{resourceType}/{resourceName}/privateEndpointConnections/{peConnectionName}
        /// </param>
        /// <param name="location"> Same as workspace location. </param>
        /// <param name="groupIds"> The group ids. </param>
        /// <param name="privateEndpoint"> The PE network resource that is linked to this PE connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The connection state. </param>
        /// <param name="provisioningState"> One of null, "Succeeded", "Provisioning", "Failed". While not approved, it's null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegistryPrivateEndpointConnection(ResourceIdentifier id, AzureLocation? location, IList<string> groupIds, RegistryPrivateEndpoint privateEndpoint, RegistryPrivateLinkServiceConnectionState privateLinkServiceConnectionState, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Location = location;
            GroupIds = groupIds;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// This is the private endpoint connection name created on SRP
        /// Full resource id: /subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.MachineLearningServices/{resourceType}/{resourceName}/privateEndpointConnections/{peConnectionName}
        /// </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Same as workspace location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The group ids. </summary>
        public IList<string> GroupIds { get; set; }
        /// <summary> The PE network resource that is linked to this PE connection. </summary>
        public RegistryPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> The connection state. </summary>
        public RegistryPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> One of null, "Succeeded", "Provisioning", "Failed". While not approved, it's null. </summary>
        public string ProvisioningState { get; set; }
    }
}

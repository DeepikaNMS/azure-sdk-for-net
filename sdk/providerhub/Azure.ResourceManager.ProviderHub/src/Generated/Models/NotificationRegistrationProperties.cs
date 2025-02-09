// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The NotificationRegistrationProperties. </summary>
    public partial class NotificationRegistrationProperties
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

        /// <summary> Initializes a new instance of <see cref="NotificationRegistrationProperties"/>. </summary>
        public NotificationRegistrationProperties()
        {
            IncludedEvents = new ChangeTrackingList<string>();
            NotificationEndpoints = new ChangeTrackingList<NotificationEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationRegistrationProperties"/>. </summary>
        /// <param name="notificationMode"></param>
        /// <param name="messageScope"></param>
        /// <param name="includedEvents"></param>
        /// <param name="notificationEndpoints"></param>
        /// <param name="provisioningState"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationRegistrationProperties(NotificationMode? notificationMode, MessageScope? messageScope, IList<string> includedEvents, IList<NotificationEndpoint> notificationEndpoints, ProviderHubProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NotificationMode = notificationMode;
            MessageScope = messageScope;
            IncludedEvents = includedEvents;
            NotificationEndpoints = notificationEndpoints;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the notification mode. </summary>
        public NotificationMode? NotificationMode { get; set; }
        /// <summary> Gets or sets the message scope. </summary>
        public MessageScope? MessageScope { get; set; }
        /// <summary> Gets the included events. </summary>
        public IList<string> IncludedEvents { get; }
        /// <summary> Gets the notification endpoints. </summary>
        public IList<NotificationEndpoint> NotificationEndpoints { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
    }
}

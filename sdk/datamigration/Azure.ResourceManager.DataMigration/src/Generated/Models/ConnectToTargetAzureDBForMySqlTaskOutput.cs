// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure Database for MySQL and target server requirements. </summary>
    public partial class ConnectToTargetAzureDBForMySqlTaskOutput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetAzureDBForMySqlTaskOutput"/>. </summary>
        internal ConnectToTargetAzureDBForMySqlTaskOutput()
        {
            Databases = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetAzureDBForMySqlTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="serverVersion"> Version of the target server. </param>
        /// <param name="databases"> List of databases on target server. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="validationErrors"> Validation errors associated with the task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetAzureDBForMySqlTaskOutput(string id, string serverVersion, IReadOnlyList<string> databases, string targetServerBrandVersion, IReadOnlyList<ReportableException> validationErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ServerVersion = serverVersion;
            Databases = databases;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Version of the target server. </summary>
        public string ServerVersion { get; }
        /// <summary> List of databases on target server. </summary>
        public IReadOnlyList<string> Databases { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Validation errors associated with the task. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}

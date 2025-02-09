// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Scaling configurations for event driven jobs. </summary>
    public partial class ContainerAppJobScale
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobScale"/>. </summary>
        public ContainerAppJobScale()
        {
            Rules = new ChangeTrackingList<ContainerAppJobScaleRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobScale"/>. </summary>
        /// <param name="pollingIntervalInSeconds"> Interval to check each event source in seconds. Defaults to 30s. </param>
        /// <param name="minExecutions"> Minimum number of job executions that are created for a trigger, default 0. </param>
        /// <param name="maxExecutions"> Maximum number of job executions that are created for a trigger, default 100. </param>
        /// <param name="rules"> Scaling rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppJobScale(int? pollingIntervalInSeconds, int? minExecutions, int? maxExecutions, IList<ContainerAppJobScaleRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PollingIntervalInSeconds = pollingIntervalInSeconds;
            MinExecutions = minExecutions;
            MaxExecutions = maxExecutions;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Interval to check each event source in seconds. Defaults to 30s. </summary>
        public int? PollingIntervalInSeconds { get; set; }
        /// <summary> Minimum number of job executions that are created for a trigger, default 0. </summary>
        public int? MinExecutions { get; set; }
        /// <summary> Maximum number of job executions that are created for a trigger, default 100. </summary>
        public int? MaxExecutions { get; set; }
        /// <summary> Scaling rules. </summary>
        public IList<ContainerAppJobScaleRule> Rules { get; }
    }
}

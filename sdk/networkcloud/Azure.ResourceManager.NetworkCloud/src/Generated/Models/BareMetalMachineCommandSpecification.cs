// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineCommandSpecification represents the command and optional arguments to exercise against the bare metal machine. </summary>
    public partial class BareMetalMachineCommandSpecification
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

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCommandSpecification"/>. </summary>
        /// <param name="command"> The command to execute against the bare metal machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> is null. </exception>
        public BareMetalMachineCommandSpecification(string command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            Arguments = new ChangeTrackingList<string>();
            Command = command;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCommandSpecification"/>. </summary>
        /// <param name="arguments"> The list of string arguments that will be passed to the script in order as separate arguments. </param>
        /// <param name="command"> The command to execute against the bare metal machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineCommandSpecification(IList<string> arguments, string command, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Arguments = arguments;
            Command = command;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineCommandSpecification"/> for deserialization. </summary>
        internal BareMetalMachineCommandSpecification()
        {
        }

        /// <summary> The list of string arguments that will be passed to the script in order as separate arguments. </summary>
        public IList<string> Arguments { get; }
        /// <summary> The command to execute against the bare metal machine. </summary>
        public string Command { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class GatewayOperationDetails : IUtf8JsonSerializable, IJsonModel<GatewayOperationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayOperationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GatewayOperationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayOperationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(ProgressPercentage))
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeElapsed))
            {
                writer.WritePropertyName("timeElapsed"u8);
                writer.WriteNumberValue(TimeElapsed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeRemaining))
            {
                writer.WritePropertyName("timeRemaining"u8);
                writer.WriteNumberValue(TimeRemaining.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UploadSpeed))
            {
                writer.WritePropertyName("uploadSpeed"u8);
                writer.WriteNumberValue(UploadSpeed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DataStores))
            {
                writer.WritePropertyName("dataStores"u8);
                writer.WriteStartArray();
                foreach (var item in DataStores)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(VMwareReadThroughput))
            {
                writer.WritePropertyName("vmwareReadThroughput"u8);
                writer.WriteNumberValue(VMwareReadThroughput.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        GatewayOperationDetails IJsonModel<GatewayOperationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayOperationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayOperationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayOperationDetails(document.RootElement, options);
        }

        internal static GatewayOperationDetails DeserializeGatewayOperationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string state = default;
            int? progressPercentage = default;
            long? timeElapsed = default;
            long? timeRemaining = default;
            long? uploadSpeed = default;
            string hostName = default;
            IReadOnlyList<string> dataStores = default;
            long? vmwareReadThroughput = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeElapsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeElapsed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("timeRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeRemaining = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("uploadSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataStores = array;
                    continue;
                }
                if (property.NameEquals("vmwareReadThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareReadThroughput = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GatewayOperationDetails(
                state,
                progressPercentage,
                timeElapsed,
                timeRemaining,
                uploadSpeed,
                hostName,
                dataStores ?? new ChangeTrackingList<string>(),
                vmwareReadThroughput,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayOperationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GatewayOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        GatewayOperationDetails IPersistableModel<GatewayOperationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayOperationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGatewayOperationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayOperationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayOperationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

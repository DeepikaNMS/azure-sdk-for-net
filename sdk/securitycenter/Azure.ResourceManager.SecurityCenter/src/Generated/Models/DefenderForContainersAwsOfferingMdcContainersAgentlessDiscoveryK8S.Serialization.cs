// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S : IUtf8JsonSerializable, IJsonModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S IJsonModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S(document.RootElement, options);
        }

        internal static DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S DeserializeDefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string cloudRoleArn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S(enabled, cloudRoleArn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{options.Format}' format.");
            }
        }

        DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersAwsOfferingMdcContainersAgentlessDiscoveryK8S>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

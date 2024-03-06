// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterSshProfile : IUtf8JsonSerializable, IJsonModel<ClusterSshProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterSshProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterSshProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSshProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterSshProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            if (options.Format != "W" && Optional.IsDefined(PodPrefix))
            {
                writer.WritePropertyName("podPrefix"u8);
                writer.WriteStringValue(PodPrefix);
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

        ClusterSshProfile IJsonModel<ClusterSshProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSshProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterSshProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterSshProfile(document.RootElement, options);
        }

        internal static ClusterSshProfile DeserializeClusterSshProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            string podPrefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("podPrefix"u8))
                {
                    podPrefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterSshProfile(count, podPrefix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterSshProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSshProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterSshProfile)} does not support '{options.Format}' format.");
            }
        }

        ClusterSshProfile IPersistableModel<ClusterSshProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterSshProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterSshProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterSshProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterSshProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

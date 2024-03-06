// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class StorageAccountForDataLakeAnalyticsAccountUpdateContent : IUtf8JsonSerializable, IJsonModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountForDataLakeAnalyticsAccountUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(Suffix))
            {
                writer.WritePropertyName("suffix"u8);
                writer.WriteStringValue(Suffix);
            }
            writer.WriteEndObject();
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

        StorageAccountForDataLakeAnalyticsAccountUpdateContent IJsonModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountForDataLakeAnalyticsAccountUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountForDataLakeAnalyticsAccountUpdateContent(document.RootElement, options);
        }

        internal static StorageAccountForDataLakeAnalyticsAccountUpdateContent DeserializeStorageAccountForDataLakeAnalyticsAccountUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string accessKey = default;
            string suffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessKey"u8))
                        {
                            accessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffix"u8))
                        {
                            suffix = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountForDataLakeAnalyticsAccountUpdateContent(name, accessKey, suffix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountForDataLakeAnalyticsAccountUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountForDataLakeAnalyticsAccountUpdateContent IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountForDataLakeAnalyticsAccountUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountForDataLakeAnalyticsAccountUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountForDataLakeAnalyticsAccountUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

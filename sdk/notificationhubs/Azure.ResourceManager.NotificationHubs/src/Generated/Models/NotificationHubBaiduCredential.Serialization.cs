// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubBaiduCredential : IUtf8JsonSerializable, IJsonModel<NotificationHubBaiduCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubBaiduCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationHubBaiduCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubBaiduCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubBaiduCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BaiduApiKey))
            {
                writer.WritePropertyName("baiduApiKey"u8);
                writer.WriteStringValue(BaiduApiKey);
            }
            if (Optional.IsDefined(BaiduEndpoint))
            {
                writer.WritePropertyName("baiduEndPoint"u8);
                writer.WriteStringValue(BaiduEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(BaiduSecretKey))
            {
                writer.WritePropertyName("baiduSecretKey"u8);
                writer.WriteStringValue(BaiduSecretKey);
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

        NotificationHubBaiduCredential IJsonModel<NotificationHubBaiduCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubBaiduCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubBaiduCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubBaiduCredential(document.RootElement, options);
        }

        internal static NotificationHubBaiduCredential DeserializeNotificationHubBaiduCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string baiduApiKey = default;
            Uri baiduEndPoint = default;
            string baiduSecretKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("baiduApiKey"u8))
                        {
                            baiduApiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baiduEndPoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            baiduEndPoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("baiduSecretKey"u8))
                        {
                            baiduSecretKey = property0.Value.GetString();
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
            return new NotificationHubBaiduCredential(baiduApiKey, baiduEndPoint, baiduSecretKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubBaiduCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubBaiduCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubBaiduCredential)} does not support '{options.Format}' format.");
            }
        }

        NotificationHubBaiduCredential IPersistableModel<NotificationHubBaiduCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubBaiduCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubBaiduCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubBaiduCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubBaiduCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

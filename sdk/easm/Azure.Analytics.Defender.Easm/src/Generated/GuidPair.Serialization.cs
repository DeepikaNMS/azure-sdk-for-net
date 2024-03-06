// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class GuidPair : IUtf8JsonSerializable, IJsonModel<GuidPair>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuidPair>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuidPair>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidPair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuidPair)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PageGuid))
            {
                writer.WritePropertyName("pageGuid"u8);
                writer.WriteStringValue(PageGuid);
            }
            if (Optional.IsDefined(CrawlStateGuid))
            {
                writer.WritePropertyName("crawlStateGuid"u8);
                writer.WriteStringValue(CrawlStateGuid);
            }
            if (Optional.IsDefined(LoadDate))
            {
                writer.WritePropertyName("loadDate"u8);
                writer.WriteStringValue(LoadDate.Value, "O");
            }
            if (Optional.IsDefined(Recent))
            {
                writer.WritePropertyName("recent"u8);
                writer.WriteBooleanValue(Recent.Value);
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

        GuidPair IJsonModel<GuidPair>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidPair>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuidPair)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuidPair(document.RootElement, options);
        }

        internal static GuidPair DeserializeGuidPair(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pageGuid = default;
            string crawlStateGuid = default;
            DateTimeOffset? loadDate = default;
            bool? recent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageGuid"u8))
                {
                    pageGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crawlStateGuid"u8))
                {
                    crawlStateGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuidPair(pageGuid, crawlStateGuid, loadDate, recent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuidPair>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidPair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuidPair)} does not support '{options.Format}' format.");
            }
        }

        GuidPair IPersistableModel<GuidPair>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidPair>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuidPair(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuidPair)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuidPair>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GuidPair FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGuidPair(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

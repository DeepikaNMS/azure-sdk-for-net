// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class QuotaCounterContract : IUtf8JsonSerializable, IJsonModel<QuotaCounterContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaCounterContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaCounterContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("counterKey"u8);
            writer.WriteStringValue(CounterKey);
            writer.WritePropertyName("periodKey"u8);
            writer.WriteStringValue(PeriodKey);
            writer.WritePropertyName("periodStartTime"u8);
            writer.WriteStringValue(PeriodStartOn, "O");
            writer.WritePropertyName("periodEndTime"u8);
            writer.WriteStringValue(PeriodEndOn, "O");
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteObjectValue(Value);
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

        QuotaCounterContract IJsonModel<QuotaCounterContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaCounterContract(document.RootElement, options);
        }

        internal static QuotaCounterContract DeserializeQuotaCounterContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string counterKey = default;
            string periodKey = default;
            DateTimeOffset periodStartTime = default;
            DateTimeOffset periodEndTime = default;
            QuotaCounterValueContractProperties value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counterKey"u8))
                {
                    counterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodKey"u8))
                {
                    periodKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodStartTime"u8))
                {
                    periodStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("periodEndTime"u8))
                {
                    periodEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = QuotaCounterValueContractProperties.DeserializeQuotaCounterValueContractProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaCounterContract(
                counterKey,
                periodKey,
                periodStartTime,
                periodEndTime,
                value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaCounterContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support '{options.Format}' format.");
            }
        }

        QuotaCounterContract IPersistableModel<QuotaCounterContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaCounterContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaCounterContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

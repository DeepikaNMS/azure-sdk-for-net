// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorAzureFunctionReceiver : IUtf8JsonSerializable, IJsonModel<MonitorAzureFunctionReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorAzureFunctionReceiver>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorAzureFunctionReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAzureFunctionReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorAzureFunctionReceiver)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("functionAppResourceId"u8);
            writer.WriteStringValue(FunctionAppResourceId);
            writer.WritePropertyName("functionName"u8);
            writer.WriteStringValue(FunctionName);
            writer.WritePropertyName("httpTriggerUrl"u8);
            writer.WriteStringValue(HttpTriggerUri.AbsoluteUri);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
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

        MonitorAzureFunctionReceiver IJsonModel<MonitorAzureFunctionReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAzureFunctionReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorAzureFunctionReceiver)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorAzureFunctionReceiver(document.RootElement, options);
        }

        internal static MonitorAzureFunctionReceiver DeserializeMonitorAzureFunctionReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ResourceIdentifier functionAppResourceId = default;
            string functionName = default;
            Uri httpTriggerUrl = default;
            bool? useCommonAlertSchema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionAppResourceId"u8))
                {
                    functionAppResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("functionName"u8))
                {
                    functionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpTriggerUrl"u8))
                {
                    httpTriggerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorAzureFunctionReceiver(
                name,
                functionAppResourceId,
                functionName,
                httpTriggerUrl,
                useCommonAlertSchema,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorAzureFunctionReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAzureFunctionReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorAzureFunctionReceiver)} does not support '{options.Format}' format.");
            }
        }

        MonitorAzureFunctionReceiver IPersistableModel<MonitorAzureFunctionReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAzureFunctionReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorAzureFunctionReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorAzureFunctionReceiver)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorAzureFunctionReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

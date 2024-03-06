// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRewriteRuleActionSet : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayRewriteRuleActionSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayRewriteRuleActionSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayRewriteRuleActionSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRuleActionSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRuleActionSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RequestHeaderConfigurations))
            {
                writer.WritePropertyName("requestHeaderConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in RequestHeaderConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResponseHeaderConfigurations))
            {
                writer.WritePropertyName("responseHeaderConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in ResponseHeaderConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UrlConfiguration))
            {
                writer.WritePropertyName("urlConfiguration"u8);
                writer.WriteObjectValue(UrlConfiguration);
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

        ApplicationGatewayRewriteRuleActionSet IJsonModel<ApplicationGatewayRewriteRuleActionSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRuleActionSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRuleActionSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRewriteRuleActionSet(document.RootElement, options);
        }

        internal static ApplicationGatewayRewriteRuleActionSet DeserializeApplicationGatewayRewriteRuleActionSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ApplicationGatewayHeaderConfiguration> requestHeaderConfigurations = default;
            IList<ApplicationGatewayHeaderConfiguration> responseHeaderConfigurations = default;
            ApplicationGatewayUrlConfiguration urlConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestHeaderConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayHeaderConfiguration> array = new List<ApplicationGatewayHeaderConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayHeaderConfiguration.DeserializeApplicationGatewayHeaderConfiguration(item, options));
                    }
                    requestHeaderConfigurations = array;
                    continue;
                }
                if (property.NameEquals("responseHeaderConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayHeaderConfiguration> array = new List<ApplicationGatewayHeaderConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayHeaderConfiguration.DeserializeApplicationGatewayHeaderConfiguration(item, options));
                    }
                    responseHeaderConfigurations = array;
                    continue;
                }
                if (property.NameEquals("urlConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    urlConfiguration = ApplicationGatewayUrlConfiguration.DeserializeApplicationGatewayUrlConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayRewriteRuleActionSet(requestHeaderConfigurations ?? new ChangeTrackingList<ApplicationGatewayHeaderConfiguration>(), responseHeaderConfigurations ?? new ChangeTrackingList<ApplicationGatewayHeaderConfiguration>(), urlConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayRewriteRuleActionSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRuleActionSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRuleActionSet)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayRewriteRuleActionSet IPersistableModel<ApplicationGatewayRewriteRuleActionSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRuleActionSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayRewriteRuleActionSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRuleActionSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayRewriteRuleActionSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

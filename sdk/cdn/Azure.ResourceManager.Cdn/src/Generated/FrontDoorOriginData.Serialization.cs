// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorOriginData : IUtf8JsonSerializable, IJsonModel<FrontDoorOriginData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorOriginData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorOriginData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorOriginData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(OriginGroupName))
            {
                writer.WritePropertyName("originGroupName"u8);
                writer.WriteStringValue(OriginGroupName);
            }
            if (Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("azureOrigin"u8);
                JsonSerializer.Serialize(writer, Origin);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort"u8);
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort"u8);
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight"u8);
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(SharedPrivateLinkResource))
            {
                if (SharedPrivateLinkResource != null)
                {
                    writer.WritePropertyName("sharedPrivateLinkResource"u8);
                    writer.WriteObjectValue(SharedPrivateLinkResource);
                }
                else
                {
                    writer.WriteNull("sharedPrivateLinkResource");
                }
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(EnforceCertificateNameCheck))
            {
                writer.WritePropertyName("enforceCertificateNameCheck"u8);
                writer.WriteBooleanValue(EnforceCertificateNameCheck.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentStatus))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteStringValue(DeploymentStatus.Value.ToString());
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

        FrontDoorOriginData IJsonModel<FrontDoorOriginData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorOriginData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorOriginData(document.RootElement, options);
        }

        internal static FrontDoorOriginData DeserializeFrontDoorOriginData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string originGroupName = default;
            WritableSubResource azureOrigin = default;
            string hostName = default;
            int? httpPort = default;
            int? httpsPort = default;
            string originHostHeader = default;
            int? priority = default;
            int? weight = default;
            SharedPrivateLinkResourceProperties sharedPrivateLinkResource = default;
            EnabledState? enabledState = default;
            bool? enforceCertificateNameCheck = default;
            FrontDoorProvisioningState? provisioningState = default;
            FrontDoorDeploymentStatus? deploymentStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("originGroupName"u8))
                        {
                            originGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureOrigin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureOrigin = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sharedPrivateLinkResource = null;
                                continue;
                            }
                            sharedPrivateLinkResource = SharedPrivateLinkResourceProperties.DeserializeSharedPrivateLinkResourceProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enforceCertificateNameCheck"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enforceCertificateNameCheck = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FrontDoorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = new FrontDoorDeploymentStatus(property0.Value.GetString());
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
            return new FrontDoorOriginData(
                id,
                name,
                type,
                systemData,
                originGroupName,
                azureOrigin,
                hostName,
                httpPort,
                httpsPort,
                originHostHeader,
                priority,
                weight,
                sharedPrivateLinkResource,
                enabledState,
                enforceCertificateNameCheck,
                provisioningState,
                deploymentStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorOriginData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorOriginData)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorOriginData IPersistableModel<FrontDoorOriginData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorOriginData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorOriginData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorOriginData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorOriginData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

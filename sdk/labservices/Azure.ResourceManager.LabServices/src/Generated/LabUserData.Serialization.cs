// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabUserData : IUtf8JsonSerializable, IJsonModel<LabUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabUserData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabUserData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabUserData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(AdditionalUsageQuota))
            {
                writer.WritePropertyName("additionalUsageQuota"u8);
                writer.WriteStringValue(AdditionalUsageQuota.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("email"u8);
            writer.WriteStringValue(Email);
            if (options.Format != "W" && Optional.IsDefined(RegistrationState))
            {
                writer.WritePropertyName("registrationState"u8);
                writer.WriteStringValue(RegistrationState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(InvitationState))
            {
                writer.WritePropertyName("invitationState"u8);
                writer.WriteStringValue(InvitationState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(InvitationSentOn))
            {
                writer.WritePropertyName("invitationSent"u8);
                writer.WriteStringValue(InvitationSentOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TotalUsage))
            {
                writer.WritePropertyName("totalUsage"u8);
                writer.WriteStringValue(TotalUsage.Value, "P");
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

        LabUserData IJsonModel<LabUserData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabUserData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabUserData(document.RootElement, options);
        }

        internal static LabUserData DeserializeLabUserData(JsonElement element, ModelReaderWriterOptions options = null)
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
            TimeSpan? additionalUsageQuota = default;
            LabServicesProvisioningState? provisioningState = default;
            string displayName = default;
            string email = default;
            LabUserRegistrationState? registrationState = default;
            LabUserInvitationState? invitationState = default;
            DateTimeOffset? invitationSent = default;
            TimeSpan? totalUsage = default;
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
                        if (property0.NameEquals("additionalUsageQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalUsageQuota = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationState = property0.Value.GetString().ToLabUserRegistrationState();
                            continue;
                        }
                        if (property0.NameEquals("invitationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            invitationState = property0.Value.GetString().ToLabUserInvitationState();
                            continue;
                        }
                        if (property0.NameEquals("invitationSent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            invitationSent = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("totalUsage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalUsage = property0.Value.GetTimeSpan("P");
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
            return new LabUserData(
                id,
                name,
                type,
                systemData,
                additionalUsageQuota,
                provisioningState,
                displayName,
                email,
                registrationState,
                invitationState,
                invitationSent,
                totalUsage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabUserData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabUserData)} does not support '{options.Format}' format.");
            }
        }

        LabUserData IPersistableModel<LabUserData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabUserData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabUserData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabUserData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

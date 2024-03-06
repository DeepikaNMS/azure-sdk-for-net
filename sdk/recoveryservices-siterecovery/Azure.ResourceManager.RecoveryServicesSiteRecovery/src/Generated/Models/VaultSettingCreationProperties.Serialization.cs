// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VaultSettingCreationProperties : IUtf8JsonSerializable, IJsonModel<VaultSettingCreationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultSettingCreationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VaultSettingCreationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultSettingCreationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultSettingCreationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MigrationSolutionId))
            {
                writer.WritePropertyName("migrationSolutionId"u8);
                writer.WriteStringValue(MigrationSolutionId);
            }
            if (Optional.IsDefined(VMwareToAzureProviderType))
            {
                writer.WritePropertyName("vmwareToAzureProviderType"u8);
                writer.WriteStringValue(VMwareToAzureProviderType);
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

        VaultSettingCreationProperties IJsonModel<VaultSettingCreationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultSettingCreationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultSettingCreationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultSettingCreationProperties(document.RootElement, options);
        }

        internal static VaultSettingCreationProperties DeserializeVaultSettingCreationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier migrationSolutionId = default;
            string vmwareToAzureProviderType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmwareToAzureProviderType"u8))
                {
                    vmwareToAzureProviderType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultSettingCreationProperties(migrationSolutionId, vmwareToAzureProviderType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VaultSettingCreationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultSettingCreationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VaultSettingCreationProperties)} does not support '{options.Format}' format.");
            }
        }

        VaultSettingCreationProperties IPersistableModel<VaultSettingCreationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultSettingCreationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultSettingCreationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VaultSettingCreationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultSettingCreationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

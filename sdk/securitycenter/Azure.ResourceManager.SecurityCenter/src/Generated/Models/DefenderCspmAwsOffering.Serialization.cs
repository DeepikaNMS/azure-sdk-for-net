// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmAwsOffering : IUtf8JsonSerializable, IJsonModel<DefenderCspmAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmAwsOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmAwsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOffering)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            if (Optional.IsDefined(DataSensitivityDiscovery))
            {
                writer.WritePropertyName("dataSensitivityDiscovery"u8);
                writer.WriteObjectValue(DataSensitivityDiscovery);
            }
            if (Optional.IsDefined(DatabasesDspm))
            {
                writer.WritePropertyName("databasesDspm"u8);
                writer.WriteObjectValue(DatabasesDspm);
            }
            if (Optional.IsDefined(Ciem))
            {
                writer.WritePropertyName("ciem"u8);
                writer.WriteObjectValue(Ciem);
            }
            if (Optional.IsDefined(MdcContainersImageAssessment))
            {
                writer.WritePropertyName("mdcContainersImageAssessment"u8);
                writer.WriteObjectValue(MdcContainersImageAssessment);
            }
            if (Optional.IsDefined(MdcContainersAgentlessDiscoveryK8S))
            {
                writer.WritePropertyName("mdcContainersAgentlessDiscoveryK8s"u8);
                writer.WriteObjectValue(MdcContainersAgentlessDiscoveryK8S);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        DefenderCspmAwsOffering IJsonModel<DefenderCspmAwsOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOffering)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOffering(document.RootElement, options);
        }

        internal static DefenderCspmAwsOffering DeserializeDefenderCspmAwsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderCspmAwsOfferingVmScanners vmScanners = default;
            DefenderCspmAwsOfferingDataSensitivityDiscovery dataSensitivityDiscovery = default;
            DefenderCspmAwsOfferingDatabasesDspm databasesDspm = default;
            DefenderCspmAwsOfferingCiem ciem = default;
            DefenderCspmAwsOfferingMdcContainersImageAssessment mdcContainersImageAssessment = default;
            DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderCspmAwsOfferingVmScanners.DeserializeDefenderCspmAwsOfferingVmScanners(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataSensitivityDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSensitivityDiscovery = DefenderCspmAwsOfferingDataSensitivityDiscovery.DeserializeDefenderCspmAwsOfferingDataSensitivityDiscovery(property.Value, options);
                    continue;
                }
                if (property.NameEquals("databasesDspm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databasesDspm = DefenderCspmAwsOfferingDatabasesDspm.DeserializeDefenderCspmAwsOfferingDatabasesDspm(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ciem"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciem = DefenderCspmAwsOfferingCiem.DeserializeDefenderCspmAwsOfferingCiem(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersImageAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersImageAssessment = DefenderCspmAwsOfferingMdcContainersImageAssessment.DeserializeDefenderCspmAwsOfferingMdcContainersImageAssessment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersAgentlessDiscoveryK8s"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersAgentlessDiscoveryK8S = DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S.DeserializeDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmAwsOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                vmScanners,
                dataSensitivityDiscovery,
                databasesDspm,
                ciem,
                mdcContainersImageAssessment,
                mdcContainersAgentlessDiscoveryK8S);
        }

        BinaryData IPersistableModel<DefenderCspmAwsOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        DefenderCspmAwsOffering IPersistableModel<DefenderCspmAwsOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmAwsOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOffering)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmAwsOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

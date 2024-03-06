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

namespace Azure.AI.DocumentIntelligence
{
    public partial class AddressValue : IUtf8JsonSerializable, IJsonModel<AddressValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddressValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AddressValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HouseNumber))
            {
                writer.WritePropertyName("houseNumber"u8);
                writer.WriteStringValue(HouseNumber);
            }
            if (Optional.IsDefined(PoBox))
            {
                writer.WritePropertyName("poBox"u8);
                writer.WriteStringValue(PoBox);
            }
            if (Optional.IsDefined(Road))
            {
                writer.WritePropertyName("road"u8);
                writer.WriteStringValue(Road);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(CountryRegion))
            {
                writer.WritePropertyName("countryRegion"u8);
                writer.WriteStringValue(CountryRegion);
            }
            if (Optional.IsDefined(StreetAddress))
            {
                writer.WritePropertyName("streetAddress"u8);
                writer.WriteStringValue(StreetAddress);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(CityDistrict))
            {
                writer.WritePropertyName("cityDistrict"u8);
                writer.WriteStringValue(CityDistrict);
            }
            if (Optional.IsDefined(StateDistrict))
            {
                writer.WritePropertyName("stateDistrict"u8);
                writer.WriteStringValue(StateDistrict);
            }
            if (Optional.IsDefined(Suburb))
            {
                writer.WritePropertyName("suburb"u8);
                writer.WriteStringValue(Suburb);
            }
            if (Optional.IsDefined(House))
            {
                writer.WritePropertyName("house"u8);
                writer.WriteStringValue(House);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
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

        AddressValue IJsonModel<AddressValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValue(document.RootElement, options);
        }

        internal static AddressValue DeserializeAddressValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string houseNumber = default;
            string poBox = default;
            string road = default;
            string city = default;
            string state = default;
            string postalCode = default;
            string countryRegion = default;
            string streetAddress = default;
            string unit = default;
            string cityDistrict = default;
            string stateDistrict = default;
            string suburb = default;
            string house = default;
            string level = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("houseNumber"u8))
                {
                    houseNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poBox"u8))
                {
                    poBox = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("road"u8))
                {
                    road = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryRegion"u8))
                {
                    countryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress"u8))
                {
                    streetAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cityDistrict"u8))
                {
                    cityDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateDistrict"u8))
                {
                    stateDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suburb"u8))
                {
                    suburb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("house"u8))
                {
                    house = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AddressValue(
                houseNumber,
                poBox,
                road,
                city,
                state,
                postalCode,
                countryRegion,
                streetAddress,
                unit,
                cityDistrict,
                stateDistrict,
                suburb,
                house,
                level,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AddressValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddressValue)} does not support '{options.Format}' format.");
            }
        }

        AddressValue IPersistableModel<AddressValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAddressValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddressValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddressValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddressValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAddressValue(document.RootElement);
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

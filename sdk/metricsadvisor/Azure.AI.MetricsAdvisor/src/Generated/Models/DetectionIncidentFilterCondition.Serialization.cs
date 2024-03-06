// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DetectionIncidentFilterCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DimensionFilter)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}

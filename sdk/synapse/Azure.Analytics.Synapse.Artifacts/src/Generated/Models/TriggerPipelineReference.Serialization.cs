// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerPipelineReferenceConverter))]
    public partial class TriggerPipelineReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PipelineReference))
            {
                writer.WritePropertyName("pipelineReference"u8);
                writer.WriteObjectValue(PipelineReference);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static TriggerPipelineReference DeserializeTriggerPipelineReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PipelineReference pipelineReference = default;
            IDictionary<string, object> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineReference = PipelineReference.DeserializePipelineReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
            }
            return new TriggerPipelineReference(pipelineReference, parameters ?? new ChangeTrackingDictionary<string, object>());
        }

        internal partial class TriggerPipelineReferenceConverter : JsonConverter<TriggerPipelineReference>
        {
            public override void Write(Utf8JsonWriter writer, TriggerPipelineReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TriggerPipelineReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerPipelineReference(document.RootElement);
            }
        }
    }
}

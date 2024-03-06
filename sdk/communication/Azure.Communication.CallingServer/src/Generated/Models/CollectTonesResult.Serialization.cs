// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.CallingServer
{
    public partial class CollectTonesResult
    {
        internal static CollectTonesResult DeserializeCollectTonesResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DtmfTone> tones = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DtmfTone> array = new List<DtmfTone>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DtmfTone(item.GetString()));
                    }
                    tones = array;
                    continue;
                }
            }
            return new CollectTonesResult(tones ?? new ChangeTrackingList<DtmfTone>());
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    internal partial class AdditionalInfoErrorResponseError
    {
        internal static AdditionalInfoErrorResponseError DeserializeAdditionalInfoErrorResponseError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AdditionalInfoErrorResponseErrorAdditionalInfoItem> additionalInfo = default;
            string code = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdditionalInfoErrorResponseErrorAdditionalInfoItem> array = new List<AdditionalInfoErrorResponseErrorAdditionalInfoItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdditionalInfoErrorResponseErrorAdditionalInfoItem.DeserializeAdditionalInfoErrorResponseErrorAdditionalInfoItem(item));
                    }
                    additionalInfo = array;
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new AdditionalInfoErrorResponseError(additionalInfo ?? new ChangeTrackingList<AdditionalInfoErrorResponseErrorAdditionalInfoItem>(), code, message);
        }
    }
}

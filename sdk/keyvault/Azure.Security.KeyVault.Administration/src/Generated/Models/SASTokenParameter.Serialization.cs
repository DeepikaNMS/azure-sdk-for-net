// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Security.KeyVault.Administration;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class SASTokenParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageResourceUri"u8);
            writer.WriteStringValue(StorageResourceUri);
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(UseManagedIdentity))
            {
                writer.WritePropertyName("useManagedIdentity"u8);
                writer.WriteBooleanValue(UseManagedIdentity.Value);
            }
            writer.WriteEndObject();
        }
    }
}

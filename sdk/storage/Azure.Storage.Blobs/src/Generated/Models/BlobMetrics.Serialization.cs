// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;
using Azure.Storage.Blobs;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobMetrics : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "Metrics");
            if (Optional.IsDefined(Version))
            {
                writer.WriteStartElement("Version");
                writer.WriteValue(Version);
                writer.WriteEndElement();
            }
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Optional.IsDefined(IncludeApis))
            {
                writer.WriteStartElement("IncludeAPIs");
                writer.WriteValue(IncludeApis.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WriteObjectValue(RetentionPolicy, "RetentionPolicy");
            }
            writer.WriteEndElement();
        }

        internal static BlobMetrics DeserializeBlobMetrics(XElement element)
        {
            string version = default;
            bool enabled = default;
            bool? includeApis = default;
            BlobRetentionPolicy retentionPolicy = default;
            if (element.Element("Version") is XElement versionElement)
            {
                version = (string)versionElement;
            }
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("IncludeAPIs") is XElement includeAPIsElement)
            {
                includeApis = (bool?)includeAPIsElement;
            }
            if (element.Element("RetentionPolicy") is XElement retentionPolicyElement)
            {
                retentionPolicy = BlobRetentionPolicy.DeserializeBlobRetentionPolicy(retentionPolicyElement);
            }
            return new BlobMetrics(version, enabled, includeApis, retentionPolicy);
        }
    }
}

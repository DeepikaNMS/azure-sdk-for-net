// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;
using Azure.Storage.Queues;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueAccessPolicy : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "AccessPolicy");
            if (Optional.IsDefined(StartsOn))
            {
                writer.WriteStartElement("Start");
                writer.WriteValue(StartsOn.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WriteStartElement("Expiry");
                writer.WriteValue(ExpiresOn.Value, "O");
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Permissions))
            {
                writer.WriteStartElement("Permission");
                writer.WriteValue(Permissions);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static QueueAccessPolicy DeserializeQueueAccessPolicy(XElement element)
        {
            DateTimeOffset? startsOn = default;
            DateTimeOffset? expiresOn = default;
            string permissions = default;
            if (element.Element("Start") is XElement startElement)
            {
                startsOn = startElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Expiry") is XElement expiryElement)
            {
                expiresOn = expiryElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Permission") is XElement permissionElement)
            {
                permissions = (string)permissionElement;
            }
            return new QueueAccessPolicy(startsOn, expiresOn, permissions);
        }
    }
}

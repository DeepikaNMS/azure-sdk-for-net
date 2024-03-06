// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The json object containing security policy waf parameters. </summary>
    public partial class SecurityPolicyWebApplicationFirewall : SecurityPolicyProperties
    {
        /// <summary> Initializes a new instance of <see cref="SecurityPolicyWebApplicationFirewall"/>. </summary>
        public SecurityPolicyWebApplicationFirewall()
        {
            Associations = new ChangeTrackingList<SecurityPolicyWebApplicationFirewallAssociation>();
            PolicyType = SecurityPolicyType.WebApplicationFirewall;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityPolicyWebApplicationFirewall"/>. </summary>
        /// <param name="policyType"> The type of the Security policy to create. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="wafPolicy"> Resource ID. </param>
        /// <param name="associations"> Waf associations. </param>
        internal SecurityPolicyWebApplicationFirewall(SecurityPolicyType policyType, IDictionary<string, BinaryData> serializedAdditionalRawData, WritableSubResource wafPolicy, IList<SecurityPolicyWebApplicationFirewallAssociation> associations) : base(policyType, serializedAdditionalRawData)
        {
            WafPolicy = wafPolicy;
            Associations = associations;
            PolicyType = policyType;
        }

        /// <summary> Resource ID. </summary>
        internal WritableSubResource WafPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier WafPolicyId
        {
            get => WafPolicy is null ? default : WafPolicy.Id;
            set
            {
                if (WafPolicy is null)
                    WafPolicy = new WritableSubResource();
                WafPolicy.Id = value;
            }
        }

        /// <summary> Waf associations. </summary>
        public IList<SecurityPolicyWebApplicationFirewallAssociation> Associations { get; }
    }
}

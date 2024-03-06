// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the capacity reservation. Only tags and sku.capacity can be updated. </summary>
    public partial class CapacityReservationPatch : ComputeResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="CapacityReservationPatch"/>. </summary>
        public CapacityReservationPatch()
        {
            VirtualMachinesAssociated = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sku"> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </param>
        /// <param name="reservationId"> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </param>
        /// <param name="platformFaultDomainCount"> Specifies the value of fault domain count that Capacity Reservation supports for requested VM size. **Note:** The fault domain count specified for a resource (like virtual machines scale set) must be less than or equal to this value if it deploys using capacity reservation. Minimum api-version: 2022-08-01. </param>
        /// <param name="virtualMachinesAssociated"> A list of all virtual machine resource ids that are associated with the capacity reservation. </param>
        /// <param name="provisioningOn"> The date time when the capacity reservation was last updated. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The Capacity reservation instance view. </param>
        /// <param name="timeCreated"> Specifies the time at which the Capacity Reservation resource was created. Minimum api-version: 2021-11-01. </param>
        internal CapacityReservationPatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ComputeSku sku, string reservationId, int? platformFaultDomainCount, IReadOnlyList<SubResource> virtualMachinesAssociated, DateTimeOffset? provisioningOn, string provisioningState, CapacityReservationInstanceView instanceView, DateTimeOffset? timeCreated) : base(tags, serializedAdditionalRawData)
        {
            Sku = sku;
            ReservationId = reservationId;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            ProvisioningOn = provisioningOn;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TimeCreated = timeCreated;
        }

        /// <summary> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </summary>
        public string ReservationId { get; }
        /// <summary> Specifies the value of fault domain count that Capacity Reservation supports for requested VM size. **Note:** The fault domain count specified for a resource (like virtual machines scale set) must be less than or equal to this value if it deploys using capacity reservation. Minimum api-version: 2022-08-01. </summary>
        public int? PlatformFaultDomainCount { get; }
        /// <summary> A list of all virtual machine resource ids that are associated with the capacity reservation. </summary>
        public IReadOnlyList<SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The date time when the capacity reservation was last updated. </summary>
        public DateTimeOffset? ProvisioningOn { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Capacity reservation instance view. </summary>
        public CapacityReservationInstanceView InstanceView { get; }
        /// <summary> Specifies the time at which the Capacity Reservation resource was created. Minimum api-version: 2021-11-01. </summary>
        public DateTimeOffset? TimeCreated { get; }
    }
}

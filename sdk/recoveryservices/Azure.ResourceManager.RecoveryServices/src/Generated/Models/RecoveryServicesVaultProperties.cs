// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Properties of the vault. </summary>
    public partial class RecoveryServicesVaultProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultProperties"/>. </summary>
        public RecoveryServicesVaultProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<RecoveryServicesPrivateEndpointConnectionVaultProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning State. </param>
        /// <param name="upgradeDetails"> Details for upgrading vault. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection. </param>
        /// <param name="privateEndpointStateForBackup"> Private endpoint state for backup. </param>
        /// <param name="privateEndpointStateForSiteRecovery"> Private endpoint state for site recovery. </param>
        /// <param name="encryption"> Customer Managed Key details of the resource. </param>
        /// <param name="moveDetails"> The details of the latest move operation performed on the Azure Resource. </param>
        /// <param name="moveState"> The State of the Resource after the move operation. </param>
        /// <param name="backupStorageVersion"> Backup storage version. </param>
        /// <param name="publicNetworkAccess"> property to enable or disable resource provider inbound network traffic from public clients. </param>
        /// <param name="monitoringSettings"> Monitoring Settings of the vault. </param>
        /// <param name="restoreSettings"> Restore Settings of the vault. </param>
        /// <param name="redundancySettings"> The redundancy Settings of a Vault. </param>
        /// <param name="securitySettings"> Security Settings of the vault. </param>
        /// <param name="secureScore"> Secure Score of Recovery Services Vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServicesVaultProperties(string provisioningState, VaultUpgradeDetails upgradeDetails, IReadOnlyList<RecoveryServicesPrivateEndpointConnectionVaultProperties> privateEndpointConnections, VaultPrivateEndpointState? privateEndpointStateForBackup, VaultPrivateEndpointState? privateEndpointStateForSiteRecovery, VaultPropertiesEncryption encryption, VaultPropertiesMoveDetails moveDetails, ResourceMoveState? moveState, BackupStorageVersion? backupStorageVersion, VaultPublicNetworkAccess? publicNetworkAccess, VaultMonitoringSettings monitoringSettings, RestoreSettings restoreSettings, VaultPropertiesRedundancySettings redundancySettings, RecoveryServicesSecuritySettings securitySettings, SecureScoreLevel? secureScore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            UpgradeDetails = upgradeDetails;
            PrivateEndpointConnections = privateEndpointConnections;
            PrivateEndpointStateForBackup = privateEndpointStateForBackup;
            PrivateEndpointStateForSiteRecovery = privateEndpointStateForSiteRecovery;
            Encryption = encryption;
            MoveDetails = moveDetails;
            MoveState = moveState;
            BackupStorageVersion = backupStorageVersion;
            PublicNetworkAccess = publicNetworkAccess;
            MonitoringSettings = monitoringSettings;
            RestoreSettings = restoreSettings;
            RedundancySettings = redundancySettings;
            SecuritySettings = securitySettings;
            SecureScore = secureScore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning State. </summary>
        public string ProvisioningState { get; }
        /// <summary> Details for upgrading vault. </summary>
        public VaultUpgradeDetails UpgradeDetails { get; set; }
        /// <summary> List of private endpoint connection. </summary>
        public IReadOnlyList<RecoveryServicesPrivateEndpointConnectionVaultProperties> PrivateEndpointConnections { get; }
        /// <summary> Private endpoint state for backup. </summary>
        public VaultPrivateEndpointState? PrivateEndpointStateForBackup { get; }
        /// <summary> Private endpoint state for site recovery. </summary>
        public VaultPrivateEndpointState? PrivateEndpointStateForSiteRecovery { get; }
        /// <summary> Customer Managed Key details of the resource. </summary>
        public VaultPropertiesEncryption Encryption { get; set; }
        /// <summary> The details of the latest move operation performed on the Azure Resource. </summary>
        public VaultPropertiesMoveDetails MoveDetails { get; set; }
        /// <summary> The State of the Resource after the move operation. </summary>
        public ResourceMoveState? MoveState { get; }
        /// <summary> Backup storage version. </summary>
        public BackupStorageVersion? BackupStorageVersion { get; }
        /// <summary> property to enable or disable resource provider inbound network traffic from public clients. </summary>
        public VaultPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Monitoring Settings of the vault. </summary>
        public VaultMonitoringSettings MonitoringSettings { get; set; }
        /// <summary> Restore Settings of the vault. </summary>
        internal RestoreSettings RestoreSettings { get; set; }
        /// <summary> Gets or sets the cross subscription restore state. </summary>
        public CrossSubscriptionRestoreState? CrossSubscriptionRestoreState
        {
            get => RestoreSettings is null ? default : RestoreSettings.CrossSubscriptionRestoreState;
            set
            {
                if (RestoreSettings is null)
                    RestoreSettings = new RestoreSettings();
                RestoreSettings.CrossSubscriptionRestoreState = value;
            }
        }

        /// <summary> The redundancy Settings of a Vault. </summary>
        public VaultPropertiesRedundancySettings RedundancySettings { get; set; }
        /// <summary> Security Settings of the vault. </summary>
        public RecoveryServicesSecuritySettings SecuritySettings { get; set; }
        /// <summary> Secure Score of Recovery Services Vault. </summary>
        public SecureScoreLevel? SecureScore { get; }
    }
}

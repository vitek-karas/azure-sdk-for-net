// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkDiagnosticsPackage data model.
    /// Diagnostics package resource.
    /// </summary>
    public partial class MobileNetworkDiagnosticsPackageData : ResourceData
    {
        /// <summary> Initializes a new instance of MobileNetworkDiagnosticsPackageData. </summary>
        public MobileNetworkDiagnosticsPackageData()
        {
        }

        /// <summary> Initializes a new instance of MobileNetworkDiagnosticsPackageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the diagnostics package resource. </param>
        /// <param name="status"> The status of the diagnostics package collection. </param>
        /// <param name="reason"> The reason for the current state of the diagnostics package collection. </param>
        internal MobileNetworkDiagnosticsPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MobileNetworkProvisioningState? provisioningState, MobileNetworkDiagnosticsPackageStatus? status, string reason) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            Status = status;
            Reason = reason;
        }

        /// <summary> The provisioning state of the diagnostics package resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The status of the diagnostics package collection. </summary>
        public MobileNetworkDiagnosticsPackageStatus? Status { get; }
        /// <summary> The reason for the current state of the diagnostics package collection. </summary>
        public string Reason { get; }
    }
}

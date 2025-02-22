// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Service Endpoint policy definition resource.</summary>
    public partial class ServiceEndpointPolicyDefinitionPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IServiceEndpointPolicyDefinitionPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IServiceEndpointPolicyDefinitionPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IServiceEndpointPolicyDefinitionPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private string _service;

        /// <summary>Service endpoint name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Service { get => this._service; set => this._service = value; }

        /// <summary>Backing field for <see cref="ServiceResource" /> property.</summary>
        private string[] _serviceResource;

        /// <summary>A list of service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] ServiceResource { get => this._serviceResource; set => this._serviceResource = value; }

        /// <summary>
        /// Creates an new <see cref="ServiceEndpointPolicyDefinitionPropertiesFormat" /> instance.
        /// </summary>
        public ServiceEndpointPolicyDefinitionPropertiesFormat()
        {

        }
    }
    /// Service Endpoint policy definition resource.
    public partial interface IServiceEndpointPolicyDefinitionPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for this rule. Restricted to 140 chars.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the service endpoint policy definition resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Service endpoint name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service endpoint name.",
        SerializedName = @"service",
        PossibleTypes = new [] { typeof(string) })]
        string Service { get; set; }
        /// <summary>A list of service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of service resources.",
        SerializedName = @"serviceResources",
        PossibleTypes = new [] { typeof(string) })]
        string[] ServiceResource { get; set; }

    }
    /// Service Endpoint policy definition resource.
    internal partial interface IServiceEndpointPolicyDefinitionPropertiesFormatInternal

    {
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        string Description { get; set; }
        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Service endpoint name.</summary>
        string Service { get; set; }
        /// <summary>A list of service resources.</summary>
        string[] ServiceResource { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>Represents the properties of the Dns Resource Reference Request.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class DnsResourceReferenceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.DnsResourceReferenceRequestProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestProperties _property;

        /// <summary>The properties of the Resource Reference Request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.DnsResourceReferenceRequestProperties()); set => this._property = value; }

        /// <summary>
        /// A list of references to azure resources for which referencing dns records need to be queried.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource[] TargetResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestPropertiesInternal)Property).TargetResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestPropertiesInternal)Property).TargetResource = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="DnsResourceReferenceRequest" /> instance.</summary>
        public DnsResourceReferenceRequest()
        {

        }
    }
    /// Represents the properties of the Dns Resource Reference Request.
    public partial interface IDnsResourceReferenceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list of references to azure resources for which referencing dns records need to be queried.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of references to azure resources for which referencing dns records need to be queried.",
        SerializedName = @"targetResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource[] TargetResource { get; set; }

    }
    /// Represents the properties of the Dns Resource Reference Request.
    internal partial interface IDnsResourceReferenceRequestInternal

    {
        /// <summary>The properties of the Resource Reference Request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceRequestProperties Property { get; set; }
        /// <summary>
        /// A list of references to azure resources for which referencing dns records need to be queried.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ISubResource[] TargetResource { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Details about the connection between the Batch service and the endpoint.</summary>
    public partial class EndpointDetail :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDetail,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDetailInternal
    {

        /// <summary>Internal Acessors for Port</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDetailInternal.Port { get => this._port; set { {_port = value;} } }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>The port an endpoint is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public int? Port { get => this._port; }

        /// <summary>Creates an new <see cref="EndpointDetail" /> instance.</summary>
        public EndpointDetail()
        {

        }
    }
    /// Details about the connection between the Batch service and the endpoint.
    public partial interface IEndpointDetail :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>The port an endpoint is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The port an endpoint is connected to.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get;  }

    }
    /// Details about the connection between the Batch service and the endpoint.
    internal partial interface IEndpointDetailInternal

    {
        /// <summary>The port an endpoint is connected to.</summary>
        int? Port { get; set; }

    }
}
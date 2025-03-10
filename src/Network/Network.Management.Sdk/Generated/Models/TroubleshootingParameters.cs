// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters that define the resource to troubleshoot.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class TroubleshootingParameters
    {
        /// <summary>
        /// Initializes a new instance of the TroubleshootingParameters class.
        /// </summary>
        public TroubleshootingParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TroubleshootingParameters class.
        /// </summary>

        /// <param name="targetResourceId">The target resource to troubleshoot.
        /// </param>

        /// <param name="storageId">The ID for the storage account to save the troubleshoot result.
        /// </param>

        /// <param name="storagePath">The path to the blob to save the troubleshoot result in.
        /// </param>
        public TroubleshootingParameters(string targetResourceId, string storageId, string storagePath)

        {
            this.TargetResourceId = targetResourceId;
            this.StorageId = storageId;
            this.StoragePath = storagePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the target resource to troubleshoot.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId {get; set; }

        /// <summary>
        /// Gets or sets the ID for the storage account to save the troubleshoot
        /// result.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageId")]
        public string StorageId {get; set; }

        /// <summary>
        /// Gets or sets the path to the blob to save the troubleshoot result in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storagePath")]
        public string StoragePath {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TargetResourceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (this.StorageId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StorageId");
            }
            if (this.StoragePath == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StoragePath");
            }



        }
    }
}
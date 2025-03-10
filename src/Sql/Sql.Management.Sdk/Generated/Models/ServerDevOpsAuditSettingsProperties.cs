// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a server DevOps audit settings.
    /// </summary>
    public partial class ServerDevOpsAuditSettingsProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServerDevOpsAuditSettingsProperties class.
        /// </summary>
        public ServerDevOpsAuditSettingsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerDevOpsAuditSettingsProperties class.
        /// </summary>

        /// <param name="isAzureMonitorTargetEnabled">Specifies whether DevOps audit events are sent to Azure Monitor.
        /// In order to send the events to Azure Monitor, specify &#39;State&#39; as &#39;Enabled&#39;
        /// and &#39;IsAzureMonitorTargetEnabled&#39; as true.
        /// When using REST API to configure DevOps audit, Diagnostic Settings with
        /// &#39;DevOpsOperationsAudit&#39; diagnostic logs category on the master database
        /// should be also created.
        /// Diagnostic Settings URI format:
        /// PUT
        /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/master/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
        /// For more information, see [Diagnostic Settings REST
        /// API](https://go.microsoft.com/fwlink/?linkid=2033207)
        /// or [Diagnostic Settings
        /// PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
        /// </param>

        /// <param name="isManagedIdentityInUse">Specifies whether Managed Identity is used to access blob storage
        /// </param>

        /// <param name="state">Specifies the state of the audit. If state is Enabled, storageEndpoint or
        /// isAzureMonitorTargetEnabled are required.
        /// Possible values include: 'Enabled', 'Disabled'</param>

        /// <param name="storageEndpoint">Specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net). If state is Enabled,
        /// storageEndpoint or isAzureMonitorTargetEnabled is required.
        /// </param>

        /// <param name="storageAccountAccessKey">Specifies the identifier key of the auditing storage account.
        /// If state is Enabled and storageEndpoint is specified, not specifying the
        /// storageAccountAccessKey will use SQL server system-assigned managed
        /// identity to access the storage.
        /// Prerequisites for using managed identity authentication:
        /// 1. Assign SQL Server a system-assigned managed identity in Azure Active
        /// Directory (AAD).
        /// 2. Grant SQL Server identity access to the storage account by adding
        /// &#39;Storage Blob Data Contributor&#39; RBAC role to the server identity.
        /// For more information, see [Auditing to storage using Managed Identity
        /// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
        /// </param>

        /// <param name="storageAccountSubscriptionId">Specifies the blob storage subscription Id.
        /// </param>
        public ServerDevOpsAuditSettingsProperties(BlobAuditingPolicyState state, bool? isAzureMonitorTargetEnabled = default(bool?), bool? isManagedIdentityInUse = default(bool?), string storageEndpoint = default(string), string storageAccountAccessKey = default(string), System.Guid? storageAccountSubscriptionId = default(System.Guid?))

        {
            this.IsAzureMonitorTargetEnabled = isAzureMonitorTargetEnabled;
            this.IsManagedIdentityInUse = isManagedIdentityInUse;
            this.State = state;
            this.StorageEndpoint = storageEndpoint;
            this.StorageAccountAccessKey = storageAccountAccessKey;
            this.StorageAccountSubscriptionId = storageAccountSubscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies whether DevOps audit events are sent to Azure
        /// Monitor.
        /// In order to send the events to Azure Monitor, specify &#39;State&#39; as &#39;Enabled&#39;
        /// and &#39;IsAzureMonitorTargetEnabled&#39; as true.
        /// When using REST API to configure DevOps audit, Diagnostic Settings with
        /// &#39;DevOpsOperationsAudit&#39; diagnostic logs category on the master database
        /// should be also created.
        /// Diagnostic Settings URI format:
        /// PUT
        /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/master/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
        /// For more information, see [Diagnostic Settings REST
        /// API](https://go.microsoft.com/fwlink/?linkid=2033207)
        /// or [Diagnostic Settings
        /// PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isAzureMonitorTargetEnabled")]
        public bool? IsAzureMonitorTargetEnabled {get; set; }

        /// <summary>
        /// Gets or sets specifies whether Managed Identity is used to access blob
        /// storage
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isManagedIdentityInUse")]
        public bool? IsManagedIdentityInUse {get; set; }

        /// <summary>
        /// Gets or sets specifies the state of the audit. If state is Enabled,
        /// storageEndpoint or isAzureMonitorTargetEnabled are required. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public BlobAuditingPolicyState State {get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net). If state is Enabled,
        /// storageEndpoint or isAzureMonitorTargetEnabled is required.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageEndpoint")]
        public string StorageEndpoint {get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier key of the auditing storage account.
        /// If state is Enabled and storageEndpoint is specified, not specifying the
        /// storageAccountAccessKey will use SQL server system-assigned managed
        /// identity to access the storage.
        /// Prerequisites for using managed identity authentication:
        /// 1. Assign SQL Server a system-assigned managed identity in Azure Active
        /// Directory (AAD).
        /// 2. Grant SQL Server identity access to the storage account by adding
        /// &#39;Storage Blob Data Contributor&#39; RBAC role to the server identity.
        /// For more information, see [Auditing to storage using Managed Identity
        /// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountAccessKey")]
        public string StorageAccountAccessKey {get; set; }

        /// <summary>
        /// Gets or sets specifies the blob storage subscription Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountSubscriptionId")]
        public System.Guid? StorageAccountSubscriptionId {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {



        }
    }
}
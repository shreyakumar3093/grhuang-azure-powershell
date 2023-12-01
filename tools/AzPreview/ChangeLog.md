## 11.1.0 - May 2024
#### Az.Compute 7.1.0
* Added new parameter '-ElasticSanResourceId' to 'New-AzSnapshotConfig' cmdlet.
* Added new parameter '-OptimizedForFrequentAttach' to 'New-AzDiskConfig' cmdlet.
* Added new examples in 'New-AzVM' and 'New-AzVmss' for TrustedLaunch default usage.
* Fixed the 'New-AzVM' bug to avoid accessing the 'EncryptionAtHost' property for subscriptions who cannot access it since it is behind a feature flag.
* Updated 'Get-AzVmExtension' to return instanceView when used with '-Status'.
* Reverted SSH Private Key File permission changes in 'New-AzVm'.

#### Az.ConnectedVMware 0.1.0
* First preview release for module Az.ConnectedVMware

#### Az.DataFactory 1.18.0
* Supported GoogleAds and LakeHouse in ADF
* Supported copyComputeScale and pipelineExternalComputeScale in 'Set-AzDataFactoryV2IntegrationRuntime' Command

#### Az.KeyVault 5.0.1
* Removed redundant Microsoft Graph API calls for access policy in 'Get-AzKeyVault'.

#### Az.ManagedServiceIdentity 1.2.0
* Renamed '*-AzFederatedIdentityCredentials' to '*-AzFederatedIdentityCredential', and kept '*-AzFederatedIdentityCredentials' as an alias.

#### Az.Network 7.1.0
* Added DefaultOutboundAccess parameter on subnet creation
* Updated cmdlet 'New-AzPublicIpPrefix' and 'New-PublicIpAddress' to require Location parameter
* Updated cmdlet 'New-AzLoadBalancerBackendAddressPool' to support managed IP based backend
* Added cmdlet 'New-AzSaaSNetworkVirtualAppliance' for creating a NetworkVirtualAppliance of SaaS type.
* Added control knobs to virtual network gateways and ExpressRoute gateways as well to cmdlets operating on those.
* Updated cmdlets to add Hostnames property for Application gateway Listener Configuration
	- 'Set-AzApplicationGatewayListener'
	- 'Add-AzApplicationGatewayListener'
	- 'New-AzApplicationGatewayListener'
* Added cmdlet 'Remove-AzApplicationGatewayFirewallCustomRule' to support removing custom rule in Firewall Policy.
* Added support for new ErGWScale SKU - ErGwScale
* Added property 'size' to firewallPolicy and firewallPolicyRuleCollectionGroup.
* Updated cmdlet 'New-AzBastion', 'Set-AzBastion' and 'Get-AzBastion' to support Bastion features for CRUD operations

#### Az.Quota 0.1.1
* Upgraded api version to 2023-02-01 stable.

#### Az.Resources 6.12.1
* Used utf8 encoding for reading stdout & stderr when invoking Bicep. [#23246]
* Fixed regression in 'Publish-AzBicepModule' [Azure/bicep/12461](https://github.com/Azure/bicep/issues/12461)

#### Az.Security 1.5.1
* Fixed bug for 'Set-AzSecurityPricing'

#### Az.ServiceFabric 3.3.1
* Fixed a bug that Get commands do not return all resources.
* Updated sfmc to latest api preview version '2023-11-01-preview'.

#### Az.Sql 4.12.0
* Added new parameters 'MaintenanceConfigurationId', 'DnsZone' to 'AzSqlInstancePool' cmdlets

#### Az.StackHCIVM 0.1.0
* First preview release for module Az.StackHCIVM

#### Az.Storage 6.0.1
* Updated error message when storage context is missing in a cmdlet input 


# PidginHost.Sdk.Model.GatewayFirewallRule
A firewall rule (spec 5.7): first match wins in position order; a change is pending until applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Position** | **int** |  | [readonly] 
**Action** | **FwPolicyOutEnum** |  | [readonly] 
**Source** | [**GatewayFirewallSource**](GatewayFirewallSource.md) |  | [readonly] 
**Destination** | [**GatewayFirewallDestination**](GatewayFirewallDestination.md) |  | [readonly] 
**Protocol** | **GatewayFirewallProtocolEnum** |  | [readonly] 
**Ports** | [**List&lt;GatewayPortRange&gt;**](GatewayPortRange.md) |  | [readonly] 
**Enabled** | **bool** |  | [readonly] 
**Comment** | **string** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


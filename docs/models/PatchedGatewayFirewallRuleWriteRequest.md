# PidginHost.Sdk.Model.PatchedGatewayFirewallRuleWriteRequest
The fields a customer writes; gateway.firewall.clean_rule decides what they may hold.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **FwPolicyOutEnum** |  | [optional] 
**Source** | [**GatewayFirewallSourceRequest**](GatewayFirewallSourceRequest.md) |  | [optional] 
**Destination** | [**GatewayFirewallDestinationRequest**](GatewayFirewallDestinationRequest.md) |  | [optional] 
**Protocol** | **GatewayFirewallProtocolEnum** |  | [optional] 
**Ports** | [**List&lt;GatewayPortRangeRequest&gt;**](GatewayPortRangeRequest.md) |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**Comment** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


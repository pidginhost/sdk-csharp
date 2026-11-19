# PidginHost.Sdk.Model.LBFirewallRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Created** | **string** |  | [readonly] 
**Updated** | **string** |  | [readonly] 
**Direction** | **LBFirewallRuleDirectionEnum** |  | [optional] 
**Action** | **LBFirewallRuleActionEnum** |  | [optional] 
**Protocol** | **string** | tcp, udp, icmp, etc. | [optional] 
**Source** | **string** | IP address or CIDR | [optional] 
**Sport** | **string** | Port or range (e.g., 1024-65535) | [optional] 
**Destination** | **string** | IP address or CIDR | [optional] 
**Dport** | **string** | Port or range (e.g., 80, 8000-9000) | [optional] 
**Comment** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**Position** | **int** | Rule order (lower &#x3D; higher priority) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


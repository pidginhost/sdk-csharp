# PidginHost.Sdk.Model.FirewallRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **FirewallRuleDirectionEnum** |  | 
**Action** | **FwPolicyOutEnum** |  | 
**Protocol** | **string** |  | [optional] 
**Source** | **string** | single IP, range (20.34.101.207-201.3.9.99) or comma separated list | [optional] 
**Sport** | **string** | numbers (0-65535), range (\&quot;\\d+:\\d+\&quot;, like \&quot;80:85\&quot;), comma separated list | [optional] 
**Destination** | **string** | single IP, range (20.34.101.207-201.3.9.99) or comma separated list | [optional] 
**Dport** | **string** | numbers (0-65535), range (\&quot;\\d+:\\d+\&quot;, like \&quot;80:85\&quot;), comma separated list | [optional] 
**Enabled** | **bool** |  | [optional] 
**Position** | **int** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


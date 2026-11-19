# PidginHost.Sdk.Model.GatewayNetwork
One network the gateway is attached to (spec 5.3). A change is pending until the agent applies its revision (spec 11.2); a failure shows a reason, never its text. The NIC's MAC stays internal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **int** |  | [readonly] 
**Role** | **GatewayNetworkRoleEnum** |  | [readonly] 
**Snat** | **bool** |  | [readonly] 
**State** | **GatewayNetworkStateEnum** |  | [readonly] 
**Slot** | **int** |  | [readonly] 
**Address** | **string** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 
**Reason** | **string** | Why the last network change failed, or empty. | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


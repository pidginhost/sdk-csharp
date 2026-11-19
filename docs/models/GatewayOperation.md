# PidginHost.Sdk.Model.GatewayOperation
An operation's progress (spec 5.11). A route apply's per-server evidence (node, QEMU process, guest boot, config) stays internal: each server shows its status. Error text is never published, as it can be a Proxmox exception's text, which names nodes: a failure shows a reason from the fixed vocabulary in gateway.reasons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Kind** | **GatewayOperationKindEnum** |  | [readonly] 
**Status** | **GatewayOperationStatusEnum** |  | [readonly] 
**StartedAt** | **string** |  | [readonly] 
**Servers** | **List&lt;int&gt;** |  | [readonly] 
**Outcomes** | [**Dictionary&lt;string, GatewayRouteOutcome&gt;**](GatewayRouteOutcome.md) |  | [readonly] 
**Reason** | **string** | Why the operation failed; empty unless it did. | [readonly] 
**Network** | **int** |  | [readonly] 
**Revision** | **int** |  | [readonly] 
**DeadlineAt** | **string** |  | [readonly] 
**CompletedAt** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


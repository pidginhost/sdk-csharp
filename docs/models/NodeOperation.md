# PidginHost.Sdk.Model.NodeOperation
What a customer may see about their own node operation.  The omissions are the point. Private address, Node UID, VMID, Proxmox placement, and every request/task/lease field stay on the staff serializer: they name internal topology, and a status endpoint is not where that becomes public.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Kind** | **NodeOperationKindEnum** |  | [readonly] 
**Source** | **NodeOperationSourceEnum** |  | [readonly] 
**TargetHostname** | **string** |  | [readonly] 
**Status** | **NodeOperationStatusEnum** |  | [readonly] 
**Reason** | **string** |  | [readonly] 
**Message** | **string** |  | [readonly] 
**BypassPdb** | **bool** |  | [readonly] 
**DeleteUnmanagedPods** | **bool** |  | [readonly] 
**LocalDataLossAccepted** | **bool** |  | [readonly] 
**ActorLabel** | **string** | Who requested the operation (user email or staff name). Never token material. | [readonly] 
**CreatedAt** | **string** |  | [readonly] 
**UpdatedAt** | **string** |  | [readonly] 
**AllowedActions** | **List&lt;string&gt;** |  | [readonly] 
**BypassPdbConfirmedAt** | **string** |  | [readonly] 
**UnmanagedPodsConfirmedAt** | **string** |  | [readonly] 
**FinishedAt** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


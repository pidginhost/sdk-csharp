# PidginHost.Sdk.Model.NodeOperationRetryRequest
The two independent overrides, and the acknowledgement each one needs.  Both flags are tri-state and the third state is what matters: `null`/absent means \"leave it as it is\". A plain boolean default would turn every request that names one flag into a request that silently un-forces the other, and `retry_node_operation` refuses an un-force rather than applying it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BypassPdb** | **bool** |  | [optional] 
**DeleteUnmanagedPods** | **bool** |  | [optional] 
**AcknowledgePdbBypass** | **bool** |  | [optional] [default to false]
**AcknowledgeUnmanagedPodDeletion** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


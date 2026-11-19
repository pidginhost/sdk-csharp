# PidginHost.Sdk.Model.GatewayLBListener
A load balancer listener (spec 6.8): one public port with a mode; pending until applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Protocol** | **GatewayForwardProtocolEnum** |  | [readonly] 
**Port** | **int** |  | 
**Mode** | **GatewayLBListenerModeEnum** |  | 
**AllowedSources** | **List&lt;string&gt;** | Empty means any source. | 
**Enabled** | **bool** |  | [readonly] 
**Comment** | **string** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 
**Pool** | **int** | The backend pool of a tcp or udp listener; null for http. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


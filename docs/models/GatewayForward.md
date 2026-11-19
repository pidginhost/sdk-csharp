# PidginHost.Sdk.Model.GatewayForward
A port forward (spec 6.7): public ports to one host of an attached network; pending until applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Protocol** | **GatewayForwardProtocolEnum** |  | [readonly] 
**PublicPorts** | [**GatewayPortRange**](GatewayPortRange.md) |  | [readonly] 
**Target** | [**GatewayForwardTarget**](GatewayForwardTarget.md) |  | [readonly] 
**PreserveClientIp** | **bool** | Always false: the target sees the gateway&#39;s address. | [readonly] 
**Enabled** | **bool** |  | [readonly] 
**Comment** | **string** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 
**AllowedSources** | **Object** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


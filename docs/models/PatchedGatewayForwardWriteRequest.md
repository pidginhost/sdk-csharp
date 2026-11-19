# PidginHost.Sdk.Model.PatchedGatewayForwardWriteRequest
The fields a customer writes; gateway.forwards.clean_forward decides what they may hold.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **GatewayForwardProtocolEnum** |  | [optional] 
**PublicPorts** | [**GatewayPortRangeRequest**](GatewayPortRangeRequest.md) |  | [optional] 
**Target** | [**GatewayForwardTargetRequest**](GatewayForwardTargetRequest.md) |  | [optional] 
**AllowedSources** | **List&lt;string&gt;** | IPv4 networks; empty means any source. | [optional] 
**PreserveClientIp** | **bool** | Only false is accepted for now. | [optional] 
**Enabled** | **bool** |  | [optional] 
**Comment** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


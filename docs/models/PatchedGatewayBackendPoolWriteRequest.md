# PidginHost.Sdk.Model.PatchedGatewayBackendPoolWriteRequest
The fields a customer writes; gateway.backend_pools.clean_pool decides what they may hold.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Policy** | **GatewayBackendPoolPolicyEnum** |  | [optional] 
**ProxyProtocol** | **bool** | PROXY protocol v2 to the servers; tcp only. | [optional] 
**HealthCheck** | [**GatewayHealthCheckWriteRequest**](GatewayHealthCheckWriteRequest.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


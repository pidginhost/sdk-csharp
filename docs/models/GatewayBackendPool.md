# PidginHost.Sdk.Model.GatewayBackendPool
A backend pool (spec 5.5): the servers a listener or route sends to; pending until applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | [readonly] 
**Policy** | **GatewayBackendPoolPolicyEnum** |  | [readonly] 
**ProxyProtocol** | **bool** |  | [readonly] 
**HealthCheck** | [**GatewayHealthCheck**](GatewayHealthCheck.md) |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


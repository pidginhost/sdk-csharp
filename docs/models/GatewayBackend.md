# PidginHost.Sdk.Model.GatewayBackend
A pool's server (spec 5.5) with its health as the gateway last reported it (spec 6.8).  The view passes the health map in the context, read once per request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Network** | **int** | An attached private network&#39;s id. | 
**Address** | **string** |  | [readonly] 
**Port** | **int** |  | [readonly] 
**Weight** | **int** |  | [readonly] 
**Enabled** | **bool** |  | [readonly] 
**Health** | **GatewayBackendHealthEnum** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 
**HealthChanged** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


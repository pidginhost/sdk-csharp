# PidginHost.Sdk.Model.PatchedTCPRouteRequest
Serializer for TCPRoute resources with port validation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Namespace** | **string** |  | [optional] 
**Port** | **int** | External port to expose (blocked: 22, 6443, 50000, 50001) | [optional] 
**BackendServiceName** | **string** | Name of the backend Kubernetes Service | [optional] 
**BackendServicePort** | **int** | Port of the backend Service | [optional] 
**BackendNamespace** | **string** | Namespace of the backend Service | [optional] [default to "default"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


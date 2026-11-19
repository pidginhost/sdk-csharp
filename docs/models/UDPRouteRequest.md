# PidginHost.Sdk.Model.UDPRouteRequest
Serializer for UDPRoute resources with port validation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Port** | **int** | External port to expose | 
**BackendServiceName** | **string** | Name of the backend Kubernetes Service | 
**BackendServicePort** | **int** | Port of the backend Service | 
**Namespace** | **string** |  | [optional] 
**BackendNamespace** | **string** | Namespace of the backend Service | [optional] [default to "default"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


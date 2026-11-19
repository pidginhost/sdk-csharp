# PidginHost.Sdk.Model.UDPRoute
Serializer for UDPRoute resources with port validation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | 
**Port** | **int** | External port to expose | 
**BackendServiceName** | **string** | Name of the backend Kubernetes Service | 
**BackendServicePort** | **int** | Port of the backend Service | 
**StatusMessage** | **string** |  | [readonly] 
**Created** | **string** |  | [readonly] 
**Updated** | **string** |  | [readonly] 
**Namespace** | **string** |  | [optional] 
**BackendNamespace** | **string** | Namespace of the backend Service | [optional] [default to "default"]
**StatusReady** | **bool** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


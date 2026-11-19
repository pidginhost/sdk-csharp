# PidginHost.Sdk.Model.PatchedHTTPRouteRequest
Serializer for HTTPRoute resources with automatic certificate issuance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Namespace** | **string** |  | [optional] 
**Hostnames** | **List&lt;string&gt;** | List of hostnames to route (e.g., [\&quot;example.com\&quot;, \&quot;www.example.com\&quot;]) | [optional] 
**BackendServiceName** | **string** | Name of the backend Kubernetes Service | [optional] 
**BackendServicePort** | **int** | Port of the backend Service | [optional] 
**BackendNamespace** | **string** | Namespace of the backend Service | [optional] [default to "default"]
**PathPrefix** | **string** | Path prefix to match (default: /) | [optional] [default to "/"]
**EnableTls** | **bool** | Enable TLS termination with automatic certificate issuance | [optional] [default to true]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PidginHost.Sdk.Model.GatewayRoute
An http listener's route (spec 5.6): a host and path prefix to a backend pool; pending until applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Hostnames** | **List&lt;string&gt;** | Empty matches every host. | 
**PathPrefix** | **string** |  | [readonly] 
**Pool** | **int** |  | 
**RedirectHttps** | **bool** | Always false: HTTPS redirects are not available yet. | [readonly] 
**Enabled** | **bool** |  | [readonly] 
**ChangedRevision** | **int** |  | [readonly] 
**Pending** | **bool** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


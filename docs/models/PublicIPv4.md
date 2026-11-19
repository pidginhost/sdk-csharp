# PidginHost.Sdk.Model.PublicIPv4

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Slug** | **string** |  | [readonly] 
**Address** | **string** |  | [readonly] 
**Gateway** | **string** |  | [readonly] 
**Prefix** | **int** |  | [readonly] 
**Attached** | **bool** |  | [readonly] 
**Server** | **string** | Hostname of the server this address is attached to. Empty when it is not attached. | [readonly] 
**ServerId** | **int** | ID of the attached server, as used by /api/cloud/servers/{id}/. Null when the address is not attached to a cloud server. | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PidginHost.Sdk.Model.PatchedGatewayRouteWriteRequest
The fields a customer writes; gateway.lb_routes.clean_route decides what they may hold.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostnames** | **List&lt;string&gt;** | Up to 16 names; empty matches every host. | [optional] 
**PathPrefix** | **string** | Literal and case-sensitive. | [optional] 
**Pool** | **int** | A backend pool&#39;s id. | [optional] 
**RedirectHttps** | **bool** | Only false is accepted for now. | [optional] 
**Enabled** | **bool** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


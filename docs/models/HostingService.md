# PidginHost.Sdk.Model.HostingService
Read-only serializer for shared/cPanel hosting services.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Hostname** | **string** |  | [readonly] 
**Status** | **ServiceStatusEnum** |  | [readonly] 
**Price** | **string** | Euro without TVA | [readonly] 
**NextInvoice** | **DateOnly** |  | [readonly] 
**Created** | **string** |  | [readonly] 
**BillingCycle** | **string** |  | [readonly] 
**Billing** | [**ResourceBilling**](ResourceBilling.md) |  | [readonly] 
**PackageName** | **string** |  | [readonly] 
**NodeUrl** | **string** |  | [readonly] 
**Username** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


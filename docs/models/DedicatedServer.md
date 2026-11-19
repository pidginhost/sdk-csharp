# PidginHost.Sdk.Model.DedicatedServer
Read-only serializer for dedicated server services.

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
**Ips** | [**List&lt;DedicatedServerIP&gt;**](DedicatedServerIP.md) |  | [readonly] 
**Billing** | [**ResourceBilling**](ResourceBilling.md) |  | [readonly] 
**ServerStatus** | [**DedicatedServerStatus**](DedicatedServerStatus.md) |  | [readonly] 
**OsName** | **string** |  | [readonly] 
**Hardware** | [**DedicatedHardware**](DedicatedHardware.md) |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


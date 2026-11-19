# PidginHost.Sdk.Model.Server

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Image** | **string** |  | [readonly] 
**Package** | **string** |  | [readonly] 
**Cpus** | **int** |  | [readonly] 
**Memory** | **int** |  | [readonly] 
**DiskSize** | **int** |  | [readonly] 
**Generation** | **string** |  | [readonly] 
**DestroyProtection** | **bool** | Prevents the server from being destroyed until disabled. | [readonly] 
**HaEnabled** | **bool** | Enables Proxmox HA — automatic restart and migration on node failure. | [readonly] 
**CustomOs** | **bool** | Customer installed their own OS from an ISO; cloud-init features no longer apply | [readonly] 
**Networks** | [**ServerNetworks**](ServerNetworks.md) |  | [readonly] 
**RescueMode** | **bool** |  | [readonly] 
**RescueSupported** | **bool** |  | [readonly] 
**Billing** | [**ResourceBilling**](ResourceBilling.md) |  | [readonly] 
**Hostname** | **string** |  | [optional] 
**Project** | **string** |  | [optional] 
**Status** | **ResourceStatusEnum** |  | [optional] 
**BootIso** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# PidginHost.Sdk.Model.ServerDetail

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
**Machine** | **Dictionary&lt;string, Object&gt;** |  | [readonly] 
**Volumes** | [**List&lt;Volume&gt;**](Volume.md) |  | [readonly] 
**Networks** | [**ServerNetworks**](ServerNetworks.md) |  | [readonly] 
**FloatingIps** | [**List&lt;FloatingIPSummary&gt;**](FloatingIPSummary.md) |  | [readonly] 
**Status** | **ResourceStatusEnum** |  | [readonly] 
**Username** | **string** |  | [readonly] 
**DestroyProtection** | **bool** | Prevents the server from being destroyed until disabled. | [readonly] 
**HaEnabled** | **bool** | Enables Proxmox HA — automatic restart and migration on node failure. | [readonly] 
**CustomOs** | **bool** | Customer installed their own OS from an ISO; cloud-init features no longer apply | [readonly] 
**RescueMode** | **bool** |  | [readonly] 
**RescueSupported** | **bool** |  | [readonly] 
**Billing** | [**ResourceBilling**](ResourceBilling.md) |  | [readonly] 
**Hostname** | **string** | Renaming also moves reverse DNS still on the old name. The server takes the new name at its next reboot from the panel or API, which also creates new SSH host keys and resets the login password and SSH keys to the ones saved here. | [optional] 
**Project** | **string** |  | [optional] 
**SshPubKey** | **string** | Public key to apply for SSH login. Applying a non-empty key regenerates cloud-init and reboots a running server. Clearing removes the key from future cloud-init data, but does not revoke keys already in the guest. | [optional] 
**BootIso** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


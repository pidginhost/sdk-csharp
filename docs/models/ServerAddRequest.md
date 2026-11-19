# PidginHost.Sdk.Model.ServerAddRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Image** | **string** | ID or slug | 
**Package** | **string** | ID or slug | 
**Hostname** | **string** |  | [optional] 
**Project** | **string** |  | [optional] 
**Password** | **string** |  | [optional] 
**SshPubKey** | **string** | New SSH key | [optional] 
**SshPubKeyId** | **string** | ID or fingerprint | [optional] 
**UserData** | **string** | Optional startup script. Must be an executable script with a shebang. Stored in cleartext. | [optional] 
**PublicIp** | **string** | ID or address of an IPv4 you already own. Aliases accepted: ipv4, public_ipv4. | [optional] 
**NewIpv4** | **bool** | Allocate a new IPv4 and attach it before first boot, so the server boots reachable. | [optional] 
**PublicIpv6** | **string** | ID or address of an IPv6 you already own. Alias accepted: ipv6. | [optional] 
**NewIpv6** | **bool** | Allocate a new IPv6 and attach it before first boot. | [optional] 
**FwRulesSet** | **string** | ID or slug | [optional] 
**FwPolicyIn** | **FwPolicyOutEnum** |  | [optional] 
**FwPolicyOut** | **FwPolicyOutEnum** |  | [optional] 
**PrivateNetwork** | **string** | ID or slug | [optional] 
**PrivateAddress** | **string** | Leave empty for auto-assign | [optional] 
**ExtraVolumeProduct** | **string** | ID or slug | [optional] 
**ExtraVolumeSize** | **int** |  | [optional] [default to 0]
**NoNetworkAcknowledged** | **bool** |  | [optional] 
**EnableHa** | **bool** |  | [optional] [default to false]
**Generation** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


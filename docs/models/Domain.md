# PidginHost.Sdk.Model.Domain

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**VarDomain** | **string** |  | [readonly] 
**Tld** | [**TLD**](TLD.md) |  | [readonly] 
**Idna** | **bool** | Domain name is encoded with IDN | [readonly] 
**ExpirationDate** | **DateOnly** |  | [readonly] 
**IdnaName** | **string** |  | [readonly] 
**MaxRenewYears** | **int** |  | [readonly] 
**Nameservers** | **string** | List of 2-5 name-servers separated by comma. | [optional] 
**RegistrationDate** | **DateOnly** |  | [readonly] 
**Service** | [**Service**](Service.md) |  | [readonly] 
**ServiceStatus** | **string** | Service status | [readonly] 
**Contacts** | **Object** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


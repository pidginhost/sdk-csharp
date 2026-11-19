# PidginHost.Sdk.Model.ClusterDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Status** | **ResourceStatusEnum** |  | [readonly] 
**Generation** | **string** |  | [readonly] 
**PricePerMonth** | **string** |  | [readonly] 
**PricePerHour** | **double** |  | [readonly] 
**FeaturesReady** | **bool** |  | [readonly] 
**DualStack** | **bool** |  | [readonly] 
**TalosUpgradeAvailable** | **bool** |  | [readonly] 
**Name** | **string** |  | [optional] 
**ClusterType** | **string** |  | [readonly] 
**KubeVersion** | **string** |  | [readonly] 
**Features** | [**List&lt;FeaturesEnum&gt;**](FeaturesEnum.md) |  | [optional] 
**KubeconfigValidUntil** | **string** |  | [readonly] 
**Ipv4Address** | **string** |  | [readonly] 
**Ipv6Address** | **string** |  | [readonly] 
**Protected** | **bool** |  | [optional] 
**TalosVersion** | **string** |  | [readonly] 
**TalosNextVersion** | **string** |  | [readonly] 
**StorageQuotaGb** | **int** |  | [readonly] 
**LastPoolUsedBytes** | **long** |  | [readonly] 
**LastStorageSyncAt** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


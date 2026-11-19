# PidginHost.Sdk.Model.ClusterAddRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterType** | **ClusterTypeEnum** |  | 
**ResourcePoolPackage** | **string** | ID or slug | 
**Name** | **string** |  | [optional] 
**ResourcePoolSize** | **int** |  | [optional] 
**KubeVersion** | **KubeVersionEnum** |  | [optional] 
**Features** | [**List&lt;FeaturesEnum&gt;**](FeaturesEnum.md) |  | [optional] 
**EnableGatewayApi** | **bool** |  | [optional] 
**DualStack** | **bool** | Enable IPv6 dual-stack for pods, services, and the cluster private network. Available only when the platform has K8S_DUAL_STACK_ENABLED. Cannot be changed after provisioning. | [optional] [default to false]
**Generation** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


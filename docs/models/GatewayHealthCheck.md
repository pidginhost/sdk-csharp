# PidginHost.Sdk.Model.GatewayHealthCheck
A pool's health check (spec 5.5); the fields its type does not have are null.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **GatewayHealthCheckTypeEnum** |  | 
**Path** | **string** |  | 
**StatusMin** | **int** |  | 
**StatusMax** | **int** |  | 
**IntervalS** | **int** |  | 
**TimeoutS** | **int** |  | 
**HealthyThreshold** | **int** |  | 
**UnhealthyThreshold** | **int** |  | 
**Port** | **int** | Null checks each server&#39;s own port. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


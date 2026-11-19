# PidginHost.Sdk.Model.GatewayHealthCheckWriteRequest
The check fields a customer writes; a missing one keeps its value, and a type takes only its own fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **GatewayHealthCheckTypeEnum** |  | [optional] 
**Path** | **string** | http only. | [optional] 
**StatusMin** | **int** | http only. | [optional] 
**StatusMax** | **int** | http only. | [optional] 
**IntervalS** | **int** |  | [optional] 
**TimeoutS** | **int** | Below interval_s. | [optional] 
**HealthyThreshold** | **int** |  | [optional] 
**UnhealthyThreshold** | **int** |  | [optional] 
**Port** | **int** | Null checks each server&#39;s own port. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


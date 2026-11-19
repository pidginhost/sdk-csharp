# PidginHost.Sdk.Model.ClusterEncryptionOperation
One encryption change, as the customer sees it.  ``verification_result`` is deliberately absent: the evidence is published once, sanitised, as the state's ``per_node`` - - two copies of a JSON column are two places for key material to escape from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Kind** | **string** |  | [readonly] 
**Status** | **string** |  | [readonly] 
**RequestedMode** | **string** |  | [readonly] 
**PreviousMode** | **string** |  | [readonly] 
**Reason** | **string** |  | [readonly] 
**Message** | **string** |  | [readonly] 
**OverrideUnverifiable** | **bool** |  | [readonly] 
**RequestId** | **string** |  | [readonly] 
**CreatedAt** | **string** |  | [readonly] 
**FinishedAt** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


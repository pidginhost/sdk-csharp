# PidginHost.Sdk.Model.ServerTrafficResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Year** | **int** |  | 
**Month** | **int** |  | 
**Status** | **string** |  | 
**BytesIn** | **long** |  | 
**BytesOut** | **long** |  | 
**BytesTotal** | **long** |  | 
**UsedUnits** | **int** |  | 
**UsedTb** | **string** | Usage rounded up to six decimal places; bytes_total is exact. | 
**BillableBytes** | **long** | Of bytes_total, the part that may be charged. | 
**BillableUnits** | **int** |  | 
**BillableTb** | **string** | Billable usage rounded up to six decimal places; billable_bytes is exact. | 
**ChargedTb** | **int** |  | 
**ChargedAmount** | **string** |  | 
**Currency** | **string** |  | 
**UnitBytes** | **long** |  | 
**Daily** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | 
**AsOf** | **DateOnly** |  | 
**IncludedTb** | **int** |  | 
**BillableFrom** | **DateOnly** | First fully billable day, when one date describes the usage. May fall after the reported month. Null when all usage is billable or streams have different boundaries; use billable_bytes for the billable total. | 
**PricePerTb** | **string** |  | 
**RemainingBytes** | **long** |  | 
**LastSampleAt** | **DateOnly** |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


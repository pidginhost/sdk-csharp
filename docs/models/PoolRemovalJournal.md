# PidginHost.Sdk.Model.PoolRemovalJournal
What a customer may see about a downsize or pool deletion.  There is no `source` here and the row records none. The spec's \"pool journals apply the same split\" is about the customer/staff partition, not a field-for-field mirror of the node operation: a journal's initiator is already `actor_label`, and a `source` column would have to be threaded through four call sites to say something no reader distinguishes. The day a `source=\"system\"` caller exists it becomes an additive `AddField`; until then it would be a column nothing can populate truthfully.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Kind** | **PoolRemovalJournalKindEnum** |  | [readonly] 
**Status** | **PoolRemovalJournalStatusEnum** |  | [readonly] 
**Reason** | **string** |  | [readonly] 
**Message** | **string** |  | [readonly] 
**LocalDataLossAccepted** | **bool** |  | [readonly] 
**ActorLabel** | **string** | Who requested the removal (user email or staff name). Never token material. | [readonly] 
**CreatedAt** | **string** |  | [readonly] 
**UpdatedAt** | **string** |  | [readonly] 
**Items** | [**List&lt;PoolRemovalItem&gt;**](PoolRemovalItem.md) |  | [readonly] 
**AllowedActions** | **List&lt;string&gt;** |  | [readonly] 
**RequestedPoolSize** | **int** |  | [readonly] 
**FinishedAt** | **string** |  | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


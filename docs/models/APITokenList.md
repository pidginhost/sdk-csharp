# PidginHost.Sdk.Model.APITokenList
Label bound tokens with their account + membership status (spec §4.2).  A dark deployment (flag off) with only personal rows keeps the exact pre-feature response shape; a bound row is always labeled so it cannot be mistaken for a personal token even after an emergency disable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | [readonly] 
**Scope** | **ScopeEnum** |  | [readonly] 
**KeyPrefix** | **string** |  | [readonly] 
**Created** | **string** |  | [readonly] 
**RequestCount** | **int** |  | [readonly] 
**LastUsed** | **string** |  | [readonly] 
**Account** | **string** |  | [optional] 
**MembershipStatus** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


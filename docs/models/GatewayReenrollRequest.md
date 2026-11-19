# PidginHost.Sdk.Model.GatewayReenrollRequest
The body of a re-enrollment (spec 8.1 step 6, 13.1): the preview's revision, the networks the gateway routes for and the servers that lose internet while it restarts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional] 
**Servers** | **List&lt;int&gt;** | The preview&#39;s server ids. | [optional] 
**Networks** | **List&lt;int&gt;** | The preview&#39;s network ids. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


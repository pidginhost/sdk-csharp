# PidginHost.Sdk.Model.NodeOperationDeleteRequest
A delete additionally requires the hostname typed back.  Checked here rather than in the service on purpose: it is a confirmation that a human typed the right name, which a `source=\"system\"` caller cannot satisfy and must not be asked to. The panel form asks the same question in the same words.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalDataLossAccepted** | **bool** | Acknowledge that data kept on the node itself is destroyed. The drain always deletes emptyDir. | [optional] [default to false]
**ConfirmHostname** | **string** | The node&#39;s hostname, typed back exactly. | [optional] [default to ""]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


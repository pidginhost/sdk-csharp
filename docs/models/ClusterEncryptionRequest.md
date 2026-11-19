# PidginHost.Sdk.Model.ClusterEncryptionRequest
The body of a toggle or a staff reconcile.  Field errors are re-raised as ``EncryptionConflict`` rather than left as DRF validation errors: the endpoint answers every refusal with the feature's stable reason code, and a body that switched shape depending on WHICH refusal it was would force a client to parse two.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **EncryptionModeEnum** | Target encryption mode: no encryption, or WireGuard.  * &#x60;none&#x60; - none * &#x60;wireguard&#x60; - wireguard | 
**AcknowledgeWorkloadRestart** | **bool** | Confirms the caller accepts that workloads must be restarted after the change. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


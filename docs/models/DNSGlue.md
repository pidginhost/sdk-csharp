# PidginHost.Sdk.Model.DNSGlue
A glue / \"personal DNS\" record: registers a child nameserver host at the registry as ``<name>.<domain>`` pointing at ``ip`` (and optional ``ip2``). Required before another domain can delegate to that nameserver.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | only subdomain part | 
**Ip** | **string** |  | 
**Ip2** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


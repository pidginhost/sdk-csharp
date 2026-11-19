# PidginHost.Sdk.Model.DNSRecordCreateRequest
Validate input for creating or editing a DNS record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Record hostname (use &#39;@&#39; or leave empty for zone apex). | 
**Ttl** | **int** | Time to live in seconds. | 
**Type** | **DNSRecordCreateTypeEnum** | DNS record type.  * &#x60;A&#x60; - A * &#x60;AAAA&#x60; - AAAA * &#x60;TYPE257&#x60; - TYPE257 * &#x60;CNAME&#x60; - CNAME * &#x60;MX&#x60; - MX * &#x60;SRV&#x60; - SRV * &#x60;TXT&#x60; - TXT | 
**Address** | **string** | IPv4/IPv6 address (A/AAAA). | [optional] 
**Cname** | **string** | Canonical name (CNAME). | [optional] 
**Exchange** | **string** | Mail exchange host (MX). | [optional] 
**Preference** | **int** | MX preference / priority. | [optional] 
**Txtdata** | **string** | TXT record data. | [optional] 
**Unencoded** | **string** | Unencoded TXT value. | [optional] 
**Target** | **string** | SRV target host. | [optional] 
**Priority** | **int** | SRV priority. | [optional] 
**Weight** | **int** | SRV weight. | [optional] 
**Port** | **int** | SRV port. | [optional] 
**Flag** | **int** | CAA flag (TYPE257). | [optional] 
**Tag** | **string** | CAA tag (TYPE257). | [optional] 
**Value** | **string** | CAA value (TYPE257). | [optional] 
**Line** | **int** | Line number of existing record to edit. Omit to add a new record. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


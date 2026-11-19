# PidginHost.Sdk.Api.FreednsApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FreednsDnsActivateCreate**](FreednsApi.md#freednsdnsactivatecreate) | **POST** /api/freedns/dns/activate/ |  |
| [**FreednsDnsAddRecordCreate**](FreednsApi.md#freednsdnsaddrecordcreate) | **POST** /api/freedns/dns/add-record/ |  |
| [**FreednsDnsDeactivateCreate**](FreednsApi.md#freednsdnsdeactivatecreate) | **POST** /api/freedns/dns/deactivate/ |  |
| [**FreednsDnsDeleteRecordCreate**](FreednsApi.md#freednsdnsdeleterecordcreate) | **POST** /api/freedns/dns/delete-record/ |  |
| [**FreednsDnsList**](FreednsApi.md#freednsdnslist) | **GET** /api/freedns/dns/ |  |
| [**FreednsDnsRecordsList**](FreednsApi.md#freednsdnsrecordslist) | **GET** /api/freedns/dns/records/ |  |

<a id="freednsdnsactivatecreate"></a>
# **FreednsDnsActivateCreate**
> ActivateFreeDNSResponse FreednsDnsActivateCreate (ActivateFreeDNSRequest activateFreeDNSRequest)



Activate FreeDNS for a domain. For internal domains the nameservers are changed to PidginHost NS. A default zone is created on the cPanel node.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activateFreeDNSRequest** | [**ActivateFreeDNSRequest**](ActivateFreeDNSRequest.md) |  |  |

### Return type

[**ActivateFreeDNSResponse**](ActivateFreeDNSResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="freednsdnsaddrecordcreate"></a>
# **FreednsDnsAddRecordCreate**
> DNSRecordMutateResponse FreednsDnsAddRecordCreate (string domain, string source, DNSRecordCreateRequest dNSRecordCreateRequest)



Add or edit a DNS record. To edit an existing record, include the 'line' field with its line number. Required type-specific fields depend on 'type': A/AAAA → address; CNAME → cname; MX → preference, exchange; SRV → priority, weight, port, target; TXT → txtdata, unencoded; TYPE257 (CAA) → flag, tag, value.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Domain name or PK. |  |
| **source** | **string** | &#39;internal&#39; or &#39;external&#39;. |  |
| **dNSRecordCreateRequest** | [**DNSRecordCreateRequest**](DNSRecordCreateRequest.md) |  |  |

### Return type

[**DNSRecordMutateResponse**](DNSRecordMutateResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="freednsdnsdeactivatecreate"></a>
# **FreednsDnsDeactivateCreate**
> DeactivateFreeDNSResponse FreednsDnsDeactivateCreate (DeactivateFreeDNSRequest deactivateFreeDNSRequest)



Deactivate FreeDNS for a domain. The DNS zone is removed from the cPanel node and, for internal domains, the original nameservers are restored.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deactivateFreeDNSRequest** | [**DeactivateFreeDNSRequest**](DeactivateFreeDNSRequest.md) |  |  |

### Return type

[**DeactivateFreeDNSResponse**](DeactivateFreeDNSResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="freednsdnsdeleterecordcreate"></a>
# **FreednsDnsDeleteRecordCreate**
> DeleteRecordResponse FreednsDnsDeleteRecordCreate (string domain, string source, DeleteRecordRequest deleteRecordRequest)



Delete a DNS record by its line number.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Domain name or PK. |  |
| **source** | **string** | &#39;internal&#39; or &#39;external&#39;. |  |
| **deleteRecordRequest** | [**DeleteRecordRequest**](DeleteRecordRequest.md) |  |  |

### Return type

[**DeleteRecordResponse**](DeleteRecordResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="freednsdnslist"></a>
# **FreednsDnsList**
> List&lt;FreeDNSDomain&gt; FreednsDnsList ()



List all domains with active FreeDNS for the authenticated user.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FreeDNSDomain&gt;**](FreeDNSDomain.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="freednsdnsrecordslist"></a>
# **FreednsDnsRecordsList**
> List&lt;DNSRecord&gt; FreednsDnsRecordsList (string domain, string source)



List all DNS records for a domain with active FreeDNS.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Domain name or PK. |  |
| **source** | **string** | &#39;internal&#39; or &#39;external&#39;. |  |

### Return type

[**List&lt;DNSRecord&gt;**](DNSRecord.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


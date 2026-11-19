# PidginHost.Sdk.Api.DedicatedApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DedicatedServersList**](DedicatedApi.md#dedicatedserverslist) | **GET** /api/dedicated/servers/ |  |
| [**DedicatedServersPowerCreate**](DedicatedApi.md#dedicatedserverspowercreate) | **POST** /api/dedicated/servers/{id}/power/ |  |
| [**DedicatedServersRdnsCreate**](DedicatedApi.md#dedicatedserversrdnscreate) | **POST** /api/dedicated/servers/{id}/rdns/ |  |
| [**DedicatedServersReinstallCreate**](DedicatedApi.md#dedicatedserversreinstallcreate) | **POST** /api/dedicated/servers/{id}/reinstall/ |  |
| [**DedicatedServersRetrieve**](DedicatedApi.md#dedicatedserversretrieve) | **GET** /api/dedicated/servers/{id}/ |  |

<a id="dedicatedserverslist"></a>
# **DedicatedServersList**
> PaginatedDedicatedServerList DedicatedServersList (int page = null)



List and manage dedicated server services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedDedicatedServerList**](PaginatedDedicatedServerList.md)

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

<a id="dedicatedserverspowercreate"></a>
# **DedicatedServersPowerCreate**
> PowerActionResponse DedicatedServersPowerCreate (string id, PowerActionRequest powerActionRequest)



Execute a power management action (start, stop, restart, shutdown).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **powerActionRequest** | [**PowerActionRequest**](PowerActionRequest.md) |  |  |

### Return type

[**PowerActionResponse**](PowerActionResponse.md)

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

<a id="dedicatedserversrdnscreate"></a>
# **DedicatedServersRdnsCreate**
> RDNSUpdateResponse DedicatedServersRdnsCreate (string id, DedicatedRDNSRequest dedicatedRDNSRequest)



Update reverse DNS for a dedicated server IP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **dedicatedRDNSRequest** | [**DedicatedRDNSRequest**](DedicatedRDNSRequest.md) |  |  |

### Return type

[**RDNSUpdateResponse**](RDNSUpdateResponse.md)

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

<a id="dedicatedserversreinstallcreate"></a>
# **DedicatedServersReinstallCreate**
> ReinstallResponse DedicatedServersReinstallCreate (string id, ReinstallRequest reinstallRequest)



Reinstall the dedicated server with a new operating system.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **reinstallRequest** | [**ReinstallRequest**](ReinstallRequest.md) |  |  |

### Return type

[**ReinstallResponse**](ReinstallResponse.md)

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

<a id="dedicatedserversretrieve"></a>
# **DedicatedServersRetrieve**
> DedicatedServer DedicatedServersRetrieve (string id)



List and manage dedicated server services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**DedicatedServer**](DedicatedServer.md)

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


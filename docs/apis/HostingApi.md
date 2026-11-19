# PidginHost.Sdk.Api.HostingApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HostingHostingChangePasswordCreate**](HostingApi.md#hostinghostingchangepasswordcreate) | **POST** /api/hosting/hosting/{id}/change-password/ |  |
| [**HostingHostingList**](HostingApi.md#hostinghostinglist) | **GET** /api/hosting/hosting/ |  |
| [**HostingHostingRetrieve**](HostingApi.md#hostinghostingretrieve) | **GET** /api/hosting/hosting/{id}/ |  |
| [**HostingHostingUpgradeOptionsRetrieve**](HostingApi.md#hostinghostingupgradeoptionsretrieve) | **GET** /api/hosting/hosting/{id}/upgrade-options/ |  |
| [**HostingHostingUsageRetrieve**](HostingApi.md#hostinghostingusageretrieve) | **GET** /api/hosting/hosting/{id}/usage/ |  |

<a id="hostinghostingchangepasswordcreate"></a>
# **HostingHostingChangePasswordCreate**
> HostingChangePasswordResponse HostingHostingChangePasswordCreate (string id, ChangePasswordRequest changePasswordRequest)



Change the cPanel password for this hosting service.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md) |  |  |

### Return type

[**HostingChangePasswordResponse**](HostingChangePasswordResponse.md)

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

<a id="hostinghostinglist"></a>
# **HostingHostingList**
> PaginatedHostingServiceList HostingHostingList (int page = null)



List and manage cPanel/shared hosting services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedHostingServiceList**](PaginatedHostingServiceList.md)

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

<a id="hostinghostingretrieve"></a>
# **HostingHostingRetrieve**
> HostingService HostingHostingRetrieve (string id)



List and manage cPanel/shared hosting services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**HostingService**](HostingService.md)

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

<a id="hostinghostingupgradeoptionsretrieve"></a>
# **HostingHostingUpgradeOptionsRetrieve**
> HostingUpgradeOptions HostingHostingUpgradeOptionsRetrieve (string id)



List and manage cPanel/shared hosting services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**HostingUpgradeOptions**](HostingUpgradeOptions.md)

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

<a id="hostinghostingusageretrieve"></a>
# **HostingHostingUsageRetrieve**
> HostingUsage HostingHostingUsageRetrieve (string id)



List and manage cPanel/shared hosting services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**HostingUsage**](HostingUsage.md)

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


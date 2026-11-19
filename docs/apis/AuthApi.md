# PidginHost.Sdk.Api.AuthApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthCliSessionCreate**](AuthApi.md#authclisessioncreate) | **POST** /api/auth/cli-session/ |  |
| [**AuthCliSessionRetrieve**](AuthApi.md#authclisessionretrieve) | **GET** /api/auth/cli-session/{session_id}/ |  |

<a id="authclisessioncreate"></a>
# **AuthCliSessionCreate**
> CLISessionCreateResponse AuthCliSessionCreate ()



Create a CLI authentication session for browser-based approval


### Parameters
This endpoint does not need any parameter.
### Return type

[**CLISessionCreateResponse**](CLISessionCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="authclisessionretrieve"></a>
# **AuthCliSessionRetrieve**
> CLISessionPollResponse AuthCliSessionRetrieve (Guid sessionId)



Poll a CLI authentication session. Returns token when approved.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |

### Return type

[**CLISessionPollResponse**](CLISessionPollResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


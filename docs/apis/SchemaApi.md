# PidginHost.Sdk.Api.SchemaApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SchemaRetrieve**](SchemaApi.md#schemaretrieve) | **GET** /api/schema/ |  |

<a id="schemaretrieve"></a>
# **SchemaRetrieve**
> Dictionary&lt;string, Object&gt; SchemaRetrieve (string format = null, string lang = null)



OpenApi3 schema for this API. Format can be selected via content negotiation.  - YAML: application/vnd.oai.openapi - JSON: application/vnd.oai.openapi+json


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string** |  | [optional]  |
| **lang** | **string** |  | [optional]  |

### Return type

**Dictionary<string, Object>**

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.oai.openapi, application/yaml, application/vnd.oai.openapi+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


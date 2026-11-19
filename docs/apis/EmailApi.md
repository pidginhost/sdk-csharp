# PidginHost.Sdk.Api.EmailApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmailApiCredentialsCreate**](EmailApi.md#emailapicredentialscreate) | **POST** /api/email/api_credentials/ |  |
| [**EmailApiCredentialsDestroy**](EmailApi.md#emailapicredentialsdestroy) | **DELETE** /api/email/api_credentials/{id}/ |  |
| [**EmailApiCredentialsList**](EmailApi.md#emailapicredentialslist) | **GET** /api/email/api_credentials/ |  |
| [**EmailApiCredentialsRetrieve**](EmailApi.md#emailapicredentialsretrieve) | **GET** /api/email/api_credentials/{id}/ |  |
| [**EmailDomainsCreate**](EmailApi.md#emaildomainscreate) | **POST** /api/email/domains/ |  |
| [**EmailDomainsInboundRoutesCreate**](EmailApi.md#emaildomainsinboundroutescreate) | **POST** /api/email/domains/{domain_pk}/inbound_routes/ |  |
| [**EmailDomainsInboundRoutesList**](EmailApi.md#emaildomainsinboundrouteslist) | **GET** /api/email/domains/{domain_pk}/inbound_routes/ |  |
| [**EmailDomainsList**](EmailApi.md#emaildomainslist) | **GET** /api/email/domains/ |  |
| [**EmailDomainsRetrieve**](EmailApi.md#emaildomainsretrieve) | **GET** /api/email/domains/{id}/ |  |
| [**EmailDomainsRotateDkimCreate**](EmailApi.md#emaildomainsrotatedkimcreate) | **POST** /api/email/domains/{id}/rotate_dkim/ |  |
| [**EmailDomainsToggleInboundCreate**](EmailApi.md#emaildomainstoggleinboundcreate) | **POST** /api/email/domains/{id}/toggle_inbound/ |  |
| [**EmailDomainsVerifyCreate**](EmailApi.md#emaildomainsverifycreate) | **POST** /api/email/domains/{id}/verify/ |  |
| [**EmailInboundRoutesCreate**](EmailApi.md#emailinboundroutescreate) | **POST** /api/email/inbound_routes/ |  |
| [**EmailInboundRoutesDestroy**](EmailApi.md#emailinboundroutesdestroy) | **DELETE** /api/email/inbound_routes/{id}/ |  |
| [**EmailInboundRoutesList**](EmailApi.md#emailinboundrouteslist) | **GET** /api/email/inbound_routes/ |  |
| [**EmailInboundRoutesPartialUpdate**](EmailApi.md#emailinboundroutespartialupdate) | **PATCH** /api/email/inbound_routes/{id}/ |  |
| [**EmailInboundRoutesRetrieve**](EmailApi.md#emailinboundroutesretrieve) | **GET** /api/email/inbound_routes/{id}/ |  |
| [**EmailMessagesRetrieve**](EmailApi.md#emailmessagesretrieve) | **GET** /api/email/messages/{message_id}/ |  |
| [**EmailSandboxAddressesCreate**](EmailApi.md#emailsandboxaddressescreate) | **POST** /api/email/sandbox_addresses/ |  |
| [**EmailSandboxAddressesDestroy**](EmailApi.md#emailsandboxaddressesdestroy) | **DELETE** /api/email/sandbox_addresses/{id}/ |  |
| [**EmailSandboxAddressesList**](EmailApi.md#emailsandboxaddresseslist) | **GET** /api/email/sandbox_addresses/ |  |
| [**EmailSandboxAddressesRetrieve**](EmailApi.md#emailsandboxaddressesretrieve) | **GET** /api/email/sandbox_addresses/{id}/ |  |
| [**EmailSendCreate**](EmailApi.md#emailsendcreate) | **POST** /api/email/send/ |  |
| [**EmailServicesApiCredentialsCreate**](EmailApi.md#emailservicesapicredentialscreate) | **POST** /api/email/services/{service_pk}/api_credentials/ |  |
| [**EmailServicesApiCredentialsList**](EmailApi.md#emailservicesapicredentialslist) | **GET** /api/email/services/{service_pk}/api_credentials/ |  |
| [**EmailServicesCancelCreate**](EmailApi.md#emailservicescancelcreate) | **POST** /api/email/services/{id}/cancel/ |  |
| [**EmailServicesChangeTierPartialUpdate**](EmailApi.md#emailserviceschangetierpartialupdate) | **PATCH** /api/email/services/{id}/change_tier/ |  |
| [**EmailServicesCreate**](EmailApi.md#emailservicescreate) | **POST** /api/email/services/ |  |
| [**EmailServicesDedicatedIpCreate**](EmailApi.md#emailservicesdedicatedipcreate) | **POST** /api/email/services/{id}/dedicated_ip/ |  |
| [**EmailServicesDedicatedIpDestroy**](EmailApi.md#emailservicesdedicatedipdestroy) | **DELETE** /api/email/services/{id}/dedicated_ip/ |  |
| [**EmailServicesDomainsCreate**](EmailApi.md#emailservicesdomainscreate) | **POST** /api/email/services/{service_pk}/domains/ |  |
| [**EmailServicesDomainsList**](EmailApi.md#emailservicesdomainslist) | **GET** /api/email/services/{service_pk}/domains/ |  |
| [**EmailServicesList**](EmailApi.md#emailserviceslist) | **GET** /api/email/services/ |  |
| [**EmailServicesMessagesRetrieve**](EmailApi.md#emailservicesmessagesretrieve) | **GET** /api/email/services/{service_pk}/messages/ |  |
| [**EmailServicesPartialUpdate**](EmailApi.md#emailservicespartialupdate) | **PATCH** /api/email/services/{id}/ |  |
| [**EmailServicesRetrieve**](EmailApi.md#emailservicesretrieve) | **GET** /api/email/services/{id}/ |  |
| [**EmailServicesSandboxAddressesCreate**](EmailApi.md#emailservicessandboxaddressescreate) | **POST** /api/email/services/{service_pk}/sandbox_addresses/ |  |
| [**EmailServicesSandboxAddressesList**](EmailApi.md#emailservicessandboxaddresseslist) | **GET** /api/email/services/{service_pk}/sandbox_addresses/ |  |
| [**EmailServicesSmtpCredentialsCreate**](EmailApi.md#emailservicessmtpcredentialscreate) | **POST** /api/email/services/{service_pk}/smtp_credentials/ |  |
| [**EmailServicesSmtpCredentialsList**](EmailApi.md#emailservicessmtpcredentialslist) | **GET** /api/email/services/{service_pk}/smtp_credentials/ |  |
| [**EmailServicesStatsRetrieve**](EmailApi.md#emailservicesstatsretrieve) | **GET** /api/email/services/{service_pk}/stats/ |  |
| [**EmailServicesSuppressionsCreate**](EmailApi.md#emailservicessuppressionscreate) | **POST** /api/email/services/{service_pk}/suppressions/ |  |
| [**EmailServicesSuppressionsList**](EmailApi.md#emailservicessuppressionslist) | **GET** /api/email/services/{service_pk}/suppressions/ |  |
| [**EmailSmtpCredentialsCreate**](EmailApi.md#emailsmtpcredentialscreate) | **POST** /api/email/smtp_credentials/ |  |
| [**EmailSmtpCredentialsDestroy**](EmailApi.md#emailsmtpcredentialsdestroy) | **DELETE** /api/email/smtp_credentials/{id}/ |  |
| [**EmailSmtpCredentialsList**](EmailApi.md#emailsmtpcredentialslist) | **GET** /api/email/smtp_credentials/ |  |
| [**EmailSmtpCredentialsRetrieve**](EmailApi.md#emailsmtpcredentialsretrieve) | **GET** /api/email/smtp_credentials/{id}/ |  |
| [**EmailSuppressionsCreate**](EmailApi.md#emailsuppressionscreate) | **POST** /api/email/suppressions/ |  |
| [**EmailSuppressionsDestroy**](EmailApi.md#emailsuppressionsdestroy) | **DELETE** /api/email/suppressions/{id}/ |  |
| [**EmailSuppressionsList**](EmailApi.md#emailsuppressionslist) | **GET** /api/email/suppressions/ |  |
| [**EmailSuppressionsRetrieve**](EmailApi.md#emailsuppressionsretrieve) | **GET** /api/email/suppressions/{id}/ |  |

<a id="emailapicredentialscreate"></a>
# **EmailApiCredentialsCreate**
> ApiCredentialCreated EmailApiCredentialsCreate (CredentialCreateRequest credentialCreateRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialCreateRequest** | [**CredentialCreateRequest**](CredentialCreateRequest.md) |  | [optional]  |

### Return type

[**ApiCredentialCreated**](ApiCredentialCreated.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailapicredentialsdestroy"></a>
# **EmailApiCredentialsDestroy**
> void EmailApiCredentialsDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this api credential. |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailapicredentialslist"></a>
# **EmailApiCredentialsList**
> PaginatedApiCredentialList EmailApiCredentialsList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedApiCredentialList**](PaginatedApiCredentialList.md)

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

<a id="emailapicredentialsretrieve"></a>
# **EmailApiCredentialsRetrieve**
> ApiCredential EmailApiCredentialsRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this api credential. |  |

### Return type

[**ApiCredential**](ApiCredential.md)

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

<a id="emaildomainscreate"></a>
# **EmailDomainsCreate**
> SendingDomain EmailDomainsCreate (DomainAddRequest domainAddRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainAddRequest** | [**DomainAddRequest**](DomainAddRequest.md) |  |  |

### Return type

[**SendingDomain**](SendingDomain.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emaildomainsinboundroutescreate"></a>
# **EmailDomainsInboundRoutesCreate**
> InboundRouteWriteResponse EmailDomainsInboundRoutesCreate (int domainPk, InboundRouteCreateRequest inboundRouteCreateRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainPk** | **int** |  |  |
| **inboundRouteCreateRequest** | [**InboundRouteCreateRequest**](InboundRouteCreateRequest.md) |  |  |

### Return type

[**InboundRouteWriteResponse**](InboundRouteWriteResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emaildomainsinboundrouteslist"></a>
# **EmailDomainsInboundRoutesList**
> PaginatedInboundRouteList EmailDomainsInboundRoutesList (int domainPk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainPk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedInboundRouteList**](PaginatedInboundRouteList.md)

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

<a id="emaildomainslist"></a>
# **EmailDomainsList**
> PaginatedSendingDomainList EmailDomainsList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSendingDomainList**](PaginatedSendingDomainList.md)

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

<a id="emaildomainsretrieve"></a>
# **EmailDomainsRetrieve**
> SendingDomain EmailDomainsRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sending domain. |  |

### Return type

[**SendingDomain**](SendingDomain.md)

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

<a id="emaildomainsrotatedkimcreate"></a>
# **EmailDomainsRotateDkimCreate**
> SendingDomain EmailDomainsRotateDkimCreate (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sending domain. |  |

### Return type

[**SendingDomain**](SendingDomain.md)

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

<a id="emaildomainstoggleinboundcreate"></a>
# **EmailDomainsToggleInboundCreate**
> SendingDomain EmailDomainsToggleInboundCreate (int id, ToggleInboundRequest toggleInboundRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sending domain. |  |
| **toggleInboundRequest** | [**ToggleInboundRequest**](ToggleInboundRequest.md) |  | [optional]  |

### Return type

[**SendingDomain**](SendingDomain.md)

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

<a id="emaildomainsverifycreate"></a>
# **EmailDomainsVerifyCreate**
> SendingDomain EmailDomainsVerifyCreate (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sending domain. |  |

### Return type

[**SendingDomain**](SendingDomain.md)

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

<a id="emailinboundroutescreate"></a>
# **EmailInboundRoutesCreate**
> InboundRouteWriteResponse EmailInboundRoutesCreate (InboundRouteCreateRequest inboundRouteCreateRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRouteCreateRequest** | [**InboundRouteCreateRequest**](InboundRouteCreateRequest.md) |  |  |

### Return type

[**InboundRouteWriteResponse**](InboundRouteWriteResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailinboundroutesdestroy"></a>
# **EmailInboundRoutesDestroy**
> void EmailInboundRoutesDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this inbound route. |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailinboundrouteslist"></a>
# **EmailInboundRoutesList**
> PaginatedInboundRouteList EmailInboundRoutesList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedInboundRouteList**](PaginatedInboundRouteList.md)

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

<a id="emailinboundroutespartialupdate"></a>
# **EmailInboundRoutesPartialUpdate**
> InboundRouteWriteResponse EmailInboundRoutesPartialUpdate (int id, PatchedInboundRouteCreateRequest patchedInboundRouteCreateRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this inbound route. |  |
| **patchedInboundRouteCreateRequest** | [**PatchedInboundRouteCreateRequest**](PatchedInboundRouteCreateRequest.md) |  | [optional]  |

### Return type

[**InboundRouteWriteResponse**](InboundRouteWriteResponse.md)

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

<a id="emailinboundroutesretrieve"></a>
# **EmailInboundRoutesRetrieve**
> InboundRoute EmailInboundRoutesRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this inbound route. |  |

### Return type

[**InboundRoute**](InboundRoute.md)

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

<a id="emailmessagesretrieve"></a>
# **EmailMessagesRetrieve**
> Dictionary&lt;string, Object&gt; EmailMessagesRetrieve (string messageId)



Look up a single message via Postal v3 legacy API using the server's own token.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

### Return type

**Dictionary<string, Object>**

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

<a id="emailsandboxaddressescreate"></a>
# **EmailSandboxAddressesCreate**
> SandboxAddress EmailSandboxAddressesCreate (SandboxAddressRequest sandboxAddressRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sandboxAddressRequest** | [**SandboxAddressRequest**](SandboxAddressRequest.md) |  |  |

### Return type

[**SandboxAddress**](SandboxAddress.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsandboxaddressesdestroy"></a>
# **EmailSandboxAddressesDestroy**
> void EmailSandboxAddressesDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sandbox verified address. |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsandboxaddresseslist"></a>
# **EmailSandboxAddressesList**
> PaginatedSandboxAddressList EmailSandboxAddressesList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSandboxAddressList**](PaginatedSandboxAddressList.md)

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

<a id="emailsandboxaddressesretrieve"></a>
# **EmailSandboxAddressesRetrieve**
> SandboxAddress EmailSandboxAddressesRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this sandbox verified address. |  |

### Return type

[**SandboxAddress**](SandboxAddress.md)

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

<a id="emailsendcreate"></a>
# **EmailSendCreate**
> EmailSendResponse EmailSendCreate (SendRequest sendRequest)




### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendRequest** | [**SendRequest**](SendRequest.md) |  |  |

### Return type

[**EmailSendResponse**](EmailSendResponse.md)

### Authorization

[emailApiKey](../README.md#emailApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicesapicredentialscreate"></a>
# **EmailServicesApiCredentialsCreate**
> ApiCredentialCreated EmailServicesApiCredentialsCreate (int servicePk, CredentialCreateRequest credentialCreateRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **credentialCreateRequest** | [**CredentialCreateRequest**](CredentialCreateRequest.md) |  | [optional]  |

### Return type

[**ApiCredentialCreated**](ApiCredentialCreated.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicesapicredentialslist"></a>
# **EmailServicesApiCredentialsList**
> PaginatedApiCredentialList EmailServicesApiCredentialsList (int servicePk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedApiCredentialList**](PaginatedApiCredentialList.md)

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

<a id="emailservicescancelcreate"></a>
# **EmailServicesCancelCreate**
> EmailService EmailServicesCancelCreate (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailserviceschangetierpartialupdate"></a>
# **EmailServicesChangeTierPartialUpdate**
> EmailService EmailServicesChangeTierPartialUpdate (int id, SubscribeRequest subscribeRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |
| **subscribeRequest** | [**SubscribeRequest**](SubscribeRequest.md) |  |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailservicescreate"></a>
# **EmailServicesCreate**
> EmailService EmailServicesCreate (SubscribeRequest subscribeRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscribeRequest** | [**SubscribeRequest**](SubscribeRequest.md) |  |  |

### Return type

[**EmailService**](EmailService.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicesdedicatedipcreate"></a>
# **EmailServicesDedicatedIpCreate**
> EmailService EmailServicesDedicatedIpCreate (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailservicesdedicatedipdestroy"></a>
# **EmailServicesDedicatedIpDestroy**
> EmailService EmailServicesDedicatedIpDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailservicesdomainscreate"></a>
# **EmailServicesDomainsCreate**
> SendingDomain EmailServicesDomainsCreate (int servicePk, DomainAddRequest domainAddRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **domainAddRequest** | [**DomainAddRequest**](DomainAddRequest.md) |  |  |

### Return type

[**SendingDomain**](SendingDomain.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicesdomainslist"></a>
# **EmailServicesDomainsList**
> PaginatedSendingDomainList EmailServicesDomainsList (int servicePk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSendingDomainList**](PaginatedSendingDomainList.md)

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

<a id="emailserviceslist"></a>
# **EmailServicesList**
> PaginatedEmailServiceList EmailServicesList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedEmailServiceList**](PaginatedEmailServiceList.md)

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

<a id="emailservicesmessagesretrieve"></a>
# **EmailServicesMessagesRetrieve**
> EmailMessageList EmailServicesMessagesRetrieve (int servicePk, int page = null, int perPage = null)



List recently observed messages for a customer's email service.  Postal v3 legacy API exposes per-message lookups only; phclient builds the list locally from webhook events. Each message_id is deduped, keeping the most recent event_type as the message status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | Page number, starting at 1. | [optional]  |
| **perPage** | **int** | Page size, capped at 200; defaults to 50. | [optional]  |

### Return type

[**EmailMessageList**](EmailMessageList.md)

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

<a id="emailservicespartialupdate"></a>
# **EmailServicesPartialUpdate**
> EmailService EmailServicesPartialUpdate (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailservicesretrieve"></a>
# **EmailServicesRetrieve**
> EmailService EmailServicesRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this email service. |  |

### Return type

[**EmailService**](EmailService.md)

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

<a id="emailservicessandboxaddressescreate"></a>
# **EmailServicesSandboxAddressesCreate**
> SandboxAddress EmailServicesSandboxAddressesCreate (int servicePk, SandboxAddressRequest sandboxAddressRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **sandboxAddressRequest** | [**SandboxAddressRequest**](SandboxAddressRequest.md) |  |  |

### Return type

[**SandboxAddress**](SandboxAddress.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicessandboxaddresseslist"></a>
# **EmailServicesSandboxAddressesList**
> PaginatedSandboxAddressList EmailServicesSandboxAddressesList (int servicePk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSandboxAddressList**](PaginatedSandboxAddressList.md)

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

<a id="emailservicessmtpcredentialscreate"></a>
# **EmailServicesSmtpCredentialsCreate**
> SmtpCredentialCreated EmailServicesSmtpCredentialsCreate (int servicePk, CredentialCreateRequest credentialCreateRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **credentialCreateRequest** | [**CredentialCreateRequest**](CredentialCreateRequest.md) |  | [optional]  |

### Return type

[**SmtpCredentialCreated**](SmtpCredentialCreated.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicessmtpcredentialslist"></a>
# **EmailServicesSmtpCredentialsList**
> PaginatedSmtpCredentialList EmailServicesSmtpCredentialsList (int servicePk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSmtpCredentialList**](PaginatedSmtpCredentialList.md)

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

<a id="emailservicesstatsretrieve"></a>
# **EmailServicesStatsRetrieve**
> EmailStats EmailServicesStatsRetrieve (int servicePk, DateOnly end = null, DateOnly start = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **end** | **DateOnly** |  | [optional]  |
| **start** | **DateOnly** |  | [optional]  |

### Return type

[**EmailStats**](EmailStats.md)

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

<a id="emailservicessuppressionscreate"></a>
# **EmailServicesSuppressionsCreate**
> SuppressionEntry EmailServicesSuppressionsCreate (int servicePk, SuppressionAddRequest suppressionAddRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **suppressionAddRequest** | [**SuppressionAddRequest**](SuppressionAddRequest.md) |  |  |

### Return type

[**SuppressionEntry**](SuppressionEntry.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailservicessuppressionslist"></a>
# **EmailServicesSuppressionsList**
> PaginatedSuppressionEntryList EmailServicesSuppressionsList (int servicePk, int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **servicePk** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSuppressionEntryList**](PaginatedSuppressionEntryList.md)

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

<a id="emailsmtpcredentialscreate"></a>
# **EmailSmtpCredentialsCreate**
> SmtpCredentialCreated EmailSmtpCredentialsCreate (CredentialCreateRequest credentialCreateRequest = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialCreateRequest** | [**CredentialCreateRequest**](CredentialCreateRequest.md) |  | [optional]  |

### Return type

[**SmtpCredentialCreated**](SmtpCredentialCreated.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsmtpcredentialsdestroy"></a>
# **EmailSmtpCredentialsDestroy**
> void EmailSmtpCredentialsDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this smtp credential. |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsmtpcredentialslist"></a>
# **EmailSmtpCredentialsList**
> PaginatedSmtpCredentialList EmailSmtpCredentialsList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSmtpCredentialList**](PaginatedSmtpCredentialList.md)

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

<a id="emailsmtpcredentialsretrieve"></a>
# **EmailSmtpCredentialsRetrieve**
> SmtpCredential EmailSmtpCredentialsRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this smtp credential. |  |

### Return type

[**SmtpCredential**](SmtpCredential.md)

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

<a id="emailsuppressionscreate"></a>
# **EmailSuppressionsCreate**
> SuppressionEntry EmailSuppressionsCreate (SuppressionAddRequest suppressionAddRequest)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **suppressionAddRequest** | [**SuppressionAddRequest**](SuppressionAddRequest.md) |  |  |

### Return type

[**SuppressionEntry**](SuppressionEntry.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsuppressionsdestroy"></a>
# **EmailSuppressionsDestroy**
> void EmailSuppressionsDestroy (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this suppression entry. |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailsuppressionslist"></a>
# **EmailSuppressionsList**
> PaginatedSuppressionEntryList EmailSuppressionsList (int page = null)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSuppressionEntryList**](PaginatedSuppressionEntryList.md)

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

<a id="emailsuppressionsretrieve"></a>
# **EmailSuppressionsRetrieve**
> SuppressionEntry EmailSuppressionsRetrieve (int id)



Intersect the beta gate and IAM with the configured API permissions.  Keeping the gate additive preserves authentication, custom-token scope, and OAuth scope checks when the customer-facing feature flag is open. Per-action permission overrides (the staff-only restore action) remain in the same intersection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this suppression entry. |  |

### Return type

[**SuppressionEntry**](SuppressionEntry.md)

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


# PidginHost.Sdk.Api.DomainApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DomainDomainCancelCreate**](DomainApi.md#domaindomaincancelcreate) | **POST** /api/domain/domain/{domain}/cancel/ |  |
| [**DomainDomainCheckAvailabilityCreate**](DomainApi.md#domaindomaincheckavailabilitycreate) | **POST** /api/domain/domain/check-availability/ |  |
| [**DomainDomainCheckAvailabilityRetrieve**](DomainApi.md#domaindomaincheckavailabilityretrieve) | **GET** /api/domain/domain/check-availability/ |  |
| [**DomainDomainContactsCreate**](DomainApi.md#domaindomaincontactscreate) | **POST** /api/domain/domain/{domain}/contacts/ |  |
| [**DomainDomainCreate**](DomainApi.md#domaindomaincreate) | **POST** /api/domain/domain/ |  |
| [**DomainDomainDnsCreate**](DomainApi.md#domaindomaindnscreate) | **POST** /api/domain/domain/{domain}/dns/ |  |
| [**DomainDomainDnsDestroy**](DomainApi.md#domaindomaindnsdestroy) | **DELETE** /api/domain/domain/{domain}/dns/{name}/ |  |
| [**DomainDomainDnsList**](DomainApi.md#domaindomaindnslist) | **GET** /api/domain/domain/{domain}/dns/ |  |
| [**DomainDomainList**](DomainApi.md#domaindomainlist) | **GET** /api/domain/domain/ |  |
| [**DomainDomainNameserversCreate**](DomainApi.md#domaindomainnameserverscreate) | **POST** /api/domain/domain/{domain}/nameservers/ |  |
| [**DomainDomainPartialUpdate**](DomainApi.md#domaindomainpartialupdate) | **PATCH** /api/domain/domain/{domain}/ |  |
| [**DomainDomainRenewCreate**](DomainApi.md#domaindomainrenewcreate) | **POST** /api/domain/domain/{domain}/renew/ |  |
| [**DomainDomainRetrieve**](DomainApi.md#domaindomainretrieve) | **GET** /api/domain/domain/{domain}/ |  |
| [**DomainDomainTransferRoDomainCreate**](DomainApi.md#domaindomaintransferrodomaincreate) | **POST** /api/domain/domain/transfer-ro-domain/ |  |
| [**DomainDomainUpdate**](DomainApi.md#domaindomainupdate) | **PUT** /api/domain/domain/{domain}/ |  |
| [**DomainRegistrantsCreate**](DomainApi.md#domainregistrantscreate) | **POST** /api/domain/registrants/ |  |
| [**DomainRegistrantsDestroy**](DomainApi.md#domainregistrantsdestroy) | **DELETE** /api/domain/registrants/{id}/ |  |
| [**DomainRegistrantsList**](DomainApi.md#domainregistrantslist) | **GET** /api/domain/registrants/ |  |
| [**DomainRegistrantsPartialUpdate**](DomainApi.md#domainregistrantspartialupdate) | **PATCH** /api/domain/registrants/{id}/ |  |
| [**DomainRegistrantsRetrieve**](DomainApi.md#domainregistrantsretrieve) | **GET** /api/domain/registrants/{id}/ |  |
| [**DomainRegistrantsUpdate**](DomainApi.md#domainregistrantsupdate) | **PUT** /api/domain/registrants/{id}/ |  |
| [**DomainTldCatalogRetrieve**](DomainApi.md#domaintldcatalogretrieve) | **GET** /api/domain/tld/catalog/ |  |
| [**DomainTldList**](DomainApi.md#domaintldlist) | **GET** /api/domain/tld/ |  |
| [**DomainTldRetrieve**](DomainApi.md#domaintldretrieve) | **GET** /api/domain/tld/{id}/ |  |

<a id="domaindomaincancelcreate"></a>
# **DomainDomainCancelCreate**
> DomainCancelResponse DomainDomainCancelCreate (string domain)



Cancel the service associated with this domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |

### Return type

[**DomainCancelResponse**](DomainCancelResponse.md)

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

<a id="domaindomaincheckavailabilitycreate"></a>
# **DomainDomainCheckAvailabilityCreate**
> DomainAvailability DomainDomainCheckAvailabilityCreate (CheckAvailabilityRequest checkAvailabilityRequest)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkAvailabilityRequest** | [**CheckAvailabilityRequest**](CheckAvailabilityRequest.md) |  |  |

### Return type

[**DomainAvailability**](DomainAvailability.md)

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

<a id="domaindomaincheckavailabilityretrieve"></a>
# **DomainDomainCheckAvailabilityRetrieve**
> DomainAvailability DomainDomainCheckAvailabilityRetrieve (string domain)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Domain with tld, ex: example.com |  |

### Return type

[**DomainAvailability**](DomainAvailability.md)

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

<a id="domaindomaincontactscreate"></a>
# **DomainDomainContactsCreate**
> ContactsUpdateResponse DomainDomainContactsCreate (string domain, ContactsUpdateRequest contactsUpdateRequest)



Update a contact on this domain using a saved DomainRegistrant.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **contactsUpdateRequest** | [**ContactsUpdateRequest**](ContactsUpdateRequest.md) |  |  |

### Return type

[**ContactsUpdateResponse**](ContactsUpdateResponse.md)

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

<a id="domaindomaincreate"></a>
# **DomainDomainCreate**
> DomainCreate DomainDomainCreate (DomainCreateRequest domainCreateRequest)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainCreateRequest** | [**DomainCreateRequest**](DomainCreateRequest.md) |  |  |

### Return type

[**DomainCreate**](DomainCreate.md)

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

<a id="domaindomaindnscreate"></a>
# **DomainDomainDnsCreate**
> DNSGlue DomainDomainDnsCreate (string domain, DNSGlueRequest dNSGlueRequest)



List or upsert glue / personal-DNS records (child nameserver hosts) for this domain. POST body: ``{\"name\": \"ns1\", \"ip\": \"1.2.3.4\", \"ip2\": \"\"}``.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **dNSGlueRequest** | [**DNSGlueRequest**](DNSGlueRequest.md) |  |  |

### Return type

[**DNSGlue**](DNSGlue.md)

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

<a id="domaindomaindnsdestroy"></a>
# **DomainDomainDnsDestroy**
> void DomainDomainDnsDestroy (string domain, string name)



Delete a glue / personal-DNS record (and deregister the nameserver host at the registrar).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **name** | **string** |  |  |

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

<a id="domaindomaindnslist"></a>
# **DomainDomainDnsList**
> PaginatedDNSGlueList DomainDomainDnsList (string domain, int page = null)



List or upsert glue / personal-DNS records (child nameserver hosts) for this domain. POST body: ``{\"name\": \"ns1\", \"ip\": \"1.2.3.4\", \"ip2\": \"\"}``.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedDNSGlueList**](PaginatedDNSGlueList.md)

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

<a id="domaindomainlist"></a>
# **DomainDomainList**
> PaginatedDomainList DomainDomainList (int page = null, string statusGroup = null)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |
| **statusGroup** | **string** | Filter by the account service status before pagination; ordered by expiry, then ID. | [optional]  |

### Return type

[**PaginatedDomainList**](PaginatedDomainList.md)

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

<a id="domaindomainnameserverscreate"></a>
# **DomainDomainNameserversCreate**
> NameserversUpdateResponse DomainDomainNameserversCreate (string domain, NameserversUpdateRequest nameserversUpdateRequest)



Update nameservers for this domain.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **nameserversUpdateRequest** | [**NameserversUpdateRequest**](NameserversUpdateRequest.md) |  |  |

### Return type

[**NameserversUpdateResponse**](NameserversUpdateResponse.md)

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

<a id="domaindomainpartialupdate"></a>
# **DomainDomainPartialUpdate**
> Domain DomainDomainPartialUpdate (string domain, PatchedDomainRequest patchedDomainRequest = null)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **patchedDomainRequest** | [**PatchedDomainRequest**](PatchedDomainRequest.md) |  | [optional]  |

### Return type

[**Domain**](Domain.md)

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

<a id="domaindomainrenewcreate"></a>
# **DomainDomainRenewCreate**
> RenewDomain DomainDomainRenewCreate (string domain, RenewDomainRequest renewDomainRequest)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **renewDomainRequest** | [**RenewDomainRequest**](RenewDomainRequest.md) |  |  |

### Return type

[**RenewDomain**](RenewDomain.md)

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

<a id="domaindomainretrieve"></a>
# **DomainDomainRetrieve**
> Domain DomainDomainRetrieve (string domain)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |

### Return type

[**Domain**](Domain.md)

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

<a id="domaindomaintransferrodomaincreate"></a>
# **DomainDomainTransferRoDomainCreate**
> TransferRoDomain DomainDomainTransferRoDomainCreate (TransferRoDomainRequest transferRoDomainRequest)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferRoDomainRequest** | [**TransferRoDomainRequest**](TransferRoDomainRequest.md) |  |  |

### Return type

[**TransferRoDomain**](TransferRoDomain.md)

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

<a id="domaindomainupdate"></a>
# **DomainDomainUpdate**
> Domain DomainDomainUpdate (string domain, DomainRequest domainRequest = null)



Manage your domains


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** |  |  |
| **domainRequest** | [**DomainRequest**](DomainRequest.md) |  | [optional]  |

### Return type

[**Domain**](Domain.md)

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

<a id="domainregistrantscreate"></a>
# **DomainRegistrantsCreate**
> DomainRegistrant DomainRegistrantsCreate (DomainRegistrantRequest domainRegistrantRequest)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainRegistrantRequest** | [**DomainRegistrantRequest**](DomainRegistrantRequest.md) |  |  |

### Return type

[**DomainRegistrant**](DomainRegistrant.md)

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

<a id="domainregistrantsdestroy"></a>
# **DomainRegistrantsDestroy**
> void DomainRegistrantsDestroy (string id)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="domainregistrantslist"></a>
# **DomainRegistrantsList**
> PaginatedDomainRegistrantList DomainRegistrantsList (int page = null)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedDomainRegistrantList**](PaginatedDomainRegistrantList.md)

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

<a id="domainregistrantspartialupdate"></a>
# **DomainRegistrantsPartialUpdate**
> DomainRegistrant DomainRegistrantsPartialUpdate (string id, PatchedDomainRegistrantRequest patchedDomainRegistrantRequest = null)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **patchedDomainRegistrantRequest** | [**PatchedDomainRegistrantRequest**](PatchedDomainRegistrantRequest.md) |  | [optional]  |

### Return type

[**DomainRegistrant**](DomainRegistrant.md)

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

<a id="domainregistrantsretrieve"></a>
# **DomainRegistrantsRetrieve**
> DomainRegistrant DomainRegistrantsRetrieve (string id)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**DomainRegistrant**](DomainRegistrant.md)

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

<a id="domainregistrantsupdate"></a>
# **DomainRegistrantsUpdate**
> DomainRegistrant DomainRegistrantsUpdate (string id, DomainRegistrantRequest domainRegistrantRequest)



Manage your domain registrant views


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **domainRegistrantRequest** | [**DomainRegistrantRequest**](DomainRegistrantRequest.md) |  |  |

### Return type

[**DomainRegistrant**](DomainRegistrant.md)

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

<a id="domaintldcatalogretrieve"></a>
# **DomainTldCatalogRetrieve**
> TLDCatalog DomainTldCatalogRetrieve ()



Registration catalog uses exactly the registrar/prices used by create.


### Parameters
This endpoint does not need any parameter.
### Return type

[**TLDCatalog**](TLDCatalog.md)

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

<a id="domaintldlist"></a>
# **DomainTldList**
> PaginatedTLDList DomainTldList (int page = null)



Manage your TLDs


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedTLDList**](PaginatedTLDList.md)

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

<a id="domaintldretrieve"></a>
# **DomainTldRetrieve**
> TLD DomainTldRetrieve (int id)



Manage your TLDs


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this top level domain. |  |

### Return type

[**TLD**](TLD.md)

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


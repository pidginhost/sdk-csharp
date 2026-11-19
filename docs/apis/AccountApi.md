# PidginHost.Sdk.Api.AccountApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountApiTokensCreate**](AccountApi.md#accountapitokenscreate) | **POST** /api/account/api-tokens/ |  |
| [**AccountApiTokensDestroy**](AccountApi.md#accountapitokensdestroy) | **DELETE** /api/account/api-tokens/{id}/ |  |
| [**AccountApiTokensList**](AccountApi.md#accountapitokenslist) | **GET** /api/account/api-tokens/ |  |
| [**AccountCompaniesCreate**](AccountApi.md#accountcompaniescreate) | **POST** /api/account/companies/ |  |
| [**AccountCompaniesDestroy**](AccountApi.md#accountcompaniesdestroy) | **DELETE** /api/account/companies/{id}/ |  |
| [**AccountCompaniesList**](AccountApi.md#accountcompanieslist) | **GET** /api/account/companies/ |  |
| [**AccountCompaniesPartialUpdate**](AccountApi.md#accountcompaniespartialupdate) | **PATCH** /api/account/companies/{id}/ |  |
| [**AccountCompaniesRetrieve**](AccountApi.md#accountcompaniesretrieve) | **GET** /api/account/companies/{id}/ |  |
| [**AccountCompaniesUpdate**](AccountApi.md#accountcompaniesupdate) | **PUT** /api/account/companies/{id}/ |  |
| [**AccountDashboardRetrieve**](AccountApi.md#accountdashboardretrieve) | **GET** /api/account/dashboard/ |  |
| [**AccountEmailsList**](AccountApi.md#accountemailslist) | **GET** /api/account/emails/ |  |
| [**AccountProfilePartialUpdate**](AccountApi.md#accountprofilepartialupdate) | **PATCH** /api/account/profile |  |
| [**AccountProfileRetrieve**](AccountApi.md#accountprofileretrieve) | **GET** /api/account/profile |  |
| [**AccountProfileUpdate**](AccountApi.md#accountprofileupdate) | **PUT** /api/account/profile |  |
| [**AccountSessionRetrieve**](AccountApi.md#accountsessionretrieve) | **GET** /api/account/session/ |  |
| [**AccountSshKeysCreate**](AccountApi.md#accountsshkeyscreate) | **POST** /api/account/ssh-keys/ |  |
| [**AccountSshKeysDestroy**](AccountApi.md#accountsshkeysdestroy) | **DELETE** /api/account/ssh-keys/{id}/ |  |
| [**AccountSshKeysList**](AccountApi.md#accountsshkeyslist) | **GET** /api/account/ssh-keys/ |  |
| [**AccountSshKeysPartialUpdate**](AccountApi.md#accountsshkeyspartialupdate) | **PATCH** /api/account/ssh-keys/{id}/ |  |
| [**AccountSshKeysRetrieve**](AccountApi.md#accountsshkeysretrieve) | **GET** /api/account/ssh-keys/{id}/ |  |
| [**AccountSshKeysUpdate**](AccountApi.md#accountsshkeysupdate) | **PUT** /api/account/ssh-keys/{id}/ |  |

<a id="accountapitokenscreate"></a>
# **AccountApiTokensCreate**
> APITokenCreate AccountApiTokensCreate (APITokenCreateRequest aPITokenCreateRequest)



Manage your API tokens


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPITokenCreateRequest** | [**APITokenCreateRequest**](APITokenCreateRequest.md) |  |  |

### Return type

[**APITokenCreate**](APITokenCreate.md)

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

<a id="accountapitokensdestroy"></a>
# **AccountApiTokensDestroy**
> void AccountApiTokensDestroy (string id)



Manage your API tokens


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

<a id="accountapitokenslist"></a>
# **AccountApiTokensList**
> PaginatedAPITokenListList AccountApiTokensList (int page = null)



Manage your API tokens


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedAPITokenListList**](PaginatedAPITokenListList.md)

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

<a id="accountcompaniescreate"></a>
# **AccountCompaniesCreate**
> Company AccountCompaniesCreate (CompanyRequest companyRequest)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyRequest** | [**CompanyRequest**](CompanyRequest.md) |  |  |

### Return type

[**Company**](Company.md)

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

<a id="accountcompaniesdestroy"></a>
# **AccountCompaniesDestroy**
> void AccountCompaniesDestroy (int id)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this company. |  |

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

<a id="accountcompanieslist"></a>
# **AccountCompaniesList**
> PaginatedCompanyList AccountCompaniesList (int page = null)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedCompanyList**](PaginatedCompanyList.md)

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

<a id="accountcompaniespartialupdate"></a>
# **AccountCompaniesPartialUpdate**
> Company AccountCompaniesPartialUpdate (int id, PatchedCompanyRequest patchedCompanyRequest = null)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this company. |  |
| **patchedCompanyRequest** | [**PatchedCompanyRequest**](PatchedCompanyRequest.md) |  | [optional]  |

### Return type

[**Company**](Company.md)

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

<a id="accountcompaniesretrieve"></a>
# **AccountCompaniesRetrieve**
> Company AccountCompaniesRetrieve (int id)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this company. |  |

### Return type

[**Company**](Company.md)

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

<a id="accountcompaniesupdate"></a>
# **AccountCompaniesUpdate**
> Company AccountCompaniesUpdate (int id, CompanyRequest companyRequest)



Manage your companies


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this company. |  |
| **companyRequest** | [**CompanyRequest**](CompanyRequest.md) |  |  |

### Return type

[**Company**](Company.md)

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

<a id="accountdashboardretrieve"></a>
# **AccountDashboardRetrieve**
> Dashboard AccountDashboardRetrieve ()



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**Dashboard**](Dashboard.md)

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

<a id="accountemailslist"></a>
# **AccountEmailsList**
> PaginatedEmailHistoryList AccountEmailsList (int page = null)



List email history for the authenticated user.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedEmailHistoryList**](PaginatedEmailHistoryList.md)

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

<a id="accountprofilepartialupdate"></a>
# **AccountProfilePartialUpdate**
> Profile AccountProfilePartialUpdate (PatchedProfileRequest patchedProfileRequest = null)



Manage your profile data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **patchedProfileRequest** | [**PatchedProfileRequest**](PatchedProfileRequest.md) |  | [optional]  |

### Return type

[**Profile**](Profile.md)

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

<a id="accountprofileretrieve"></a>
# **AccountProfileRetrieve**
> Profile AccountProfileRetrieve ()



Manage your profile data


### Parameters
This endpoint does not need any parameter.
### Return type

[**Profile**](Profile.md)

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

<a id="accountprofileupdate"></a>
# **AccountProfileUpdate**
> Profile AccountProfileUpdate (ProfileRequest profileRequest)



Manage your profile data


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileRequest** | [**ProfileRequest**](ProfileRequest.md) |  |  |

### Return type

[**Profile**](Profile.md)

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

<a id="accountsessionretrieve"></a>
# **AccountSessionRetrieve**
> AccountSessionResponse AccountSessionRetrieve ()



Resolved account and role/scope intersection without owner-only profile access.


### Parameters
This endpoint does not need any parameter.
### Return type

[**AccountSessionResponse**](AccountSessionResponse.md)

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

<a id="accountsshkeyscreate"></a>
# **AccountSshKeysCreate**
> SSHKey AccountSshKeysCreate (SSHKeyRequest sSHKeyRequest)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSHKeyRequest** | [**SSHKeyRequest**](SSHKeyRequest.md) |  |  |

### Return type

[**SSHKey**](SSHKey.md)

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

<a id="accountsshkeysdestroy"></a>
# **AccountSshKeysDestroy**
> void AccountSshKeysDestroy (string id)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


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

<a id="accountsshkeyslist"></a>
# **AccountSshKeysList**
> PaginatedSSHKeyList AccountSshKeysList (int page = null)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSSHKeyList**](PaginatedSSHKeyList.md)

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

<a id="accountsshkeyspartialupdate"></a>
# **AccountSshKeysPartialUpdate**
> SSHKey AccountSshKeysPartialUpdate (string id, PatchedSSHKeyUpdateRequest patchedSSHKeyUpdateRequest = null)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **patchedSSHKeyUpdateRequest** | [**PatchedSSHKeyUpdateRequest**](PatchedSSHKeyUpdateRequest.md) |  | [optional]  |

### Return type

[**SSHKey**](SSHKey.md)

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

<a id="accountsshkeysretrieve"></a>
# **AccountSshKeysRetrieve**
> SSHKey AccountSshKeysRetrieve (string id)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**SSHKey**](SSHKey.md)

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

<a id="accountsshkeysupdate"></a>
# **AccountSshKeysUpdate**
> SSHKey AccountSshKeysUpdate (string id, SSHKeyUpdateRequest sSHKeyUpdateRequest = null)



Account context + IAM role enforcement for the account residue: billing identity (profile/companies/email history) is owner-only account state, SSH keys are account infra, tokens stay actor-owned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **sSHKeyUpdateRequest** | [**SSHKeyUpdateRequest**](SSHKeyUpdateRequest.md) |  | [optional]  |

### Return type

[**SSHKey**](SSHKey.md)

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


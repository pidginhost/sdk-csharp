# PidginHost.Sdk.Api.BillingApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BillingDepositsCreate**](BillingApi.md#billingdepositscreate) | **POST** /api/billing/deposits/ |  |
| [**BillingDepositsList**](BillingApi.md#billingdepositslist) | **GET** /api/billing/deposits/ |  |
| [**BillingDepositsRetrieve**](BillingApi.md#billingdepositsretrieve) | **GET** /api/billing/deposits/{id}/ |  |
| [**BillingFundsList**](BillingApi.md#billingfundslist) | **GET** /api/billing/funds/ |  |
| [**BillingFundsLogList**](BillingApi.md#billingfundsloglist) | **GET** /api/billing/funds-log/ |  |
| [**BillingFundsNotificationSettingsCreate**](BillingApi.md#billingfundsnotificationsettingscreate) | **POST** /api/billing/funds/notification-settings/ |  |
| [**BillingInvoicesList**](BillingApi.md#billinginvoiceslist) | **GET** /api/billing/invoices/ |  |
| [**BillingInvoicesPayWithFundsCreate**](BillingApi.md#billinginvoicespaywithfundscreate) | **POST** /api/billing/invoices/{id}/pay-with-funds/ |  |
| [**BillingInvoicesPdfRetrieve**](BillingApi.md#billinginvoicespdfretrieve) | **GET** /api/billing/invoices/{id}/pdf/ |  |
| [**BillingInvoicesRetrieve**](BillingApi.md#billinginvoicesretrieve) | **GET** /api/billing/invoices/{id}/ |  |
| [**BillingServicesCancelCreate**](BillingApi.md#billingservicescancelcreate) | **POST** /api/billing/services/{id}/cancel/ |  |
| [**BillingServicesChangeBillingCycleCreate**](BillingApi.md#billingserviceschangebillingcyclecreate) | **POST** /api/billing/services/{id}/change-billing-cycle/ |  |
| [**BillingServicesChangeCompanyCreate**](BillingApi.md#billingserviceschangecompanycreate) | **POST** /api/billing/services/{id}/change-company/ |  |
| [**BillingServicesList**](BillingApi.md#billingserviceslist) | **GET** /api/billing/services/ |  |
| [**BillingServicesRetrieve**](BillingApi.md#billingservicesretrieve) | **GET** /api/billing/services/{id}/ |  |
| [**BillingServicesToggleAutoPaymentCreate**](BillingApi.md#billingservicestoggleautopaymentcreate) | **POST** /api/billing/services/{id}/toggle-auto-payment/ |  |
| [**BillingSubscriptionsList**](BillingApi.md#billingsubscriptionslist) | **GET** /api/billing/subscriptions/ |  |
| [**BillingSubscriptionsRetrieve**](BillingApi.md#billingsubscriptionsretrieve) | **GET** /api/billing/subscriptions/{id}/ |  |

<a id="billingdepositscreate"></a>
# **BillingDepositsCreate**
> Deposit BillingDepositsCreate (DepositCreateRequest depositCreateRequest)



Create a new funds deposit.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **depositCreateRequest** | [**DepositCreateRequest**](DepositCreateRequest.md) |  |  |

### Return type

[**Deposit**](Deposit.md)

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

<a id="billingdepositslist"></a>
# **BillingDepositsList**
> PaginatedDepositList BillingDepositsList (int page = null)



List, create, and retrieve fund deposits.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedDepositList**](PaginatedDepositList.md)

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

<a id="billingdepositsretrieve"></a>
# **BillingDepositsRetrieve**
> Deposit BillingDepositsRetrieve (string id)



List, create, and retrieve fund deposits.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**Deposit**](Deposit.md)

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

<a id="billingfundslist"></a>
# **BillingFundsList**
> List&lt;FundsBalanceResponse&gt; BillingFundsList ()



Get current funds balance and notification settings.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FundsBalanceResponse&gt;**](FundsBalanceResponse.md)

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

<a id="billingfundsloglist"></a>
# **BillingFundsLogList**
> PaginatedFundsLogList BillingFundsLogList (int page = null)



List funds log entries for the selected account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedFundsLogList**](PaginatedFundsLogList.md)

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

<a id="billingfundsnotificationsettingscreate"></a>
# **BillingFundsNotificationSettingsCreate**
> NotificationSettingsResponse BillingFundsNotificationSettingsCreate (LowBalanceSettingsRequest lowBalanceSettingsRequest)



Update low-balance notification settings.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lowBalanceSettingsRequest** | [**LowBalanceSettingsRequest**](LowBalanceSettingsRequest.md) |  |  |

### Return type

[**NotificationSettingsResponse**](NotificationSettingsResponse.md)

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

<a id="billinginvoiceslist"></a>
# **BillingInvoicesList**
> PaginatedInvoiceListList BillingInvoicesList (int page = null)



List and retrieve invoices. Pay with funds or download PDF.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedInvoiceListList**](PaginatedInvoiceListList.md)

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

<a id="billinginvoicespaywithfundscreate"></a>
# **BillingInvoicesPayWithFundsCreate**
> PayWithFundsResponse BillingInvoicesPayWithFundsCreate (string id)



Pay an unpaid/overdue invoice using account funds.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**PayWithFundsResponse**](PayWithFundsResponse.md)

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

<a id="billinginvoicespdfretrieve"></a>
# **BillingInvoicesPdfRetrieve**
> System.IO.Stream BillingInvoicesPdfRetrieve (string id)



Download invoice PDF. Use ?type=proforma or ?type=fiscal.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**System.IO.Stream**

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

<a id="billinginvoicesretrieve"></a>
# **BillingInvoicesRetrieve**
> InvoiceDetail BillingInvoicesRetrieve (string id)



List and retrieve invoices. Pay with funds or download PDF.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**InvoiceDetail**](InvoiceDetail.md)

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

<a id="billingservicescancelcreate"></a>
# **BillingServicesCancelCreate**
> CancelServiceResponse BillingServicesCancelCreate (string id)



Cancel a service. Pending services are cancelled immediately; active services are terminated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**CancelServiceResponse**](CancelServiceResponse.md)

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

<a id="billingserviceschangebillingcyclecreate"></a>
# **BillingServicesChangeBillingCycleCreate**
> ChangeBillingCycleResponse BillingServicesChangeBillingCycleCreate (string id, ChangeBillingCycleRequest changeBillingCycleRequest)



Change the billing cycle of a service.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **changeBillingCycleRequest** | [**ChangeBillingCycleRequest**](ChangeBillingCycleRequest.md) |  |  |

### Return type

[**ChangeBillingCycleResponse**](ChangeBillingCycleResponse.md)

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

<a id="billingserviceschangecompanycreate"></a>
# **BillingServicesChangeCompanyCreate**
> ChangeCompanyResponse BillingServicesChangeCompanyCreate (string id, ChangeCompanyRequest changeCompanyRequest = null)



Change the company associated with a service.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **changeCompanyRequest** | [**ChangeCompanyRequest**](ChangeCompanyRequest.md) |  | [optional]  |

### Return type

[**ChangeCompanyResponse**](ChangeCompanyResponse.md)

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

<a id="billingserviceslist"></a>
# **BillingServicesList**
> PaginatedServiceListList BillingServicesList (int page = null)



List and manage billing services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedServiceListList**](PaginatedServiceListList.md)

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

<a id="billingservicesretrieve"></a>
# **BillingServicesRetrieve**
> ServiceList BillingServicesRetrieve (string id)



List and manage billing services.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ServiceList**](ServiceList.md)

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

<a id="billingservicestoggleautopaymentcreate"></a>
# **BillingServicesToggleAutoPaymentCreate**
> ToggleAutoPaymentResponse BillingServicesToggleAutoPaymentCreate (string id)



Toggle automatic payment for a service.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ToggleAutoPaymentResponse**](ToggleAutoPaymentResponse.md)

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

<a id="billingsubscriptionslist"></a>
# **BillingSubscriptionsList**
> PaginatedSubscriptionList BillingSubscriptionsList (int page = null)



List and retrieve subscriptions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedSubscriptionList**](PaginatedSubscriptionList.md)

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

<a id="billingsubscriptionsretrieve"></a>
# **BillingSubscriptionsRetrieve**
> Subscription BillingSubscriptionsRetrieve (string id)



List and retrieve subscriptions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**Subscription**](Subscription.md)

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


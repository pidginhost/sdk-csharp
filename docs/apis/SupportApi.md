# PidginHost.Sdk.Api.SupportApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SupportDepartmentsList**](SupportApi.md#supportdepartmentslist) | **GET** /api/support/departments/ |  |
| [**SupportTicketsCloseCreate**](SupportApi.md#supportticketsclosecreate) | **POST** /api/support/tickets/{id}/close/ |  |
| [**SupportTicketsCreate**](SupportApi.md#supportticketscreate) | **POST** /api/support/tickets/ |  |
| [**SupportTicketsList**](SupportApi.md#supportticketslist) | **GET** /api/support/tickets/ |  |
| [**SupportTicketsMessagesAttachmentRetrieve**](SupportApi.md#supportticketsmessagesattachmentretrieve) | **GET** /api/support/tickets/{id}/messages/{message_id}/attachment/ |  |
| [**SupportTicketsReopenCreate**](SupportApi.md#supportticketsreopencreate) | **POST** /api/support/tickets/{id}/reopen/ |  |
| [**SupportTicketsReplyCreate**](SupportApi.md#supportticketsreplycreate) | **POST** /api/support/tickets/{id}/reply/ |  |
| [**SupportTicketsRetrieve**](SupportApi.md#supportticketsretrieve) | **GET** /api/support/tickets/{id}/ |  |

<a id="supportdepartmentslist"></a>
# **SupportDepartmentsList**
> List&lt;Department&gt; SupportDepartmentsList ()



List available support departments.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Department&gt;**](Department.md)

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

<a id="supportticketsclosecreate"></a>
# **SupportTicketsCloseCreate**
> TicketCloseResponse SupportTicketsCloseCreate (string id)



Close a ticket.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**TicketCloseResponse**](TicketCloseResponse.md)

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

<a id="supportticketscreate"></a>
# **SupportTicketsCreate**
> TicketDetail SupportTicketsCreate (TicketCreateRequest ticketCreateRequest)



Create a new support ticket.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ticketCreateRequest** | [**TicketCreateRequest**](TicketCreateRequest.md) |  |  |

### Return type

[**TicketDetail**](TicketDetail.md)

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

<a id="supportticketslist"></a>
# **SupportTicketsList**
> PaginatedTicketListList SupportTicketsList (int page = null)



List, create, and manage support tickets.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedTicketListList**](PaginatedTicketListList.md)

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

<a id="supportticketsmessagesattachmentretrieve"></a>
# **SupportTicketsMessagesAttachmentRetrieve**
> System.IO.Stream SupportTicketsMessagesAttachmentRetrieve (string id, string messageId)



Download an attachment from a ticket message.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |

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

<a id="supportticketsreopencreate"></a>
# **SupportTicketsReopenCreate**
> TicketReopenResponse SupportTicketsReopenCreate (string id)



Reopen a closed ticket.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**TicketReopenResponse**](TicketReopenResponse.md)

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

<a id="supportticketsreplycreate"></a>
# **SupportTicketsReplyCreate**
> TicketReplyResponse SupportTicketsReplyCreate (string id, TicketReplyRequest ticketReplyRequest)



Reply to a ticket.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **ticketReplyRequest** | [**TicketReplyRequest**](TicketReplyRequest.md) |  |  |

### Return type

[**TicketReplyResponse**](TicketReplyResponse.md)

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

<a id="supportticketsretrieve"></a>
# **SupportTicketsRetrieve**
> TicketDetail SupportTicketsRetrieve (string id)



List, create, and manage support tickets.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**TicketDetail**](TicketDetail.md)

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


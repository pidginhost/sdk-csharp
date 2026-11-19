# PidginHost.Sdk.Api.KubernetesApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**KubernetesClusterTypesList**](KubernetesApi.md#kubernetesclustertypeslist) | **GET** /api/kubernetes/cluster-types/ |  |
| [**KubernetesClustersConnectVmCreate**](KubernetesApi.md#kubernetesclustersconnectvmcreate) | **POST** /api/kubernetes/clusters/{id}/connect-vm/ |  |
| [**KubernetesClustersConnectedVmsRetrieve**](KubernetesApi.md#kubernetesclustersconnectedvmsretrieve) | **GET** /api/kubernetes/clusters/{id}/connected-vms/ |  |
| [**KubernetesClustersCreate**](KubernetesApi.md#kubernetesclusterscreate) | **POST** /api/kubernetes/clusters/ |  |
| [**KubernetesClustersDestroy**](KubernetesApi.md#kubernetesclustersdestroy) | **DELETE** /api/kubernetes/clusters/{id}/ |  |
| [**KubernetesClustersDisconnectVmCreate**](KubernetesApi.md#kubernetesclustersdisconnectvmcreate) | **POST** /api/kubernetes/clusters/{id}/disconnect-vm/ |  |
| [**KubernetesClustersEligibleVmsRetrieve**](KubernetesApi.md#kubernetesclusterseligiblevmsretrieve) | **GET** /api/kubernetes/clusters/{id}/eligible-vms/ |  |
| [**KubernetesClustersEncryptionCreate**](KubernetesApi.md#kubernetesclustersencryptioncreate) | **POST** /api/kubernetes/clusters/{id}/encryption/ |  |
| [**KubernetesClustersEncryptionRecheckCreate**](KubernetesApi.md#kubernetesclustersencryptionrecheckcreate) | **POST** /api/kubernetes/clusters/{id}/encryption/recheck/ |  |
| [**KubernetesClustersEncryptionRetrieve**](KubernetesApi.md#kubernetesclustersencryptionretrieve) | **GET** /api/kubernetes/clusters/{id}/encryption/ |  |
| [**KubernetesClustersHttproutesCreate**](KubernetesApi.md#kubernetesclustershttproutescreate) | **POST** /api/kubernetes/clusters/{cluster_id}/httproutes/ |  |
| [**KubernetesClustersHttproutesDestroy**](KubernetesApi.md#kubernetesclustershttproutesdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/httproutes/{id}/ |  |
| [**KubernetesClustersHttproutesList**](KubernetesApi.md#kubernetesclustershttprouteslist) | **GET** /api/kubernetes/clusters/{cluster_id}/httproutes/ |  |
| [**KubernetesClustersHttproutesPartialUpdate**](KubernetesApi.md#kubernetesclustershttproutespartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/httproutes/{id}/ |  |
| [**KubernetesClustersHttproutesRetrieve**](KubernetesApi.md#kubernetesclustershttproutesretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/httproutes/{id}/ |  |
| [**KubernetesClustersHttproutesUpdate**](KubernetesApi.md#kubernetesclustershttproutesupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/httproutes/{id}/ |  |
| [**KubernetesClustersKubeVersionUpgradeCreate**](KubernetesApi.md#kubernetesclusterskubeversionupgradecreate) | **POST** /api/kubernetes/clusters/{id}/kube-version-upgrade/ |  |
| [**KubernetesClustersKubeconfigCreate**](KubernetesApi.md#kubernetesclusterskubeconfigcreate) | **POST** /api/kubernetes/clusters/{id}/kubeconfig/ |  |
| [**KubernetesClustersKubeconfigRetrieve**](KubernetesApi.md#kubernetesclusterskubeconfigretrieve) | **GET** /api/kubernetes/clusters/{id}/kubeconfig/ |  |
| [**KubernetesClustersLbFirewallCreate**](KubernetesApi.md#kubernetesclusterslbfirewallcreate) | **POST** /api/kubernetes/clusters/{cluster_id}/lb-firewall/ |  |
| [**KubernetesClustersLbFirewallDestroy**](KubernetesApi.md#kubernetesclusterslbfirewalldestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/lb-firewall/{id}/ |  |
| [**KubernetesClustersLbFirewallList**](KubernetesApi.md#kubernetesclusterslbfirewalllist) | **GET** /api/kubernetes/clusters/{cluster_id}/lb-firewall/ |  |
| [**KubernetesClustersLbFirewallPartialUpdate**](KubernetesApi.md#kubernetesclusterslbfirewallpartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/lb-firewall/{id}/ |  |
| [**KubernetesClustersLbFirewallRetrieve**](KubernetesApi.md#kubernetesclusterslbfirewallretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/lb-firewall/{id}/ |  |
| [**KubernetesClustersLbFirewallUpdate**](KubernetesApi.md#kubernetesclusterslbfirewallupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/lb-firewall/{id}/ |  |
| [**KubernetesClustersLbReimageCreate**](KubernetesApi.md#kubernetesclusterslbreimagecreate) | **POST** /api/kubernetes/clusters/{id}/lb-reimage/ |  |
| [**KubernetesClustersLbReimageRetrieve**](KubernetesApi.md#kubernetesclusterslbreimageretrieve) | **GET** /api/kubernetes/clusters/{id}/lb-reimage/ |  |
| [**KubernetesClustersList**](KubernetesApi.md#kubernetesclusterslist) | **GET** /api/kubernetes/clusters/ |  |
| [**KubernetesClustersNodeOperationsCancelCreate**](KubernetesApi.md#kubernetesclustersnodeoperationscancelcreate) | **POST** /api/kubernetes/clusters/{cluster_id}/node-operations/{id}/cancel/ |  |
| [**KubernetesClustersNodeOperationsList**](KubernetesApi.md#kubernetesclustersnodeoperationslist) | **GET** /api/kubernetes/clusters/{cluster_id}/node-operations/ |  |
| [**KubernetesClustersNodeOperationsRetrieve**](KubernetesApi.md#kubernetesclustersnodeoperationsretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/node-operations/{id}/ |  |
| [**KubernetesClustersNodeOperationsRetryCreate**](KubernetesApi.md#kubernetesclustersnodeoperationsretrycreate) | **POST** /api/kubernetes/clusters/{cluster_id}/node-operations/{id}/retry/ |  |
| [**KubernetesClustersPartialUpdate**](KubernetesApi.md#kubernetesclusterspartialupdate) | **PATCH** /api/kubernetes/clusters/{id}/ |  |
| [**KubernetesClustersPoolRemovalJournalsList**](KubernetesApi.md#kubernetesclusterspoolremovaljournalslist) | **GET** /api/kubernetes/clusters/{cluster_id}/pool-removal-journals/ |  |
| [**KubernetesClustersPoolRemovalJournalsRetrieve**](KubernetesApi.md#kubernetesclusterspoolremovaljournalsretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/pool-removal-journals/{id}/ |  |
| [**KubernetesClustersPortForwardsCreate**](KubernetesApi.md#kubernetesclustersportforwardscreate) | **POST** /api/kubernetes/clusters/{cluster_id}/port-forwards/ |  |
| [**KubernetesClustersPortForwardsDestroy**](KubernetesApi.md#kubernetesclustersportforwardsdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/port-forwards/{id}/ |  |
| [**KubernetesClustersPortForwardsList**](KubernetesApi.md#kubernetesclustersportforwardslist) | **GET** /api/kubernetes/clusters/{cluster_id}/port-forwards/ |  |
| [**KubernetesClustersPortForwardsPartialUpdate**](KubernetesApi.md#kubernetesclustersportforwardspartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/port-forwards/{id}/ |  |
| [**KubernetesClustersPortForwardsRetrieve**](KubernetesApi.md#kubernetesclustersportforwardsretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/port-forwards/{id}/ |  |
| [**KubernetesClustersPortForwardsUpdate**](KubernetesApi.md#kubernetesclustersportforwardsupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/port-forwards/{id}/ |  |
| [**KubernetesClustersResourcePoolsCreate**](KubernetesApi.md#kubernetesclustersresourcepoolscreate) | **POST** /api/kubernetes/clusters/{cluster_id}/resource-pools/ |  |
| [**KubernetesClustersResourcePoolsDestroy**](KubernetesApi.md#kubernetesclustersresourcepoolsdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/resource-pools/{id}/ |  |
| [**KubernetesClustersResourcePoolsList**](KubernetesApi.md#kubernetesclustersresourcepoolslist) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/ |  |
| [**KubernetesClustersResourcePoolsNodesDestroy**](KubernetesApi.md#kubernetesclustersresourcepoolsnodesdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/{id}/ |  |
| [**KubernetesClustersResourcePoolsNodesList**](KubernetesApi.md#kubernetesclustersresourcepoolsnodeslist) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/ |  |
| [**KubernetesClustersResourcePoolsNodesMetricsRetrieve**](KubernetesApi.md#kubernetesclustersresourcepoolsnodesmetricsretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/{id}/metrics/ |  |
| [**KubernetesClustersResourcePoolsNodesRebootCreate**](KubernetesApi.md#kubernetesclustersresourcepoolsnodesrebootcreate) | **POST** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/{id}/reboot/ |  |
| [**KubernetesClustersResourcePoolsNodesRetrieve**](KubernetesApi.md#kubernetesclustersresourcepoolsnodesretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/{id}/ |  |
| [**KubernetesClustersResourcePoolsNodesRrdRetrieve**](KubernetesApi.md#kubernetesclustersresourcepoolsnodesrrdretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/{pool_id}/nodes/{id}/rrd/ |  |
| [**KubernetesClustersResourcePoolsPartialUpdate**](KubernetesApi.md#kubernetesclustersresourcepoolspartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/resource-pools/{id}/ |  |
| [**KubernetesClustersResourcePoolsRetrieve**](KubernetesApi.md#kubernetesclustersresourcepoolsretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/resource-pools/{id}/ |  |
| [**KubernetesClustersResourcePoolsUpdate**](KubernetesApi.md#kubernetesclustersresourcepoolsupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/resource-pools/{id}/ |  |
| [**KubernetesClustersRetrieve**](KubernetesApi.md#kubernetesclustersretrieve) | **GET** /api/kubernetes/clusters/{id}/ |  |
| [**KubernetesClustersTalosVersionUpgradeCreate**](KubernetesApi.md#kubernetesclusterstalosversionupgradecreate) | **POST** /api/kubernetes/clusters/{id}/talos-version-upgrade/ |  |
| [**KubernetesClustersTcproutesCreate**](KubernetesApi.md#kubernetesclusterstcproutescreate) | **POST** /api/kubernetes/clusters/{cluster_id}/tcproutes/ |  |
| [**KubernetesClustersTcproutesDestroy**](KubernetesApi.md#kubernetesclusterstcproutesdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/tcproutes/{id}/ |  |
| [**KubernetesClustersTcproutesList**](KubernetesApi.md#kubernetesclusterstcprouteslist) | **GET** /api/kubernetes/clusters/{cluster_id}/tcproutes/ |  |
| [**KubernetesClustersTcproutesPartialUpdate**](KubernetesApi.md#kubernetesclusterstcproutespartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/tcproutes/{id}/ |  |
| [**KubernetesClustersTcproutesRetrieve**](KubernetesApi.md#kubernetesclusterstcproutesretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/tcproutes/{id}/ |  |
| [**KubernetesClustersTcproutesUpdate**](KubernetesApi.md#kubernetesclusterstcproutesupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/tcproutes/{id}/ |  |
| [**KubernetesClustersToggleCloudVmAccessCreate**](KubernetesApi.md#kubernetesclusterstogglecloudvmaccesscreate) | **POST** /api/kubernetes/clusters/{id}/toggle-cloud-vm-access/ |  |
| [**KubernetesClustersUdproutesCreate**](KubernetesApi.md#kubernetesclustersudproutescreate) | **POST** /api/kubernetes/clusters/{cluster_id}/udproutes/ |  |
| [**KubernetesClustersUdproutesDestroy**](KubernetesApi.md#kubernetesclustersudproutesdestroy) | **DELETE** /api/kubernetes/clusters/{cluster_id}/udproutes/{id}/ |  |
| [**KubernetesClustersUdproutesList**](KubernetesApi.md#kubernetesclustersudprouteslist) | **GET** /api/kubernetes/clusters/{cluster_id}/udproutes/ |  |
| [**KubernetesClustersUdproutesPartialUpdate**](KubernetesApi.md#kubernetesclustersudproutespartialupdate) | **PATCH** /api/kubernetes/clusters/{cluster_id}/udproutes/{id}/ |  |
| [**KubernetesClustersUdproutesRetrieve**](KubernetesApi.md#kubernetesclustersudproutesretrieve) | **GET** /api/kubernetes/clusters/{cluster_id}/udproutes/{id}/ |  |
| [**KubernetesClustersUdproutesUpdate**](KubernetesApi.md#kubernetesclustersudproutesupdate) | **PUT** /api/kubernetes/clusters/{cluster_id}/udproutes/{id}/ |  |
| [**KubernetesClustersUpdate**](KubernetesApi.md#kubernetesclustersupdate) | **PUT** /api/kubernetes/clusters/{id}/ |  |
| [**KubernetesClustersUpgradeFeatureCreate**](KubernetesApi.md#kubernetesclustersupgradefeaturecreate) | **POST** /api/kubernetes/clusters/{id}/upgrade-feature/ |  |
| [**KubernetesClustersUpgradeLbCreate**](KubernetesApi.md#kubernetesclustersupgradelbcreate) | **POST** /api/kubernetes/clusters/{id}/upgrade-lb/ |  |

<a id="kubernetesclustertypeslist"></a>
# **KubernetesClusterTypesList**
> PaginatedClusterTypeList KubernetesClusterTypesList (int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedClusterTypeList**](PaginatedClusterTypeList.md)

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

<a id="kubernetesclustersconnectvmcreate"></a>
# **KubernetesClustersConnectVmCreate**
> ConnectVMResponse KubernetesClustersConnectVmCreate (string id, ConnectVMRequest connectVMRequest)



Connect a cloud VM to the cluster private network.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **connectVMRequest** | [**ConnectVMRequest**](ConnectVMRequest.md) |  |  |

### Return type

[**ConnectVMResponse**](ConnectVMResponse.md)

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

<a id="kubernetesclustersconnectedvmsretrieve"></a>
# **KubernetesClustersConnectedVmsRetrieve**
> ConnectedVMsResponse KubernetesClustersConnectedVmsRetrieve (string id)



List cloud VMs connected to the cluster private network.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ConnectedVMsResponse**](ConnectedVMsResponse.md)

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

<a id="kubernetesclusterscreate"></a>
# **KubernetesClustersCreate**
> ClusterAddResponse KubernetesClustersCreate (ClusterAddRequest clusterAddRequest)



Create new k8s cluster


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterAddRequest** | [**ClusterAddRequest**](ClusterAddRequest.md) |  |  |

### Return type

[**ClusterAddResponse**](ClusterAddResponse.md)

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

<a id="kubernetesclustersdestroy"></a>
# **KubernetesClustersDestroy**
> void KubernetesClustersDestroy (string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


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

<a id="kubernetesclustersdisconnectvmcreate"></a>
# **KubernetesClustersDisconnectVmCreate**
> DisconnectVMResponse KubernetesClustersDisconnectVmCreate (string id, DisconnectVMRequest disconnectVMRequest)



Disconnect a cloud VM from the cluster private network.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **disconnectVMRequest** | [**DisconnectVMRequest**](DisconnectVMRequest.md) |  |  |

### Return type

[**DisconnectVMResponse**](DisconnectVMResponse.md)

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

<a id="kubernetesclusterseligiblevmsretrieve"></a>
# **KubernetesClustersEligibleVmsRetrieve**
> EligibleVMsResponse KubernetesClustersEligibleVmsRetrieve (string id)



List cloud VMs eligible for connection to this cluster.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**EligibleVMsResponse**](EligibleVMsResponse.md)

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

<a id="kubernetesclustersencryptioncreate"></a>
# **KubernetesClustersEncryptionCreate**
> ClusterEncryptionOperation KubernetesClustersEncryptionCreate (string id, ClusterEncryptionRequest clusterEncryptionRequest)



Enable or disable WireGuard encryption for cluster traffic.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clusterEncryptionRequest** | [**ClusterEncryptionRequest**](ClusterEncryptionRequest.md) |  |  |

### Return type

[**ClusterEncryptionOperation**](ClusterEncryptionOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustersencryptionrecheckcreate"></a>
# **KubernetesClustersEncryptionRecheckCreate**
> ClusterEncryption KubernetesClustersEncryptionRecheckCreate (string id)



Re-count the workloads that still predate the encryption change.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ClusterEncryption**](ClusterEncryption.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **409** |  |  -  |
| **429** |  |  -  |
| **503** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustersencryptionretrieve"></a>
# **KubernetesClustersEncryptionRetrieve**
> ClusterEncryption KubernetesClustersEncryptionRetrieve (string id)



Read the cluster's encryption state, restart gate and per-node verification evidence.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ClusterEncryption**](ClusterEncryption.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustershttproutescreate"></a>
# **KubernetesClustersHttproutesCreate**
> HTTPRoute KubernetesClustersHttproutesCreate (int clusterId, HTTPRouteRequest hTTPRouteRequest)



Create new HTTPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **hTTPRouteRequest** | [**HTTPRouteRequest**](HTTPRouteRequest.md) |  |  |

### Return type

[**HTTPRoute**](HTTPRoute.md)

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

<a id="kubernetesclustershttproutesdestroy"></a>
# **KubernetesClustersHttproutesDestroy**
> void KubernetesClustersHttproutesDestroy (int clusterId, string id)



ViewSet for managing HTTPRoute resources.  HTTPRoutes expose HTTP/HTTPS services through the Gateway with optional automatic TLS certificate issuance.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
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

<a id="kubernetesclustershttprouteslist"></a>
# **KubernetesClustersHttproutesList**
> PaginatedHTTPRouteList KubernetesClustersHttproutesList (int clusterId, int page = null)



ViewSet for managing HTTPRoute resources.  HTTPRoutes expose HTTP/HTTPS services through the Gateway with optional automatic TLS certificate issuance.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedHTTPRouteList**](PaginatedHTTPRouteList.md)

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

<a id="kubernetesclustershttproutespartialupdate"></a>
# **KubernetesClustersHttproutesPartialUpdate**
> HTTPRoute KubernetesClustersHttproutesPartialUpdate (int clusterId, string id, PatchedHTTPRouteRequest patchedHTTPRouteRequest = null)



Partially update HTTPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedHTTPRouteRequest** | [**PatchedHTTPRouteRequest**](PatchedHTTPRouteRequest.md) |  | [optional]  |

### Return type

[**HTTPRoute**](HTTPRoute.md)

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

<a id="kubernetesclustershttproutesretrieve"></a>
# **KubernetesClustersHttproutesRetrieve**
> HTTPRoute KubernetesClustersHttproutesRetrieve (int clusterId, string id)



ViewSet for managing HTTPRoute resources.  HTTPRoutes expose HTTP/HTTPS services through the Gateway with optional automatic TLS certificate issuance.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**HTTPRoute**](HTTPRoute.md)

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

<a id="kubernetesclustershttproutesupdate"></a>
# **KubernetesClustersHttproutesUpdate**
> HTTPRoute KubernetesClustersHttproutesUpdate (int clusterId, string id, HTTPRouteRequest hTTPRouteRequest)



Update HTTPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **hTTPRouteRequest** | [**HTTPRouteRequest**](HTTPRouteRequest.md) |  |  |

### Return type

[**HTTPRoute**](HTTPRoute.md)

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

<a id="kubernetesclusterskubeversionupgradecreate"></a>
# **KubernetesClustersKubeVersionUpgradeCreate**
> KubeUpgradeResponse KubernetesClustersKubeVersionUpgradeCreate (string id)



Upgrade kubernetes to the next available version.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**KubeUpgradeResponse**](KubeUpgradeResponse.md)

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

<a id="kubernetesclusterskubeconfigcreate"></a>
# **KubernetesClustersKubeconfigCreate**
> string KubernetesClustersKubeconfigCreate (string id)



Download kubeconfig file. Use POST to generate a new kubeconfig.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclusterskubeconfigretrieve"></a>
# **KubernetesClustersKubeconfigRetrieve**
> string KubernetesClustersKubeconfigRetrieve (string id)



Download kubeconfig file. Use POST to generate a new kubeconfig.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclusterslbfirewallcreate"></a>
# **KubernetesClustersLbFirewallCreate**
> LBFirewallRule KubernetesClustersLbFirewallCreate (int clusterId, LBFirewallRuleRequest lBFirewallRuleRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **lBFirewallRuleRequest** | [**LBFirewallRuleRequest**](LBFirewallRuleRequest.md) |  | [optional]  |

### Return type

[**LBFirewallRule**](LBFirewallRule.md)

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

<a id="kubernetesclusterslbfirewalldestroy"></a>
# **KubernetesClustersLbFirewallDestroy**
> void KubernetesClustersLbFirewallDestroy (int clusterId, string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
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

<a id="kubernetesclusterslbfirewalllist"></a>
# **KubernetesClustersLbFirewallList**
> PaginatedLBFirewallRuleList KubernetesClustersLbFirewallList (int clusterId, int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedLBFirewallRuleList**](PaginatedLBFirewallRuleList.md)

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

<a id="kubernetesclusterslbfirewallpartialupdate"></a>
# **KubernetesClustersLbFirewallPartialUpdate**
> LBFirewallRule KubernetesClustersLbFirewallPartialUpdate (int clusterId, string id, PatchedLBFirewallRuleRequest patchedLBFirewallRuleRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedLBFirewallRuleRequest** | [**PatchedLBFirewallRuleRequest**](PatchedLBFirewallRuleRequest.md) |  | [optional]  |

### Return type

[**LBFirewallRule**](LBFirewallRule.md)

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

<a id="kubernetesclusterslbfirewallretrieve"></a>
# **KubernetesClustersLbFirewallRetrieve**
> LBFirewallRule KubernetesClustersLbFirewallRetrieve (int clusterId, string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**LBFirewallRule**](LBFirewallRule.md)

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

<a id="kubernetesclusterslbfirewallupdate"></a>
# **KubernetesClustersLbFirewallUpdate**
> LBFirewallRule KubernetesClustersLbFirewallUpdate (int clusterId, string id, LBFirewallRuleRequest lBFirewallRuleRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **lBFirewallRuleRequest** | [**LBFirewallRuleRequest**](LBFirewallRuleRequest.md) |  | [optional]  |

### Return type

[**LBFirewallRule**](LBFirewallRule.md)

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

<a id="kubernetesclusterslbreimagecreate"></a>
# **KubernetesClustersLbReimageCreate**
> LBReimageStarted KubernetesClustersLbReimageCreate (string id, LBReimageRequest lBReimageRequest)



Start a load-balancer replacement now. Traffic through the load balancer stops while it is switched over. Support can roll back for 24 hours after it completes. OAuth access tokens cannot start one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **lBReimageRequest** | [**LBReimageRequest**](LBReimageRequest.md) |  |  |

### Return type

[**LBReimageStarted**](LBReimageStarted.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclusterslbreimageretrieve"></a>
# **KubernetesClustersLbReimageRetrieve**
> LBReimageStatus KubernetesClustersLbReimageRetrieve (string id)



Show the latest load-balancer replacement on this cluster and whether one can start now.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**LBReimageStatus**](LBReimageStatus.md)

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

<a id="kubernetesclusterslist"></a>
# **KubernetesClustersList**
> PaginatedClusterDetailList KubernetesClustersList (int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedClusterDetailList**](PaginatedClusterDetailList.md)

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

<a id="kubernetesclustersnodeoperationscancelcreate"></a>
# **KubernetesClustersNodeOperationsCancelCreate**
> NodeOperation KubernetesClustersNodeOperationsCancelCreate (int clusterId, string id)



Uncordon the node and abort a blocked operation.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**NodeOperation**](NodeOperation.md)

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

<a id="kubernetesclustersnodeoperationslist"></a>
# **KubernetesClustersNodeOperationsList**
> PaginatedNodeOperationList KubernetesClustersNodeOperationsList (int clusterId, int page = null)



Operation history, status, and the three recovery actions.  Cluster-level rather than node-level on purpose: a successful delete removes the VM row, so an operation addressable only through its node would stop being readable exactly when the customer wants to see how it ended.  None of these routes is gated on `K8S_NODE_OPERATIONS_ENABLED`. Turning new starts off must never strand an operation that is already running - - a cluster with a blocked operation and no way to answer it is a cluster nobody can mutate at all.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedNodeOperationList**](PaginatedNodeOperationList.md)

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

<a id="kubernetesclustersnodeoperationsretrieve"></a>
# **KubernetesClustersNodeOperationsRetrieve**
> NodeOperation KubernetesClustersNodeOperationsRetrieve (int clusterId, string id)



Operation history, status, and the three recovery actions.  Cluster-level rather than node-level on purpose: a successful delete removes the VM row, so an operation addressable only through its node would stop being readable exactly when the customer wants to see how it ended.  None of these routes is gated on `K8S_NODE_OPERATIONS_ENABLED`. Turning new starts off must never strand an operation that is already running - - a cluster with a blocked operation and no way to answer it is a cluster nobody can mutate at all.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**NodeOperation**](NodeOperation.md)

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

<a id="kubernetesclustersnodeoperationsretrycreate"></a>
# **KubernetesClustersNodeOperationsRetryCreate**
> NodeOperation KubernetesClustersNodeOperationsRetryCreate (int clusterId, string id, NodeOperationRetryRequest nodeOperationRetryRequest = null)



Retry a blocked operation with the overrides that answer its blocker.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **nodeOperationRetryRequest** | [**NodeOperationRetryRequest**](NodeOperationRetryRequest.md) |  | [optional]  |

### Return type

[**NodeOperation**](NodeOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclusterspartialupdate"></a>
# **KubernetesClustersPartialUpdate**
> ClusterDetail KubernetesClustersPartialUpdate (string id, PatchedClusterDetailRequest patchedClusterDetailRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **patchedClusterDetailRequest** | [**PatchedClusterDetailRequest**](PatchedClusterDetailRequest.md) |  | [optional]  |

### Return type

[**ClusterDetail**](ClusterDetail.md)

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

<a id="kubernetesclusterspoolremovaljournalslist"></a>
# **KubernetesClustersPoolRemovalJournalsList**
> PaginatedPoolRemovalJournalList KubernetesClustersPoolRemovalJournalsList (int clusterId, int page = null)



A downsize or pool deletion, its milestones, and its staff resume.  The list route is not in the spec's table and is here anyway: with retrieve as the only route, a customer whose downsize parked has no way to learn the journal id, and the panel's poll would be the sole path to a published REST resource.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedPoolRemovalJournalList**](PaginatedPoolRemovalJournalList.md)

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

<a id="kubernetesclusterspoolremovaljournalsretrieve"></a>
# **KubernetesClustersPoolRemovalJournalsRetrieve**
> PoolRemovalJournal KubernetesClustersPoolRemovalJournalsRetrieve (int clusterId, string id)



A downsize or pool deletion, its milestones, and its staff resume.  The list route is not in the spec's table and is here anyway: with retrieve as the only route, a customer whose downsize parked has no way to learn the journal id, and the panel's poll would be the sole path to a published REST resource.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**PoolRemovalJournal**](PoolRemovalJournal.md)

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

<a id="kubernetesclustersportforwardscreate"></a>
# **KubernetesClustersPortForwardsCreate**
> K8sPortForward KubernetesClustersPortForwardsCreate (int clusterId, K8sPortForwardRequest k8sPortForwardRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **k8sPortForwardRequest** | [**K8sPortForwardRequest**](K8sPortForwardRequest.md) |  |  |

### Return type

[**K8sPortForward**](K8sPortForward.md)

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

<a id="kubernetesclustersportforwardsdestroy"></a>
# **KubernetesClustersPortForwardsDestroy**
> void KubernetesClustersPortForwardsDestroy (int clusterId, string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
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

<a id="kubernetesclustersportforwardslist"></a>
# **KubernetesClustersPortForwardsList**
> PaginatedK8sPortForwardList KubernetesClustersPortForwardsList (int clusterId, int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedK8sPortForwardList**](PaginatedK8sPortForwardList.md)

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

<a id="kubernetesclustersportforwardspartialupdate"></a>
# **KubernetesClustersPortForwardsPartialUpdate**
> K8sPortForward KubernetesClustersPortForwardsPartialUpdate (int clusterId, string id, PatchedK8sPortForwardRequest patchedK8sPortForwardRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedK8sPortForwardRequest** | [**PatchedK8sPortForwardRequest**](PatchedK8sPortForwardRequest.md) |  | [optional]  |

### Return type

[**K8sPortForward**](K8sPortForward.md)

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

<a id="kubernetesclustersportforwardsretrieve"></a>
# **KubernetesClustersPortForwardsRetrieve**
> K8sPortForward KubernetesClustersPortForwardsRetrieve (int clusterId, string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**K8sPortForward**](K8sPortForward.md)

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

<a id="kubernetesclustersportforwardsupdate"></a>
# **KubernetesClustersPortForwardsUpdate**
> K8sPortForward KubernetesClustersPortForwardsUpdate (int clusterId, string id, K8sPortForwardRequest k8sPortForwardRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **k8sPortForwardRequest** | [**K8sPortForwardRequest**](K8sPortForwardRequest.md) |  |  |

### Return type

[**K8sPortForward**](K8sPortForward.md)

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

<a id="kubernetesclustersresourcepoolscreate"></a>
# **KubernetesClustersResourcePoolsCreate**
> ResourcePoolAddResponse KubernetesClustersResourcePoolsCreate (int clusterId, ResourcePoolAddRequest resourcePoolAddRequest)



Create new resource pool


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **resourcePoolAddRequest** | [**ResourcePoolAddRequest**](ResourcePoolAddRequest.md) |  |  |

### Return type

[**ResourcePoolAddResponse**](ResourcePoolAddResponse.md)

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

<a id="kubernetesclustersresourcepoolsdestroy"></a>
# **KubernetesClustersResourcePoolsDestroy**
> void KubernetesClustersResourcePoolsDestroy (int clusterId, string id, ResourcePoolDeleteRequest resourcePoolDeleteRequest = null)



Delete a resource pool and every node in it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **resourcePoolDeleteRequest** | [**ResourcePoolDeleteRequest**](ResourcePoolDeleteRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustersresourcepoolslist"></a>
# **KubernetesClustersResourcePoolsList**
> PaginatedResourcePoolList KubernetesClustersResourcePoolsList (int clusterId, int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedResourcePoolList**](PaginatedResourcePoolList.md)

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

<a id="kubernetesclustersresourcepoolsnodesdestroy"></a>
# **KubernetesClustersResourcePoolsNodesDestroy**
> NodeOperation KubernetesClustersResourcePoolsNodesDestroy (int clusterId, string id, int poolId, NodeOperationDeleteRequest nodeOperationDeleteRequest = null)



Start a safe delete of one worker node.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **poolId** | **int** |  |  |
| **nodeOperationDeleteRequest** | [**NodeOperationDeleteRequest**](NodeOperationDeleteRequest.md) |  | [optional]  |

### Return type

[**NodeOperation**](NodeOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustersresourcepoolsnodeslist"></a>
# **KubernetesClustersResourcePoolsNodesList**
> PaginatedResourcePoolNodeList KubernetesClustersResourcePoolsNodesList (int clusterId, int poolId, int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **poolId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedResourcePoolNodeList**](PaginatedResourcePoolNodeList.md)

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

<a id="kubernetesclustersresourcepoolsnodesmetricsretrieve"></a>
# **KubernetesClustersResourcePoolsNodesMetricsRetrieve**
> NodeMetricsResponse KubernetesClustersResourcePoolsNodesMetricsRetrieve (int clusterId, string id, int poolId)



Get real-time metrics for a node VM.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **poolId** | **int** |  |  |

### Return type

[**NodeMetricsResponse**](NodeMetricsResponse.md)

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

<a id="kubernetesclustersresourcepoolsnodesrebootcreate"></a>
# **KubernetesClustersResourcePoolsNodesRebootCreate**
> NodeOperation KubernetesClustersResourcePoolsNodesRebootCreate (int clusterId, string id, int poolId, NodeOperationRebootRequest nodeOperationRebootRequest = null)



Restart one worker node, draining it first.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **poolId** | **int** |  |  |
| **nodeOperationRebootRequest** | [**NodeOperationRebootRequest**](NodeOperationRebootRequest.md) |  | [optional]  |

### Return type

[**NodeOperation**](NodeOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kubernetesclustersresourcepoolsnodesretrieve"></a>
# **KubernetesClustersResourcePoolsNodesRetrieve**
> ResourcePoolNode KubernetesClustersResourcePoolsNodesRetrieve (int clusterId, string id, int poolId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **poolId** | **int** |  |  |

### Return type

[**ResourcePoolNode**](ResourcePoolNode.md)

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

<a id="kubernetesclustersresourcepoolsnodesrrdretrieve"></a>
# **KubernetesClustersResourcePoolsNodesRrdRetrieve**
> NodeRRDResponse KubernetesClustersResourcePoolsNodesRrdRetrieve (int clusterId, string id, int poolId, string timeframe = null)



Get RRD (historical) metrics data for a node VM.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **poolId** | **int** |  |  |
| **timeframe** | **string** | Window of recorded data to return. | [optional] [default to hour] |

### Return type

[**NodeRRDResponse**](NodeRRDResponse.md)

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

<a id="kubernetesclustersresourcepoolspartialupdate"></a>
# **KubernetesClustersResourcePoolsPartialUpdate**
> ResourcePool KubernetesClustersResourcePoolsPartialUpdate (int clusterId, string id, PatchedResourcePoolRequest patchedResourcePoolRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedResourcePoolRequest** | [**PatchedResourcePoolRequest**](PatchedResourcePoolRequest.md) |  | [optional]  |

### Return type

[**ResourcePool**](ResourcePool.md)

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

<a id="kubernetesclustersresourcepoolsretrieve"></a>
# **KubernetesClustersResourcePoolsRetrieve**
> ResourcePool KubernetesClustersResourcePoolsRetrieve (int clusterId, string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**ResourcePool**](ResourcePool.md)

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

<a id="kubernetesclustersresourcepoolsupdate"></a>
# **KubernetesClustersResourcePoolsUpdate**
> ResourcePool KubernetesClustersResourcePoolsUpdate (int clusterId, string id, ResourcePoolRequest resourcePoolRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **resourcePoolRequest** | [**ResourcePoolRequest**](ResourcePoolRequest.md) |  | [optional]  |

### Return type

[**ResourcePool**](ResourcePool.md)

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

<a id="kubernetesclustersretrieve"></a>
# **KubernetesClustersRetrieve**
> ClusterDetail KubernetesClustersRetrieve (string id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ClusterDetail**](ClusterDetail.md)

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

<a id="kubernetesclusterstalosversionupgradecreate"></a>
# **KubernetesClustersTalosVersionUpgradeCreate**
> TalosUpgradeResponse KubernetesClustersTalosVersionUpgradeCreate (string id)



Upgrade Talos to the next available version.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**TalosUpgradeResponse**](TalosUpgradeResponse.md)

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

<a id="kubernetesclusterstcproutescreate"></a>
# **KubernetesClustersTcproutesCreate**
> TCPRoute KubernetesClustersTcproutesCreate (int clusterId, TCPRouteRequest tCPRouteRequest)



Create new TCPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **tCPRouteRequest** | [**TCPRouteRequest**](TCPRouteRequest.md) |  |  |

### Return type

[**TCPRoute**](TCPRoute.md)

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

<a id="kubernetesclusterstcproutesdestroy"></a>
# **KubernetesClustersTcproutesDestroy**
> void KubernetesClustersTcproutesDestroy (int clusterId, string id)



ViewSet for managing TCPRoute resources.  TCPRoutes expose TCP services through the Gateway on specific external ports. Reserved ports (22, 6443, 50000, 50001) cannot be exposed.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
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

<a id="kubernetesclusterstcprouteslist"></a>
# **KubernetesClustersTcproutesList**
> PaginatedTCPRouteList KubernetesClustersTcproutesList (int clusterId, int page = null)



ViewSet for managing TCPRoute resources.  TCPRoutes expose TCP services through the Gateway on specific external ports. Reserved ports (22, 6443, 50000, 50001) cannot be exposed.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedTCPRouteList**](PaginatedTCPRouteList.md)

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

<a id="kubernetesclusterstcproutespartialupdate"></a>
# **KubernetesClustersTcproutesPartialUpdate**
> TCPRoute KubernetesClustersTcproutesPartialUpdate (int clusterId, string id, PatchedTCPRouteRequest patchedTCPRouteRequest = null)



Partially update TCPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedTCPRouteRequest** | [**PatchedTCPRouteRequest**](PatchedTCPRouteRequest.md) |  | [optional]  |

### Return type

[**TCPRoute**](TCPRoute.md)

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

<a id="kubernetesclusterstcproutesretrieve"></a>
# **KubernetesClustersTcproutesRetrieve**
> TCPRoute KubernetesClustersTcproutesRetrieve (int clusterId, string id)



ViewSet for managing TCPRoute resources.  TCPRoutes expose TCP services through the Gateway on specific external ports. Reserved ports (22, 6443, 50000, 50001) cannot be exposed.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**TCPRoute**](TCPRoute.md)

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

<a id="kubernetesclusterstcproutesupdate"></a>
# **KubernetesClustersTcproutesUpdate**
> TCPRoute KubernetesClustersTcproutesUpdate (int clusterId, string id, TCPRouteRequest tCPRouteRequest)



Update TCPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **tCPRouteRequest** | [**TCPRouteRequest**](TCPRouteRequest.md) |  |  |

### Return type

[**TCPRoute**](TCPRoute.md)

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

<a id="kubernetesclusterstogglecloudvmaccesscreate"></a>
# **KubernetesClustersToggleCloudVmAccessCreate**
> ToggleCloudVMAccessResponse KubernetesClustersToggleCloudVmAccessCreate (string id)



Toggle cloud VM access for this cluster.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ToggleCloudVMAccessResponse**](ToggleCloudVMAccessResponse.md)

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

<a id="kubernetesclustersudproutescreate"></a>
# **KubernetesClustersUdproutesCreate**
> UDPRoute KubernetesClustersUdproutesCreate (int clusterId, UDPRouteRequest uDPRouteRequest)



Create new UDPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **uDPRouteRequest** | [**UDPRouteRequest**](UDPRouteRequest.md) |  |  |

### Return type

[**UDPRoute**](UDPRoute.md)

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

<a id="kubernetesclustersudproutesdestroy"></a>
# **KubernetesClustersUdproutesDestroy**
> void KubernetesClustersUdproutesDestroy (int clusterId, string id)



ViewSet for managing UDPRoute resources.  UDPRoutes expose UDP services through the Gateway on specific external ports.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
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

<a id="kubernetesclustersudprouteslist"></a>
# **KubernetesClustersUdproutesList**
> PaginatedUDPRouteList KubernetesClustersUdproutesList (int clusterId, int page = null)



ViewSet for managing UDPRoute resources.  UDPRoutes expose UDP services through the Gateway on specific external ports.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedUDPRouteList**](PaginatedUDPRouteList.md)

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

<a id="kubernetesclustersudproutespartialupdate"></a>
# **KubernetesClustersUdproutesPartialUpdate**
> UDPRoute KubernetesClustersUdproutesPartialUpdate (int clusterId, string id, PatchedUDPRouteRequest patchedUDPRouteRequest = null)



Partially update UDPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **patchedUDPRouteRequest** | [**PatchedUDPRouteRequest**](PatchedUDPRouteRequest.md) |  | [optional]  |

### Return type

[**UDPRoute**](UDPRoute.md)

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

<a id="kubernetesclustersudproutesretrieve"></a>
# **KubernetesClustersUdproutesRetrieve**
> UDPRoute KubernetesClustersUdproutesRetrieve (int clusterId, string id)



ViewSet for managing UDPRoute resources.  UDPRoutes expose UDP services through the Gateway on specific external ports.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**UDPRoute**](UDPRoute.md)

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

<a id="kubernetesclustersudproutesupdate"></a>
# **KubernetesClustersUdproutesUpdate**
> UDPRoute KubernetesClustersUdproutesUpdate (int clusterId, string id, UDPRouteRequest uDPRouteRequest)



Update UDPRoute


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterId** | **int** |  |  |
| **id** | **string** |  |  |
| **uDPRouteRequest** | [**UDPRouteRequest**](UDPRouteRequest.md) |  |  |

### Return type

[**UDPRoute**](UDPRoute.md)

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

<a id="kubernetesclustersupdate"></a>
# **KubernetesClustersUpdate**
> ClusterDetail KubernetesClustersUpdate (string id, ClusterDetailRequest clusterDetailRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clusterDetailRequest** | [**ClusterDetailRequest**](ClusterDetailRequest.md) |  | [optional]  |

### Return type

[**ClusterDetail**](ClusterDetail.md)

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

<a id="kubernetesclustersupgradefeaturecreate"></a>
# **KubernetesClustersUpgradeFeatureCreate**
> FeatureUpgradeResponse KubernetesClustersUpgradeFeatureCreate (string id, FeatureUpgradeRequest featureUpgradeRequest)



Upgrade a cluster feature to the latest compatible version.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **featureUpgradeRequest** | [**FeatureUpgradeRequest**](FeatureUpgradeRequest.md) |  |  |

### Return type

[**FeatureUpgradeResponse**](FeatureUpgradeResponse.md)

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

<a id="kubernetesclustersupgradelbcreate"></a>
# **KubernetesClustersUpgradeLbCreate**
> LBUpgradePlanResponse KubernetesClustersUpgradeLbCreate (string id, LBUpgradeRequest lBUpgradeRequest = null)



Inspect or perform the load-balancer upgrade the server computes for this cluster. The caller never selects a level.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **lBUpgradeRequest** | [**LBUpgradeRequest**](LBUpgradeRequest.md) |  | [optional]  |

### Return type

[**LBUpgradePlanResponse**](LBUpgradePlanResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


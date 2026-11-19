# PidginHost.Sdk.Api.CloudApi

All URIs are relative to *https://www.pidginhost.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloudBucketsCreate**](CloudApi.md#cloudbucketscreate) | **POST** /api/cloud/buckets/ |  |
| [**CloudBucketsCredentialsRevealCreate**](CloudApi.md#cloudbucketscredentialsrevealcreate) | **POST** /api/cloud/buckets/{id}/credentials/reveal/ |  |
| [**CloudBucketsCredentialsRotateCreate**](CloudApi.md#cloudbucketscredentialsrotatecreate) | **POST** /api/cloud/buckets/{id}/credentials/rotate/ |  |
| [**CloudBucketsDestroy**](CloudApi.md#cloudbucketsdestroy) | **DELETE** /api/cloud/buckets/{id}/ |  |
| [**CloudBucketsDestroyProtectionCreate**](CloudApi.md#cloudbucketsdestroyprotectioncreate) | **POST** /api/cloud/buckets/{id}/destroy-protection/ |  |
| [**CloudBucketsList**](CloudApi.md#cloudbucketslist) | **GET** /api/cloud/buckets/ |  |
| [**CloudBucketsResizeCreate**](CloudApi.md#cloudbucketsresizecreate) | **POST** /api/cloud/buckets/{id}/resize/ |  |
| [**CloudBucketsRetrieve**](CloudApi.md#cloudbucketsretrieve) | **GET** /api/cloud/buckets/{id}/ |  |
| [**CloudBucketsVisibilityCreate**](CloudApi.md#cloudbucketsvisibilitycreate) | **POST** /api/cloud/buckets/{id}/visibility/ |  |
| [**CloudFirewallRulesSetCreate**](CloudApi.md#cloudfirewallrulessetcreate) | **POST** /api/cloud/firewall-rules-set/ |  |
| [**CloudFirewallRulesSetDestroy**](CloudApi.md#cloudfirewallrulessetdestroy) | **DELETE** /api/cloud/firewall-rules-set/{id}/ |  |
| [**CloudFirewallRulesSetList**](CloudApi.md#cloudfirewallrulessetlist) | **GET** /api/cloud/firewall-rules-set/ |  |
| [**CloudFirewallRulesSetPartialUpdate**](CloudApi.md#cloudfirewallrulessetpartialupdate) | **PATCH** /api/cloud/firewall-rules-set/{id}/ |  |
| [**CloudFirewallRulesSetRetrieve**](CloudApi.md#cloudfirewallrulessetretrieve) | **GET** /api/cloud/firewall-rules-set/{id}/ |  |
| [**CloudFirewallRulesSetRulesCreate**](CloudApi.md#cloudfirewallrulessetrulescreate) | **POST** /api/cloud/firewall-rules-set/{rules_set_id}/rules/ |  |
| [**CloudFirewallRulesSetRulesDestroy**](CloudApi.md#cloudfirewallrulessetrulesdestroy) | **DELETE** /api/cloud/firewall-rules-set/{rules_set_id}/rules/{rule_id}/ |  |
| [**CloudFirewallRulesSetRulesList**](CloudApi.md#cloudfirewallrulessetruleslist) | **GET** /api/cloud/firewall-rules-set/{rules_set_id}/rules/ |  |
| [**CloudFirewallRulesSetRulesPartialUpdate**](CloudApi.md#cloudfirewallrulessetrulespartialupdate) | **PATCH** /api/cloud/firewall-rules-set/{rules_set_id}/rules/{rule_id}/ |  |
| [**CloudFirewallRulesSetRulesRetrieve**](CloudApi.md#cloudfirewallrulessetrulesretrieve) | **GET** /api/cloud/firewall-rules-set/{rules_set_id}/rules/{rule_id}/ |  |
| [**CloudFirewallRulesSetRulesUpdate**](CloudApi.md#cloudfirewallrulessetrulesupdate) | **PUT** /api/cloud/firewall-rules-set/{rules_set_id}/rules/{rule_id}/ |  |
| [**CloudFirewallRulesSetUpdate**](CloudApi.md#cloudfirewallrulessetupdate) | **PUT** /api/cloud/firewall-rules-set/{id}/ |  |
| [**CloudFloatingIpv4AuthorizationsList**](CloudApi.md#cloudfloatingipv4authorizationslist) | **GET** /api/cloud/floating-ipv4/{id}/authorizations/ |  |
| [**CloudFloatingIpv4AuthorizeCreate**](CloudApi.md#cloudfloatingipv4authorizecreate) | **POST** /api/cloud/floating-ipv4/{id}/authorize/ |  |
| [**CloudFloatingIpv4Create**](CloudApi.md#cloudfloatingipv4create) | **POST** /api/cloud/floating-ipv4/ |  |
| [**CloudFloatingIpv4Destroy**](CloudApi.md#cloudfloatingipv4destroy) | **DELETE** /api/cloud/floating-ipv4/{id}/ |  |
| [**CloudFloatingIpv4List**](CloudApi.md#cloudfloatingipv4list) | **GET** /api/cloud/floating-ipv4/ |  |
| [**CloudFloatingIpv4RdnsCreate**](CloudApi.md#cloudfloatingipv4rdnscreate) | **POST** /api/cloud/floating-ipv4/{id}/rdns/ |  |
| [**CloudFloatingIpv4RdnsRetrieve**](CloudApi.md#cloudfloatingipv4rdnsretrieve) | **GET** /api/cloud/floating-ipv4/{id}/rdns/ |  |
| [**CloudFloatingIpv4Retrieve**](CloudApi.md#cloudfloatingipv4retrieve) | **GET** /api/cloud/floating-ipv4/{id}/ |  |
| [**CloudFloatingIpv4UnauthorizeCreate**](CloudApi.md#cloudfloatingipv4unauthorizecreate) | **POST** /api/cloud/floating-ipv4/{id}/unauthorize/ |  |
| [**CloudFloatingIpv6AuthorizationsList**](CloudApi.md#cloudfloatingipv6authorizationslist) | **GET** /api/cloud/floating-ipv6/{id}/authorizations/ |  |
| [**CloudFloatingIpv6AuthorizeCreate**](CloudApi.md#cloudfloatingipv6authorizecreate) | **POST** /api/cloud/floating-ipv6/{id}/authorize/ |  |
| [**CloudFloatingIpv6Create**](CloudApi.md#cloudfloatingipv6create) | **POST** /api/cloud/floating-ipv6/ |  |
| [**CloudFloatingIpv6Destroy**](CloudApi.md#cloudfloatingipv6destroy) | **DELETE** /api/cloud/floating-ipv6/{id}/ |  |
| [**CloudFloatingIpv6List**](CloudApi.md#cloudfloatingipv6list) | **GET** /api/cloud/floating-ipv6/ |  |
| [**CloudFloatingIpv6RdnsCreate**](CloudApi.md#cloudfloatingipv6rdnscreate) | **POST** /api/cloud/floating-ipv6/{id}/rdns/ |  |
| [**CloudFloatingIpv6RdnsRetrieve**](CloudApi.md#cloudfloatingipv6rdnsretrieve) | **GET** /api/cloud/floating-ipv6/{id}/rdns/ |  |
| [**CloudFloatingIpv6Retrieve**](CloudApi.md#cloudfloatingipv6retrieve) | **GET** /api/cloud/floating-ipv6/{id}/ |  |
| [**CloudFloatingIpv6UnauthorizeCreate**](CloudApi.md#cloudfloatingipv6unauthorizecreate) | **POST** /api/cloud/floating-ipv6/{id}/unauthorize/ |  |
| [**CloudGatewaysCreate**](CloudApi.md#cloudgatewayscreate) | **POST** /api/cloud/gateways/ |  |
| [**CloudGatewaysDestroy**](CloudApi.md#cloudgatewaysdestroy) | **DELETE** /api/cloud/gateways/{id}/ |  |
| [**CloudGatewaysFirewallRulesCreate**](CloudApi.md#cloudgatewaysfirewallrulescreate) | **POST** /api/cloud/gateways/{gateway_id}/firewall-rules/ |  |
| [**CloudGatewaysFirewallRulesDestroy**](CloudApi.md#cloudgatewaysfirewallrulesdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/firewall-rules/{id}/ |  |
| [**CloudGatewaysFirewallRulesList**](CloudApi.md#cloudgatewaysfirewallruleslist) | **GET** /api/cloud/gateways/{gateway_id}/firewall-rules/ |  |
| [**CloudGatewaysFirewallRulesMoveCreate**](CloudApi.md#cloudgatewaysfirewallrulesmovecreate) | **POST** /api/cloud/gateways/{gateway_id}/firewall-rules/{id}/move/ |  |
| [**CloudGatewaysFirewallRulesPartialUpdate**](CloudApi.md#cloudgatewaysfirewallrulespartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/firewall-rules/{id}/ |  |
| [**CloudGatewaysFirewallRulesRetrieve**](CloudApi.md#cloudgatewaysfirewallrulesretrieve) | **GET** /api/cloud/gateways/{gateway_id}/firewall-rules/{id}/ |  |
| [**CloudGatewaysList**](CloudApi.md#cloudgatewayslist) | **GET** /api/cloud/gateways/ |  |
| [**CloudGatewaysListenersCreate**](CloudApi.md#cloudgatewayslistenerscreate) | **POST** /api/cloud/gateways/{gateway_id}/listeners/ |  |
| [**CloudGatewaysListenersDestroy**](CloudApi.md#cloudgatewayslistenersdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/listeners/{id}/ |  |
| [**CloudGatewaysListenersList**](CloudApi.md#cloudgatewayslistenerslist) | **GET** /api/cloud/gateways/{gateway_id}/listeners/ |  |
| [**CloudGatewaysListenersPartialUpdate**](CloudApi.md#cloudgatewayslistenerspartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/listeners/{id}/ |  |
| [**CloudGatewaysListenersRetrieve**](CloudApi.md#cloudgatewayslistenersretrieve) | **GET** /api/cloud/gateways/{gateway_id}/listeners/{id}/ |  |
| [**CloudGatewaysListenersRoutesCreate**](CloudApi.md#cloudgatewayslistenersroutescreate) | **POST** /api/cloud/gateways/{gateway_id}/listeners/{listener_id}/routes/ |  |
| [**CloudGatewaysListenersRoutesDestroy**](CloudApi.md#cloudgatewayslistenersroutesdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/listeners/{listener_id}/routes/{id}/ |  |
| [**CloudGatewaysListenersRoutesList**](CloudApi.md#cloudgatewayslistenersrouteslist) | **GET** /api/cloud/gateways/{gateway_id}/listeners/{listener_id}/routes/ |  |
| [**CloudGatewaysListenersRoutesPartialUpdate**](CloudApi.md#cloudgatewayslistenersroutespartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/listeners/{listener_id}/routes/{id}/ |  |
| [**CloudGatewaysListenersRoutesRetrieve**](CloudApi.md#cloudgatewayslistenersroutesretrieve) | **GET** /api/cloud/gateways/{gateway_id}/listeners/{listener_id}/routes/{id}/ |  |
| [**CloudGatewaysNetworksCreate**](CloudApi.md#cloudgatewaysnetworkscreate) | **POST** /api/cloud/gateways/{gateway_id}/networks/ |  |
| [**CloudGatewaysNetworksDestroy**](CloudApi.md#cloudgatewaysnetworksdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/networks/{network_id}/ |  |
| [**CloudGatewaysNetworksList**](CloudApi.md#cloudgatewaysnetworkslist) | **GET** /api/cloud/gateways/{gateway_id}/networks/ |  |
| [**CloudGatewaysNetworksPartialUpdate**](CloudApi.md#cloudgatewaysnetworkspartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/networks/{network_id}/ |  |
| [**CloudGatewaysNetworksRetrieve**](CloudApi.md#cloudgatewaysnetworksretrieve) | **GET** /api/cloud/gateways/{gateway_id}/networks/{network_id}/ |  |
| [**CloudGatewaysOperationsList**](CloudApi.md#cloudgatewaysoperationslist) | **GET** /api/cloud/gateways/{gateway_id}/operations/ |  |
| [**CloudGatewaysOperationsRetrieve**](CloudApi.md#cloudgatewaysoperationsretrieve) | **GET** /api/cloud/gateways/{gateway_id}/operations/{id}/ |  |
| [**CloudGatewaysPartialUpdate**](CloudApi.md#cloudgatewayspartialupdate) | **PATCH** /api/cloud/gateways/{id}/ |  |
| [**CloudGatewaysPoolsBackendsCreate**](CloudApi.md#cloudgatewayspoolsbackendscreate) | **POST** /api/cloud/gateways/{gateway_id}/pools/{pool_id}/backends/ |  |
| [**CloudGatewaysPoolsBackendsDestroy**](CloudApi.md#cloudgatewayspoolsbackendsdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/pools/{pool_id}/backends/{id}/ |  |
| [**CloudGatewaysPoolsBackendsList**](CloudApi.md#cloudgatewayspoolsbackendslist) | **GET** /api/cloud/gateways/{gateway_id}/pools/{pool_id}/backends/ |  |
| [**CloudGatewaysPoolsBackendsPartialUpdate**](CloudApi.md#cloudgatewayspoolsbackendspartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/pools/{pool_id}/backends/{id}/ |  |
| [**CloudGatewaysPoolsBackendsRetrieve**](CloudApi.md#cloudgatewayspoolsbackendsretrieve) | **GET** /api/cloud/gateways/{gateway_id}/pools/{pool_id}/backends/{id}/ |  |
| [**CloudGatewaysPoolsCreate**](CloudApi.md#cloudgatewayspoolscreate) | **POST** /api/cloud/gateways/{gateway_id}/pools/ |  |
| [**CloudGatewaysPoolsDestroy**](CloudApi.md#cloudgatewayspoolsdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/pools/{id}/ |  |
| [**CloudGatewaysPoolsList**](CloudApi.md#cloudgatewayspoolslist) | **GET** /api/cloud/gateways/{gateway_id}/pools/ |  |
| [**CloudGatewaysPoolsPartialUpdate**](CloudApi.md#cloudgatewayspoolspartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/pools/{id}/ |  |
| [**CloudGatewaysPoolsRetrieve**](CloudApi.md#cloudgatewayspoolsretrieve) | **GET** /api/cloud/gateways/{gateway_id}/pools/{id}/ |  |
| [**CloudGatewaysPortForwardsCreate**](CloudApi.md#cloudgatewaysportforwardscreate) | **POST** /api/cloud/gateways/{gateway_id}/port-forwards/ |  |
| [**CloudGatewaysPortForwardsDestroy**](CloudApi.md#cloudgatewaysportforwardsdestroy) | **DELETE** /api/cloud/gateways/{gateway_id}/port-forwards/{id}/ |  |
| [**CloudGatewaysPortForwardsList**](CloudApi.md#cloudgatewaysportforwardslist) | **GET** /api/cloud/gateways/{gateway_id}/port-forwards/ |  |
| [**CloudGatewaysPortForwardsPartialUpdate**](CloudApi.md#cloudgatewaysportforwardspartialupdate) | **PATCH** /api/cloud/gateways/{gateway_id}/port-forwards/{id}/ |  |
| [**CloudGatewaysPortForwardsRetrieve**](CloudApi.md#cloudgatewaysportforwardsretrieve) | **GET** /api/cloud/gateways/{gateway_id}/port-forwards/{id}/ |  |
| [**CloudGatewaysReenrollCreate**](CloudApi.md#cloudgatewaysreenrollcreate) | **POST** /api/cloud/gateways/{id}/reenroll/ |  |
| [**CloudGatewaysRetrieve**](CloudApi.md#cloudgatewaysretrieve) | **GET** /api/cloud/gateways/{id}/ |  |
| [**CloudGatewaysStatusRetrieve**](CloudApi.md#cloudgatewaysstatusretrieve) | **GET** /api/cloud/gateways/{id}/status/ |  |
| [**CloudGenerationsList**](CloudApi.md#cloudgenerationslist) | **GET** /api/cloud/generations/ | List hardware generations |
| [**CloudGenerationsRetrieve**](CloudApi.md#cloudgenerationsretrieve) | **GET** /api/cloud/generations/{slug}/ |  |
| [**CloudImagesList**](CloudApi.md#cloudimageslist) | **GET** /api/cloud/images/ |  |
| [**CloudImagesRetrieve**](CloudApi.md#cloudimagesretrieve) | **GET** /api/cloud/images/{id}/ |  |
| [**CloudIpv4Create**](CloudApi.md#cloudipv4create) | **POST** /api/cloud/ipv4/ |  |
| [**CloudIpv4Destroy**](CloudApi.md#cloudipv4destroy) | **DELETE** /api/cloud/ipv4/{id}/ |  |
| [**CloudIpv4DetachCreate**](CloudApi.md#cloudipv4detachcreate) | **POST** /api/cloud/ipv4/{id}/detach/ |  |
| [**CloudIpv4List**](CloudApi.md#cloudipv4list) | **GET** /api/cloud/ipv4/ |  |
| [**CloudIpv4RdnsCreate**](CloudApi.md#cloudipv4rdnscreate) | **POST** /api/cloud/ipv4/{id}/rdns/ |  |
| [**CloudIpv4RdnsRetrieve**](CloudApi.md#cloudipv4rdnsretrieve) | **GET** /api/cloud/ipv4/{id}/rdns/ |  |
| [**CloudIpv4Retrieve**](CloudApi.md#cloudipv4retrieve) | **GET** /api/cloud/ipv4/{id}/ |  |
| [**CloudIpv6Create**](CloudApi.md#cloudipv6create) | **POST** /api/cloud/ipv6/ |  |
| [**CloudIpv6Destroy**](CloudApi.md#cloudipv6destroy) | **DELETE** /api/cloud/ipv6/{id}/ |  |
| [**CloudIpv6DetachCreate**](CloudApi.md#cloudipv6detachcreate) | **POST** /api/cloud/ipv6/{id}/detach/ |  |
| [**CloudIpv6List**](CloudApi.md#cloudipv6list) | **GET** /api/cloud/ipv6/ |  |
| [**CloudIpv6RdnsCreate**](CloudApi.md#cloudipv6rdnscreate) | **POST** /api/cloud/ipv6/{id}/rdns/ |  |
| [**CloudIpv6RdnsRetrieve**](CloudApi.md#cloudipv6rdnsretrieve) | **GET** /api/cloud/ipv6/{id}/rdns/ |  |
| [**CloudIpv6Retrieve**](CloudApi.md#cloudipv6retrieve) | **GET** /api/cloud/ipv6/{id}/ |  |
| [**CloudPrivateNetworksAddServerCreate**](CloudApi.md#cloudprivatenetworksaddservercreate) | **POST** /api/cloud/private-networks/{id}/add-server/ |  |
| [**CloudPrivateNetworksApplyRouteCreate**](CloudApi.md#cloudprivatenetworksapplyroutecreate) | **POST** /api/cloud/private-networks/{id}/apply-route/ |  |
| [**CloudPrivateNetworksCreate**](CloudApi.md#cloudprivatenetworkscreate) | **POST** /api/cloud/private-networks/ |  |
| [**CloudPrivateNetworksDestroy**](CloudApi.md#cloudprivatenetworksdestroy) | **DELETE** /api/cloud/private-networks/{id}/ |  |
| [**CloudPrivateNetworksList**](CloudApi.md#cloudprivatenetworkslist) | **GET** /api/cloud/private-networks/ |  |
| [**CloudPrivateNetworksPartialUpdate**](CloudApi.md#cloudprivatenetworkspartialupdate) | **PATCH** /api/cloud/private-networks/{id}/ |  |
| [**CloudPrivateNetworksRemoveServerCreate**](CloudApi.md#cloudprivatenetworksremoveservercreate) | **POST** /api/cloud/private-networks/{id}/remove-server/ |  |
| [**CloudPrivateNetworksRetrieve**](CloudApi.md#cloudprivatenetworksretrieve) | **GET** /api/cloud/private-networks/{id}/ |  |
| [**CloudPrivateNetworksRouteStatusRetrieve**](CloudApi.md#cloudprivatenetworksroutestatusretrieve) | **GET** /api/cloud/private-networks/{id}/route-status/ |  |
| [**CloudPrivateNetworksUpdate**](CloudApi.md#cloudprivatenetworksupdate) | **PUT** /api/cloud/private-networks/{id}/ |  |
| [**CloudServerPackagesByGenerationRetrieve**](CloudApi.md#cloudserverpackagesbygenerationretrieve) | **GET** /api/cloud/server-packages/by-generation/ |  |
| [**CloudServerPackagesList**](CloudApi.md#cloudserverpackageslist) | **GET** /api/cloud/server-packages/ |  |
| [**CloudServerPackagesRetrieve**](CloudApi.md#cloudserverpackagesretrieve) | **GET** /api/cloud/server-packages/{id}/ |  |
| [**CloudServersActivityRetrieve**](CloudApi.md#cloudserversactivityretrieve) | **GET** /api/cloud/servers/{id}/activity/ |  |
| [**CloudServersAttachIpv4Create**](CloudApi.md#cloudserversattachipv4create) | **POST** /api/cloud/servers/{id}/attach-ipv4/ |  |
| [**CloudServersAttachIpv6Create**](CloudApi.md#cloudserversattachipv6create) | **POST** /api/cloud/servers/{id}/attach-ipv6/ |  |
| [**CloudServersBootIsosList**](CloudApi.md#cloudserversbootisoslist) | **GET** /api/cloud/servers/{id}/boot-isos/ |  |
| [**CloudServersConsoleCreate**](CloudApi.md#cloudserversconsolecreate) | **POST** /api/cloud/servers/{id}/console/ |  |
| [**CloudServersCreate**](CloudApi.md#cloudserverscreate) | **POST** /api/cloud/servers/ |  |
| [**CloudServersDestroy**](CloudApi.md#cloudserversdestroy) | **DELETE** /api/cloud/servers/{id}/ |  |
| [**CloudServersDestroyProtectionCreate**](CloudApi.md#cloudserversdestroyprotectioncreate) | **POST** /api/cloud/servers/{id}/destroy-protection/ |  |
| [**CloudServersDetachIpv4Create**](CloudApi.md#cloudserversdetachipv4create) | **POST** /api/cloud/servers/{id}/detach-ipv4/ |  |
| [**CloudServersDetachIpv6Create**](CloudApi.md#cloudserversdetachipv6create) | **POST** /api/cloud/servers/{id}/detach-ipv6/ |  |
| [**CloudServersList**](CloudApi.md#cloudserverslist) | **GET** /api/cloud/servers/ |  |
| [**CloudServersModifyPackageCreate**](CloudApi.md#cloudserversmodifypackagecreate) | **POST** /api/cloud/servers/{id}/modify-package/ |  |
| [**CloudServersMonitoringRetrieve**](CloudApi.md#cloudserversmonitoringretrieve) | **GET** /api/cloud/servers/{id}/monitoring/ |  |
| [**CloudServersMonitoringUpdate**](CloudApi.md#cloudserversmonitoringupdate) | **PUT** /api/cloud/servers/{id}/monitoring/ |  |
| [**CloudServersPartialUpdate**](CloudApi.md#cloudserverspartialupdate) | **PATCH** /api/cloud/servers/{id}/ |  |
| [**CloudServersPowerManagementCreate**](CloudApi.md#cloudserverspowermanagementcreate) | **POST** /api/cloud/servers/{id}/power-management/ |  |
| [**CloudServersPowerManagementRetrieve**](CloudApi.md#cloudserverspowermanagementretrieve) | **GET** /api/cloud/servers/{id}/power-management/ |  |
| [**CloudServersPublicInterfaceCreate**](CloudApi.md#cloudserverspublicinterfacecreate) | **POST** /api/cloud/servers/{id}/public-interface/ |  |
| [**CloudServersPublicInterfaceDestroy**](CloudApi.md#cloudserverspublicinterfacedestroy) | **DELETE** /api/cloud/servers/{id}/public-interface/ |  |
| [**CloudServersPublicInterfaceRetrieve**](CloudApi.md#cloudserverspublicinterfaceretrieve) | **GET** /api/cloud/servers/{id}/public-interface/ |  |
| [**CloudServersRescueEnterCreate**](CloudApi.md#cloudserversrescueentercreate) | **POST** /api/cloud/servers/{id}/rescue/enter/ |  |
| [**CloudServersRescueExitCreate**](CloudApi.md#cloudserversrescueexitcreate) | **POST** /api/cloud/servers/{id}/rescue/exit/ |  |
| [**CloudServersRetrieve**](CloudApi.md#cloudserversretrieve) | **GET** /api/cloud/servers/{id}/ |  |
| [**CloudServersRetryProvisionCreate**](CloudApi.md#cloudserversretryprovisioncreate) | **POST** /api/cloud/servers/{id}/retry-provision/ |  |
| [**CloudServersSnapshotsCreate**](CloudApi.md#cloudserverssnapshotscreate) | **POST** /api/cloud/servers/{id}/snapshots/ |  |
| [**CloudServersSnapshotsDestroy**](CloudApi.md#cloudserverssnapshotsdestroy) | **DELETE** /api/cloud/servers/{id}/snapshots/{snapshot_name}/ |  |
| [**CloudServersSnapshotsList**](CloudApi.md#cloudserverssnapshotslist) | **GET** /api/cloud/servers/{id}/snapshots/ |  |
| [**CloudServersSnapshotsRollbackCreate**](CloudApi.md#cloudserverssnapshotsrollbackcreate) | **POST** /api/cloud/servers/{id}/snapshots/{snapshot_name}/rollback/ |  |
| [**CloudServersTrafficRetrieve**](CloudApi.md#cloudserverstrafficretrieve) | **GET** /api/cloud/servers/{id}/traffic/ |  |
| [**CloudServersUpdate**](CloudApi.md#cloudserversupdate) | **PUT** /api/cloud/servers/{id}/ |  |
| [**CloudServersUsageRetrieve**](CloudApi.md#cloudserversusageretrieve) | **GET** /api/cloud/servers/{id}/usage/ |  |
| [**CloudServersVolumesCreate**](CloudApi.md#cloudserversvolumescreate) | **POST** /api/cloud/servers/{server_id}/volumes/ |  |
| [**CloudServersVolumesDestroy**](CloudApi.md#cloudserversvolumesdestroy) | **DELETE** /api/cloud/servers/{server_id}/volumes/{volume_id}/ |  |
| [**CloudServersVolumesList**](CloudApi.md#cloudserversvolumeslist) | **GET** /api/cloud/servers/{server_id}/volumes/ |  |
| [**CloudServersVolumesPartialUpdate**](CloudApi.md#cloudserversvolumespartialupdate) | **PATCH** /api/cloud/servers/{server_id}/volumes/{volume_id}/ |  |
| [**CloudServersVolumesRetrieve**](CloudApi.md#cloudserversvolumesretrieve) | **GET** /api/cloud/servers/{server_id}/volumes/{volume_id}/ |  |
| [**CloudServersVolumesUpdate**](CloudApi.md#cloudserversvolumesupdate) | **PUT** /api/cloud/servers/{server_id}/volumes/{volume_id}/ |  |
| [**CloudStorageProductsList**](CloudApi.md#cloudstorageproductslist) | **GET** /api/cloud/storage-products/ |  |
| [**CloudStorageProductsRetrieve**](CloudApi.md#cloudstorageproductsretrieve) | **GET** /api/cloud/storage-products/{id}/ |  |
| [**CloudVolumesAttachCreate**](CloudApi.md#cloudvolumesattachcreate) | **POST** /api/cloud/volumes/{id}/attach/ |  |
| [**CloudVolumesDestroy**](CloudApi.md#cloudvolumesdestroy) | **DELETE** /api/cloud/volumes/{id}/ |  |
| [**CloudVolumesDetachCreate**](CloudApi.md#cloudvolumesdetachcreate) | **POST** /api/cloud/volumes/{id}/detach/ |  |
| [**CloudVolumesList**](CloudApi.md#cloudvolumeslist) | **GET** /api/cloud/volumes/ |  |
| [**CloudVolumesPartialUpdate**](CloudApi.md#cloudvolumespartialupdate) | **PATCH** /api/cloud/volumes/{id}/ |  |
| [**CloudVolumesRetrieve**](CloudApi.md#cloudvolumesretrieve) | **GET** /api/cloud/volumes/{id}/ |  |
| [**CloudVolumesUpdate**](CloudApi.md#cloudvolumesupdate) | **PUT** /api/cloud/volumes/{id}/ |  |

<a id="cloudbucketscreate"></a>
# **CloudBucketsCreate**
> Bucket CloudBucketsCreate (BucketCreateRequest bucketCreateRequest)



Create a bucket


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketCreateRequest** | [**BucketCreateRequest**](BucketCreateRequest.md) |  |  |

### Return type

[**Bucket**](Bucket.md)

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

<a id="cloudbucketscredentialsrevealcreate"></a>
# **CloudBucketsCredentialsRevealCreate**
> BucketCredentials CloudBucketsCredentialsRevealCreate (int id)



Reveal bucket credentials


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |

### Return type

[**BucketCredentials**](BucketCredentials.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * Cache-Control - Prevents clients and intermediaries from caching credentials. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudbucketscredentialsrotatecreate"></a>
# **CloudBucketsCredentialsRotateCreate**
> BucketCredentials CloudBucketsCredentialsRotateCreate (int id)



Rotate bucket credentials


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |

### Return type

[**BucketCredentials**](BucketCredentials.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * Cache-Control - Prevents clients and intermediaries from caching credentials. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudbucketsdestroy"></a>
# **CloudBucketsDestroy**
> BucketCancelResponse CloudBucketsDestroy (int id)



Cancel a bucket


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |

### Return type

[**BucketCancelResponse**](BucketCancelResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudbucketsdestroyprotectioncreate"></a>
# **CloudBucketsDestroyProtectionCreate**
> DestroyProtection CloudBucketsDestroyProtectionCreate (int id, DestroyProtectionRequest destroyProtectionRequest)



Enable or disable destroy protection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |
| **destroyProtectionRequest** | [**DestroyProtectionRequest**](DestroyProtectionRequest.md) |  |  |

### Return type

[**DestroyProtection**](DestroyProtection.md)

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

<a id="cloudbucketslist"></a>
# **CloudBucketsList**
> List&lt;Bucket&gt; CloudBucketsList ()



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Bucket&gt;**](Bucket.md)

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

<a id="cloudbucketsresizecreate"></a>
# **CloudBucketsResizeCreate**
> Bucket CloudBucketsResizeCreate (int id, BucketResizeRequest bucketResizeRequest)



Resize a bucket


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |
| **bucketResizeRequest** | [**BucketResizeRequest**](BucketResizeRequest.md) |  |  |

### Return type

[**Bucket**](Bucket.md)

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

<a id="cloudbucketsretrieve"></a>
# **CloudBucketsRetrieve**
> Bucket CloudBucketsRetrieve (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |

### Return type

[**Bucket**](Bucket.md)

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

<a id="cloudbucketsvisibilitycreate"></a>
# **CloudBucketsVisibilityCreate**
> Bucket CloudBucketsVisibilityCreate (int id, BucketVisibilityRequest bucketVisibilityRequest)



Set bucket visibility


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this S3 bucket. |  |
| **bucketVisibilityRequest** | [**BucketVisibilityRequest**](BucketVisibilityRequest.md) |  |  |

### Return type

[**Bucket**](Bucket.md)

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

<a id="cloudfirewallrulessetcreate"></a>
# **CloudFirewallRulesSetCreate**
> FirewallRulesSet CloudFirewallRulesSetCreate (FirewallRulesSetRequest firewallRulesSetRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firewallRulesSetRequest** | [**FirewallRulesSetRequest**](FirewallRulesSetRequest.md) |  |  |

### Return type

[**FirewallRulesSet**](FirewallRulesSet.md)

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

<a id="cloudfirewallrulessetdestroy"></a>
# **CloudFirewallRulesSetDestroy**
> void CloudFirewallRulesSetDestroy (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this firewall rules set. |  |

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

<a id="cloudfirewallrulessetlist"></a>
# **CloudFirewallRulesSetList**
> List&lt;FirewallRulesSet&gt; CloudFirewallRulesSetList ()



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FirewallRulesSet&gt;**](FirewallRulesSet.md)

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

<a id="cloudfirewallrulessetpartialupdate"></a>
# **CloudFirewallRulesSetPartialUpdate**
> FirewallRulesSet CloudFirewallRulesSetPartialUpdate (int id, PatchedFirewallRulesSetRequest patchedFirewallRulesSetRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this firewall rules set. |  |
| **patchedFirewallRulesSetRequest** | [**PatchedFirewallRulesSetRequest**](PatchedFirewallRulesSetRequest.md) |  | [optional]  |

### Return type

[**FirewallRulesSet**](FirewallRulesSet.md)

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

<a id="cloudfirewallrulessetretrieve"></a>
# **CloudFirewallRulesSetRetrieve**
> FirewallRulesSet CloudFirewallRulesSetRetrieve (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this firewall rules set. |  |

### Return type

[**FirewallRulesSet**](FirewallRulesSet.md)

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

<a id="cloudfirewallrulessetrulescreate"></a>
# **CloudFirewallRulesSetRulesCreate**
> FirewallRule CloudFirewallRulesSetRulesCreate (string rulesSetId, FirewallRuleRequest firewallRuleRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rulesSetId** | **string** |  |  |
| **firewallRuleRequest** | [**FirewallRuleRequest**](FirewallRuleRequest.md) |  |  |

### Return type

[**FirewallRule**](FirewallRule.md)

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

<a id="cloudfirewallrulessetrulesdestroy"></a>
# **CloudFirewallRulesSetRulesDestroy**
> void CloudFirewallRulesSetRulesDestroy (string ruleId, string rulesSetId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **rulesSetId** | **string** |  |  |

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

<a id="cloudfirewallrulessetruleslist"></a>
# **CloudFirewallRulesSetRulesList**
> List&lt;FirewallRule&gt; CloudFirewallRulesSetRulesList (string rulesSetId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rulesSetId** | **string** |  |  |

### Return type

[**List&lt;FirewallRule&gt;**](FirewallRule.md)

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

<a id="cloudfirewallrulessetrulespartialupdate"></a>
# **CloudFirewallRulesSetRulesPartialUpdate**
> FirewallRule CloudFirewallRulesSetRulesPartialUpdate (string ruleId, string rulesSetId, PatchedFirewallRuleRequest patchedFirewallRuleRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **rulesSetId** | **string** |  |  |
| **patchedFirewallRuleRequest** | [**PatchedFirewallRuleRequest**](PatchedFirewallRuleRequest.md) |  | [optional]  |

### Return type

[**FirewallRule**](FirewallRule.md)

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

<a id="cloudfirewallrulessetrulesretrieve"></a>
# **CloudFirewallRulesSetRulesRetrieve**
> FirewallRule CloudFirewallRulesSetRulesRetrieve (string ruleId, string rulesSetId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **rulesSetId** | **string** |  |  |

### Return type

[**FirewallRule**](FirewallRule.md)

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

<a id="cloudfirewallrulessetrulesupdate"></a>
# **CloudFirewallRulesSetRulesUpdate**
> FirewallRule CloudFirewallRulesSetRulesUpdate (string ruleId, string rulesSetId, FirewallRuleRequest firewallRuleRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **rulesSetId** | **string** |  |  |
| **firewallRuleRequest** | [**FirewallRuleRequest**](FirewallRuleRequest.md) |  |  |

### Return type

[**FirewallRule**](FirewallRule.md)

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

<a id="cloudfirewallrulessetupdate"></a>
# **CloudFirewallRulesSetUpdate**
> FirewallRulesSet CloudFirewallRulesSetUpdate (int id, FirewallRulesSetRequest firewallRulesSetRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this firewall rules set. |  |
| **firewallRulesSetRequest** | [**FirewallRulesSetRequest**](FirewallRulesSetRequest.md) |  |  |

### Return type

[**FirewallRulesSet**](FirewallRulesSet.md)

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

<a id="cloudfloatingipv4authorizationslist"></a>
# **CloudFloatingIpv4AuthorizationsList**
> PaginatedFloatingIPAuthorizationList CloudFloatingIpv4AuthorizationsList (int id, int page = null)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedFloatingIPAuthorizationList**](PaginatedFloatingIPAuthorizationList.md)

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

<a id="cloudfloatingipv4authorizecreate"></a>
# **CloudFloatingIpv4AuthorizeCreate**
> FloatingIPv4AuthorizeResponse CloudFloatingIpv4AuthorizeCreate (int id, FloatingIPAuthorizeRequest floatingIPAuthorizeRequest)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |
| **floatingIPAuthorizeRequest** | [**FloatingIPAuthorizeRequest**](FloatingIPAuthorizeRequest.md) |  |  |

### Return type

[**FloatingIPv4AuthorizeResponse**](FloatingIPv4AuthorizeResponse.md)

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

<a id="cloudfloatingipv4create"></a>
# **CloudFloatingIpv4Create**
> FloatingIPv4 CloudFloatingIpv4Create (FloatingIPv4CreateRequest floatingIPv4CreateRequest = null)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **floatingIPv4CreateRequest** | [**FloatingIPv4CreateRequest**](FloatingIPv4CreateRequest.md) |  | [optional]  |

### Return type

[**FloatingIPv4**](FloatingIPv4.md)

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

<a id="cloudfloatingipv4destroy"></a>
# **CloudFloatingIpv4Destroy**
> void CloudFloatingIpv4Destroy (int id)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |

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

<a id="cloudfloatingipv4list"></a>
# **CloudFloatingIpv4List**
> PaginatedFloatingIPv4List CloudFloatingIpv4List (int page = null)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedFloatingIPv4List**](PaginatedFloatingIPv4List.md)

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

<a id="cloudfloatingipv4rdnscreate"></a>
# **CloudFloatingIpv4RdnsCreate**
> ReverseDNS CloudFloatingIpv4RdnsCreate (int id, ReverseDNSRequest reverseDNSRequest)



Get or update reverse DNS (PTR) for the IPv4 address wrapped by this floating IP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |
| **reverseDNSRequest** | [**ReverseDNSRequest**](ReverseDNSRequest.md) |  |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudfloatingipv4rdnsretrieve"></a>
# **CloudFloatingIpv4RdnsRetrieve**
> ReverseDNS CloudFloatingIpv4RdnsRetrieve (int id)



Get or update reverse DNS (PTR) for the IPv4 address wrapped by this floating IP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudfloatingipv4retrieve"></a>
# **CloudFloatingIpv4Retrieve**
> FloatingIPv4 CloudFloatingIpv4Retrieve (int id)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |

### Return type

[**FloatingIPv4**](FloatingIPv4.md)

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

<a id="cloudfloatingipv4unauthorizecreate"></a>
# **CloudFloatingIpv4UnauthorizeCreate**
> FloatingIPv4UnauthorizeResponse CloudFloatingIpv4UnauthorizeCreate (int id, FloatingIPAuthorizeRequest floatingIPAuthorizeRequest)



Manage floating IPv4 addresses. A floating IP can be authorized on multiple VMs simultaneously; the customer asserts ownership inside the guest via keepalived/VRRP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv4. |  |
| **floatingIPAuthorizeRequest** | [**FloatingIPAuthorizeRequest**](FloatingIPAuthorizeRequest.md) |  |  |

### Return type

[**FloatingIPv4UnauthorizeResponse**](FloatingIPv4UnauthorizeResponse.md)

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

<a id="cloudfloatingipv6authorizationslist"></a>
# **CloudFloatingIpv6AuthorizationsList**
> PaginatedFloatingIPAuthorizationList CloudFloatingIpv6AuthorizationsList (int id, int page = null)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedFloatingIPAuthorizationList**](PaginatedFloatingIPAuthorizationList.md)

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

<a id="cloudfloatingipv6authorizecreate"></a>
# **CloudFloatingIpv6AuthorizeCreate**
> FloatingIPv6AuthorizeResponse CloudFloatingIpv6AuthorizeCreate (int id, FloatingIPAuthorizeRequest floatingIPAuthorizeRequest)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |
| **floatingIPAuthorizeRequest** | [**FloatingIPAuthorizeRequest**](FloatingIPAuthorizeRequest.md) |  |  |

### Return type

[**FloatingIPv6AuthorizeResponse**](FloatingIPv6AuthorizeResponse.md)

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

<a id="cloudfloatingipv6create"></a>
# **CloudFloatingIpv6Create**
> FloatingIPv6 CloudFloatingIpv6Create (FloatingIPv6CreateRequest floatingIPv6CreateRequest = null)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **floatingIPv6CreateRequest** | [**FloatingIPv6CreateRequest**](FloatingIPv6CreateRequest.md) |  | [optional]  |

### Return type

[**FloatingIPv6**](FloatingIPv6.md)

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

<a id="cloudfloatingipv6destroy"></a>
# **CloudFloatingIpv6Destroy**
> void CloudFloatingIpv6Destroy (int id)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |

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

<a id="cloudfloatingipv6list"></a>
# **CloudFloatingIpv6List**
> PaginatedFloatingIPv6List CloudFloatingIpv6List (int page = null)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedFloatingIPv6List**](PaginatedFloatingIPv6List.md)

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

<a id="cloudfloatingipv6rdnscreate"></a>
# **CloudFloatingIpv6RdnsCreate**
> ReverseDNS CloudFloatingIpv6RdnsCreate (int id, ReverseDNSRequest reverseDNSRequest)



Get or update reverse DNS (PTR) for the IPv6 address wrapped by this floating IP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |
| **reverseDNSRequest** | [**ReverseDNSRequest**](ReverseDNSRequest.md) |  |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudfloatingipv6rdnsretrieve"></a>
# **CloudFloatingIpv6RdnsRetrieve**
> ReverseDNS CloudFloatingIpv6RdnsRetrieve (int id)



Get or update reverse DNS (PTR) for the IPv6 address wrapped by this floating IP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudfloatingipv6retrieve"></a>
# **CloudFloatingIpv6Retrieve**
> FloatingIPv6 CloudFloatingIpv6Retrieve (int id)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |

### Return type

[**FloatingIPv6**](FloatingIPv6.md)

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

<a id="cloudfloatingipv6unauthorizecreate"></a>
# **CloudFloatingIpv6UnauthorizeCreate**
> FloatingIPv6UnauthorizeResponse CloudFloatingIpv6UnauthorizeCreate (int id, FloatingIPAuthorizeRequest floatingIPAuthorizeRequest)



Manage floating IPv6 addresses.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this floating IPv6. |  |
| **floatingIPAuthorizeRequest** | [**FloatingIPAuthorizeRequest**](FloatingIPAuthorizeRequest.md) |  |  |

### Return type

[**FloatingIPv6UnauthorizeResponse**](FloatingIPv6UnauthorizeResponse.md)

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

<a id="cloudgatewayscreate"></a>
# **CloudGatewaysCreate**
> Gateway CloudGatewaysCreate (GatewayCreateRequest gatewayCreateRequest)



Reserve a gateway and queue its provisioning (spec 11.1); its state shows the progress.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayCreateRequest** | [**GatewayCreateRequest**](GatewayCreateRequest.md) |  |  |

### Return type

[**Gateway**](Gateway.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysdestroy"></a>
# **CloudGatewaysDestroy**
> GatewayOperation CloudGatewaysDestroy (string id, List<int> networks = null, int revision = null, List<int> servers = null)



Delete the gateway (spec 11.5): its VM is destroyed, then its networks and IPv4 are released. Without the preview's revision, networks and servers, 409 with a fresh preview.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **networks** | [**List&lt;int&gt;**](int.md) | The preview&#39;s network ids. | [optional]  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |
| **servers** | [**List&lt;int&gt;**](int.md) | The preview&#39;s server ids. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysfirewallrulescreate"></a>
# **CloudGatewaysFirewallRulesCreate**
> GatewayFirewallRule CloudGatewaysFirewallRulesCreate (int gatewayId, GatewayFirewallRuleWriteRequest gatewayFirewallRuleWriteRequest)



Add a rule after the last one (spec 5.7); it is pending until the agent applies its revision.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **gatewayFirewallRuleWriteRequest** | [**GatewayFirewallRuleWriteRequest**](GatewayFirewallRuleWriteRequest.md) |  |  |

### Return type

[**GatewayFirewallRule**](GatewayFirewallRule.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysfirewallrulesdestroy"></a>
# **CloudGatewaysFirewallRulesDestroy**
> GatewayOperation CloudGatewaysFirewallRulesDestroy (int gatewayId, int id, int revision = null)



Delete a rule (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysfirewallruleslist"></a>
# **CloudGatewaysFirewallRulesList**
> PaginatedGatewayFirewallRuleList CloudGatewaysFirewallRulesList (int gatewayId, int page = null)



A gateway's firewall rules, in evaluation order


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayFirewallRuleList**](PaginatedGatewayFirewallRuleList.md)

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

<a id="cloudgatewaysfirewallrulesmovecreate"></a>
# **CloudGatewaysFirewallRulesMoveCreate**
> GatewayFirewallRule CloudGatewaysFirewallRulesMoveCreate (int gatewayId, int id, GatewayFirewallMoveRequest gatewayFirewallMoveRequest, int revision = null)



Move a rule to a position, the others keeping their order. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **gatewayFirewallMoveRequest** | [**GatewayFirewallMoveRequest**](GatewayFirewallMoveRequest.md) |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayFirewallRule**](GatewayFirewallRule.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysfirewallrulespartialupdate"></a>
# **CloudGatewaysFirewallRulesPartialUpdate**
> GatewayFirewallRule CloudGatewaysFirewallRulesPartialUpdate (int gatewayId, int id, PatchedGatewayFirewallRuleWriteRequest patchedGatewayFirewallRuleWriteRequest = null)



Change a rule's fields; a source or destination is replaced whole. Its position stays.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **patchedGatewayFirewallRuleWriteRequest** | [**PatchedGatewayFirewallRuleWriteRequest**](PatchedGatewayFirewallRuleWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayFirewallRule**](GatewayFirewallRule.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysfirewallrulesretrieve"></a>
# **CloudGatewaysFirewallRulesRetrieve**
> GatewayFirewallRule CloudGatewaysFirewallRulesRetrieve (int gatewayId, int id)



A gateway's firewall rules, in evaluation order


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |

### Return type

[**GatewayFirewallRule**](GatewayFirewallRule.md)

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

<a id="cloudgatewayslist"></a>
# **CloudGatewaysList**
> PaginatedGatewayList CloudGatewaysList (int page = null)



Manage gateways


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayList**](PaginatedGatewayList.md)

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

<a id="cloudgatewayslistenerscreate"></a>
# **CloudGatewaysListenersCreate**
> GatewayLBListener CloudGatewaysListenersCreate (int gatewayId, GatewayLBListenerWriteRequest gatewayLBListenerWriteRequest = null)



Add a listener (spec 6.8): tcp and udp name a pool, http takes routes. Pending until applied.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **gatewayLBListenerWriteRequest** | [**GatewayLBListenerWriteRequest**](GatewayLBListenerWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayLBListener**](GatewayLBListener.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenersdestroy"></a>
# **CloudGatewaysListenersDestroy**
> GatewayOperation CloudGatewaysListenersDestroy (int gatewayId, int id, int revision = null)



Delete a listener and its routes (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenerslist"></a>
# **CloudGatewaysListenersList**
> PaginatedGatewayLBListenerList CloudGatewaysListenersList (int gatewayId, int page = null)



A gateway's load balancer listeners


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayLBListenerList**](PaginatedGatewayLBListenerList.md)

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

<a id="cloudgatewayslistenerspartialupdate"></a>
# **CloudGatewaysListenersPartialUpdate**
> GatewayLBListener CloudGatewaysListenersPartialUpdate (int gatewayId, int id, PatchedGatewayLBListenerWriteRequest patchedGatewayLBListenerWriteRequest = null)



Change a listener's pool, sources, comment or enabled flag; protocol, port and mode are fixed.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **patchedGatewayLBListenerWriteRequest** | [**PatchedGatewayLBListenerWriteRequest**](PatchedGatewayLBListenerWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayLBListener**](GatewayLBListener.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenersretrieve"></a>
# **CloudGatewaysListenersRetrieve**
> GatewayLBListener CloudGatewaysListenersRetrieve (int gatewayId, int id)



A gateway's load balancer listeners


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |

### Return type

[**GatewayLBListener**](GatewayLBListener.md)

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

<a id="cloudgatewayslistenersroutescreate"></a>
# **CloudGatewaysListenersRoutesCreate**
> GatewayRoute CloudGatewaysListenersRoutesCreate (int gatewayId, int listenerId, GatewayRouteWriteRequest gatewayRouteWriteRequest = null)



Add a route (spec 5.6): hostnames and a path prefix to a pool. Pending until applied.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **listenerId** | **int** |  |  |
| **gatewayRouteWriteRequest** | [**GatewayRouteWriteRequest**](GatewayRouteWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayRoute**](GatewayRoute.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenersroutesdestroy"></a>
# **CloudGatewaysListenersRoutesDestroy**
> GatewayOperation CloudGatewaysListenersRoutesDestroy (int gatewayId, int id, int listenerId, int revision = null)



Delete a route (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **listenerId** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenersrouteslist"></a>
# **CloudGatewaysListenersRoutesList**
> PaginatedGatewayRouteList CloudGatewaysListenersRoutesList (int gatewayId, int listenerId, int page = null)



An http listener's routes


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **listenerId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayRouteList**](PaginatedGatewayRouteList.md)

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

<a id="cloudgatewayslistenersroutespartialupdate"></a>
# **CloudGatewaysListenersRoutesPartialUpdate**
> GatewayRoute CloudGatewaysListenersRoutesPartialUpdate (int gatewayId, int id, int listenerId, PatchedGatewayRouteWriteRequest patchedGatewayRouteWriteRequest = null)



Change a route; hostnames are replaced whole.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **listenerId** | **int** |  |  |
| **patchedGatewayRouteWriteRequest** | [**PatchedGatewayRouteWriteRequest**](PatchedGatewayRouteWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayRoute**](GatewayRoute.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayslistenersroutesretrieve"></a>
# **CloudGatewaysListenersRoutesRetrieve**
> GatewayRoute CloudGatewaysListenersRoutesRetrieve (int gatewayId, int id, int listenerId)



An http listener's routes


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **listenerId** | **int** |  |  |

### Return type

[**GatewayRoute**](GatewayRoute.md)

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

<a id="cloudgatewaysnetworkscreate"></a>
# **CloudGatewaysNetworksCreate**
> GatewayOperation CloudGatewaysNetworksCreate (int gatewayId, GatewayNetworkCreateRequest gatewayNetworkCreateRequest)



Attach a network (spec 11.3): the operation reserves it and hotplugs the gateway's NIC.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **gatewayNetworkCreateRequest** | [**GatewayNetworkCreateRequest**](GatewayNetworkCreateRequest.md) |  |  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysnetworksdestroy"></a>
# **CloudGatewaysNetworksDestroy**
> GatewayOperation CloudGatewaysNetworksDestroy (int gatewayId, int networkId, int revision = null, List<int> servers = null)



Detach a network (spec 11.3). Without the preview's revision and servers, 409 with a fresh preview.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **networkId** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |
| **servers** | [**List&lt;int&gt;**](int.md) | The preview&#39;s server ids. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysnetworkslist"></a>
# **CloudGatewaysNetworksList**
> PaginatedGatewayNetworkList CloudGatewaysNetworksList (int gatewayId, int page = null)



A gateway's private networks, by network id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayNetworkList**](PaginatedGatewayNetworkList.md)

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

<a id="cloudgatewaysnetworkspartialupdate"></a>
# **CloudGatewaysNetworksPartialUpdate**
> GatewayNetwork CloudGatewaysNetworksPartialUpdate (int gatewayId, int networkId, int revision = null, List<int> servers = null, PatchedGatewayNetworkUpdateRequest patchedGatewayNetworkUpdateRequest = null)



Switch a router network's SNAT (spec 6.4). Turning it off without the preview's revision and servers answers 409 with a fresh preview; the change is pending until the agent applies it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **networkId** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |
| **servers** | [**List&lt;int&gt;**](int.md) | The preview&#39;s server ids. | [optional]  |
| **patchedGatewayNetworkUpdateRequest** | [**PatchedGatewayNetworkUpdateRequest**](PatchedGatewayNetworkUpdateRequest.md) |  | [optional]  |

### Return type

[**GatewayNetwork**](GatewayNetwork.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysnetworksretrieve"></a>
# **CloudGatewaysNetworksRetrieve**
> GatewayNetwork CloudGatewaysNetworksRetrieve (int gatewayId, int networkId)



A gateway's private networks, by network id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **networkId** | **int** |  |  |

### Return type

[**GatewayNetwork**](GatewayNetwork.md)

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

<a id="cloudgatewaysoperationslist"></a>
# **CloudGatewaysOperationsList**
> PaginatedGatewayOperationList CloudGatewaysOperationsList (int gatewayId, int page = null)



A gateway's operations, newest first


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayOperationList**](PaginatedGatewayOperationList.md)

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

<a id="cloudgatewaysoperationsretrieve"></a>
# **CloudGatewaysOperationsRetrieve**
> GatewayOperation CloudGatewaysOperationsRetrieve (int gatewayId, string id)



A gateway's operations, newest first


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **string** |  |  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

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

<a id="cloudgatewayspartialupdate"></a>
# **CloudGatewaysPartialUpdate**
> Gateway CloudGatewaysPartialUpdate (string id, PatchedGatewayUpdateRequest patchedGatewayUpdateRequest = null)



Rename the gateway or change its maintenance window. The name is not compiled, so no revision follows; a new window reaches the agent in a new revision (spec 11.4).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **patchedGatewayUpdateRequest** | [**PatchedGatewayUpdateRequest**](PatchedGatewayUpdateRequest.md) |  | [optional]  |

### Return type

[**Gateway**](Gateway.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsbackendscreate"></a>
# **CloudGatewaysPoolsBackendsCreate**
> GatewayBackend CloudGatewaysPoolsBackendsCreate (int gatewayId, int poolId, GatewayBackendWriteRequest gatewayBackendWriteRequest = null)



Add a server to the pool (spec 5.5); it is pending until the agent applies its revision.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **poolId** | **int** |  |  |
| **gatewayBackendWriteRequest** | [**GatewayBackendWriteRequest**](GatewayBackendWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayBackend**](GatewayBackend.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsbackendsdestroy"></a>
# **CloudGatewaysPoolsBackendsDestroy**
> GatewayOperation CloudGatewaysPoolsBackendsDestroy (int gatewayId, int id, int poolId, int revision = null)



Remove a server (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **poolId** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsbackendslist"></a>
# **CloudGatewaysPoolsBackendsList**
> PaginatedGatewayBackendList CloudGatewaysPoolsBackendsList (int gatewayId, int poolId, int page = null)



A backend pool's servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **poolId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayBackendList**](PaginatedGatewayBackendList.md)

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

<a id="cloudgatewayspoolsbackendspartialupdate"></a>
# **CloudGatewaysPoolsBackendsPartialUpdate**
> GatewayBackend CloudGatewaysPoolsBackendsPartialUpdate (int gatewayId, int id, int poolId, PatchedGatewayBackendWriteRequest patchedGatewayBackendWriteRequest = null)



Change a server. The last enabled server of a pool in use cannot be disabled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **poolId** | **int** |  |  |
| **patchedGatewayBackendWriteRequest** | [**PatchedGatewayBackendWriteRequest**](PatchedGatewayBackendWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayBackend**](GatewayBackend.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsbackendsretrieve"></a>
# **CloudGatewaysPoolsBackendsRetrieve**
> GatewayBackend CloudGatewaysPoolsBackendsRetrieve (int gatewayId, int id, int poolId)



A backend pool's servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **poolId** | **int** |  |  |

### Return type

[**GatewayBackend**](GatewayBackend.md)

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

<a id="cloudgatewayspoolscreate"></a>
# **CloudGatewaysPoolsCreate**
> GatewayBackendPool CloudGatewaysPoolsCreate (int gatewayId, GatewayBackendPoolWriteRequest gatewayBackendPoolWriteRequest = null)



Add a backend pool (spec 5.5); it is pending until the agent applies its revision.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **gatewayBackendPoolWriteRequest** | [**GatewayBackendPoolWriteRequest**](GatewayBackendPoolWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayBackendPool**](GatewayBackendPool.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsdestroy"></a>
# **CloudGatewaysPoolsDestroy**
> GatewayOperation CloudGatewaysPoolsDestroy (int gatewayId, int id, int revision = null)



Delete an unused pool and its servers (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolslist"></a>
# **CloudGatewaysPoolsList**
> PaginatedGatewayBackendPoolList CloudGatewaysPoolsList (int gatewayId, int page = null)



A gateway's backend pools


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayBackendPoolList**](PaginatedGatewayBackendPoolList.md)

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

<a id="cloudgatewayspoolspartialupdate"></a>
# **CloudGatewaysPoolsPartialUpdate**
> GatewayBackendPool CloudGatewaysPoolsPartialUpdate (int gatewayId, int id, PatchedGatewayBackendPoolWriteRequest patchedGatewayBackendPoolWriteRequest = null)



Change a pool; health_check takes the fields to change. Every listener and route on it must still fit.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **patchedGatewayBackendPoolWriteRequest** | [**PatchedGatewayBackendPoolWriteRequest**](PatchedGatewayBackendPoolWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayBackendPool**](GatewayBackendPool.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewayspoolsretrieve"></a>
# **CloudGatewaysPoolsRetrieve**
> GatewayBackendPool CloudGatewaysPoolsRetrieve (int gatewayId, int id)



A gateway's backend pools


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |

### Return type

[**GatewayBackendPool**](GatewayBackendPool.md)

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

<a id="cloudgatewaysportforwardscreate"></a>
# **CloudGatewaysPortForwardsCreate**
> GatewayForward CloudGatewaysPortForwardsCreate (int gatewayId, GatewayForwardWriteRequest gatewayForwardWriteRequest)



Add a port forward (spec 6.7); it is pending until the agent applies its revision.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **gatewayForwardWriteRequest** | [**GatewayForwardWriteRequest**](GatewayForwardWriteRequest.md) |  |  |

### Return type

[**GatewayForward**](GatewayForward.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysportforwardsdestroy"></a>
# **CloudGatewaysPortForwardsDestroy**
> GatewayOperation CloudGatewaysPortForwardsDestroy (int gatewayId, int id, int revision = null)



Delete a forward (spec 5.11): 202 with the record the agent's acknowledgement completes. Without the preview's revision, 409 with a fresh one.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **revision** | **int** | The gateway&#39;s desired revision from the preview; without it, a preview. | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysportforwardslist"></a>
# **CloudGatewaysPortForwardsList**
> PaginatedGatewayForwardList CloudGatewaysPortForwardsList (int gatewayId, int page = null)



A gateway's port forwards


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedGatewayForwardList**](PaginatedGatewayForwardList.md)

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

<a id="cloudgatewaysportforwardspartialupdate"></a>
# **CloudGatewaysPortForwardsPartialUpdate**
> GatewayForward CloudGatewaysPortForwardsPartialUpdate (int gatewayId, int id, PatchedGatewayForwardWriteRequest patchedGatewayForwardWriteRequest = null)



Change a forward's fields; public_ports and target are each replaced whole.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |
| **patchedGatewayForwardWriteRequest** | [**PatchedGatewayForwardWriteRequest**](PatchedGatewayForwardWriteRequest.md) |  | [optional]  |

### Return type

[**GatewayForward**](GatewayForward.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysportforwardsretrieve"></a>
# **CloudGatewaysPortForwardsRetrieve**
> GatewayForward CloudGatewaysPortForwardsRetrieve (int gatewayId, int id)



A gateway's port forwards


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gatewayId** | **int** |  |  |
| **id** | **int** |  |  |

### Return type

[**GatewayForward**](GatewayForward.md)

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

<a id="cloudgatewaysreenrollcreate"></a>
# **CloudGatewaysReenrollCreate**
> GatewayOperation CloudGatewaysReenrollCreate (string id, GatewayReenrollRequest gatewayReenrollRequest = null)



Re-enroll the gateway (spec 8.1 step 6): its agent token is revoked and it restarts to enroll again. Without the preview's revision, networks and servers, 409 with a fresh preview.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **gatewayReenrollRequest** | [**GatewayReenrollRequest**](GatewayReenrollRequest.md) |  | [optional]  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudgatewaysretrieve"></a>
# **CloudGatewaysRetrieve**
> Gateway CloudGatewaysRetrieve (string id)



Manage gateways


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**Gateway**](Gateway.md)

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

<a id="cloudgatewaysstatusretrieve"></a>
# **CloudGatewaysStatusRetrieve**
> GatewayStatus CloudGatewaysStatusRetrieve (string id)



The gateway's state and the customer part of its agent's last report (spec 9.5).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**GatewayStatus**](GatewayStatus.md)

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

<a id="cloudgenerationslist"></a>
# **CloudGenerationsList**
> List&lt;HardwareGeneration&gt; CloudGenerationsList ()

List hardware generations

Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;HardwareGeneration&gt;**](HardwareGeneration.md)

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

<a id="cloudgenerationsretrieve"></a>
# **CloudGenerationsRetrieve**
> HardwareGeneration CloudGenerationsRetrieve (string slug)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** |  |  |

### Return type

[**HardwareGeneration**](HardwareGeneration.md)

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

<a id="cloudimageslist"></a>
# **CloudImagesList**
> PaginatedOSImageList CloudImagesList (int page = null)



List of available OS images


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedOSImageList**](PaginatedOSImageList.md)

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

<a id="cloudimagesretrieve"></a>
# **CloudImagesRetrieve**
> OSImage CloudImagesRetrieve (int id)



List of available OS images


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this operating system. |  |

### Return type

[**OSImage**](OSImage.md)

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

<a id="cloudipv4create"></a>
# **CloudIpv4Create**
> PublicIPv4 CloudIpv4Create ()



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**PublicIPv4**](PublicIPv4.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudipv4destroy"></a>
# **CloudIpv4Destroy**
> void CloudIpv4Destroy (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv4. |  |

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

<a id="cloudipv4detachcreate"></a>
# **CloudIpv4DetachCreate**
> DetachIPv4Response CloudIpv4DetachCreate (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv4. |  |

### Return type

[**DetachIPv4Response**](DetachIPv4Response.md)

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

<a id="cloudipv4list"></a>
# **CloudIpv4List**
> PaginatedPublicIPv4List CloudIpv4List (int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedPublicIPv4List**](PaginatedPublicIPv4List.md)

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

<a id="cloudipv4rdnscreate"></a>
# **CloudIpv4RdnsCreate**
> ReverseDNS CloudIpv4RdnsCreate (int id, ReverseDNSRequest reverseDNSRequest)



Get or update reverse DNS (PTR) for this IPv4 address.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv4. |  |
| **reverseDNSRequest** | [**ReverseDNSRequest**](ReverseDNSRequest.md) |  |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudipv4rdnsretrieve"></a>
# **CloudIpv4RdnsRetrieve**
> ReverseDNS CloudIpv4RdnsRetrieve (int id)



Get or update reverse DNS (PTR) for this IPv4 address.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv4. |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudipv4retrieve"></a>
# **CloudIpv4Retrieve**
> PublicIPv4 CloudIpv4Retrieve (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv4. |  |

### Return type

[**PublicIPv4**](PublicIPv4.md)

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

<a id="cloudipv6create"></a>
# **CloudIpv6Create**
> PublicIPv6 CloudIpv6Create ()



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters
This endpoint does not need any parameter.
### Return type

[**PublicIPv6**](PublicIPv6.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudipv6destroy"></a>
# **CloudIpv6Destroy**
> void CloudIpv6Destroy (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv6. |  |

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

<a id="cloudipv6detachcreate"></a>
# **CloudIpv6DetachCreate**
> DetachIPv6Response CloudIpv6DetachCreate (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv6. |  |

### Return type

[**DetachIPv6Response**](DetachIPv6Response.md)

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

<a id="cloudipv6list"></a>
# **CloudIpv6List**
> PaginatedPublicIPv6List CloudIpv6List (int page = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedPublicIPv6List**](PaginatedPublicIPv6List.md)

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

<a id="cloudipv6rdnscreate"></a>
# **CloudIpv6RdnsCreate**
> ReverseDNS CloudIpv6RdnsCreate (int id, ReverseDNSRequest reverseDNSRequest)



Get or update reverse DNS (PTR) for this IPv6 address.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv6. |  |
| **reverseDNSRequest** | [**ReverseDNSRequest**](ReverseDNSRequest.md) |  |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudipv6rdnsretrieve"></a>
# **CloudIpv6RdnsRetrieve**
> ReverseDNS CloudIpv6RdnsRetrieve (int id)



Get or update reverse DNS (PTR) for this IPv6 address.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv6. |  |

### Return type

[**ReverseDNS**](ReverseDNS.md)

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

<a id="cloudipv6retrieve"></a>
# **CloudIpv6Retrieve**
> PublicIPv6 CloudIpv6Retrieve (int id)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this Public IPv6. |  |

### Return type

[**PublicIPv6**](PublicIPv6.md)

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

<a id="cloudprivatenetworksaddservercreate"></a>
# **CloudPrivateNetworksAddServerCreate**
> AddServerResponse CloudPrivateNetworksAddServerCreate (int id, PrivateNetworkAddHostRequest privateNetworkAddHostRequest)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |
| **privateNetworkAddHostRequest** | [**PrivateNetworkAddHostRequest**](PrivateNetworkAddHostRequest.md) |  |  |

### Return type

[**AddServerResponse**](AddServerResponse.md)

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

<a id="cloudprivatenetworksapplyroutecreate"></a>
# **CloudPrivateNetworksApplyRouteCreate**
> GatewayOperation CloudPrivateNetworksApplyRouteCreate (int id, ApplyRouteRequest applyRouteRequest)



Re-render the named servers' routes and reboot them (spec 6.3); naming a server acknowledges its reboot.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **applyRouteRequest** | [**ApplyRouteRequest**](ApplyRouteRequest.md) |  |  |

### Return type

[**GatewayOperation**](GatewayOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * Location - The cluster&#39;s encryption status resource, to poll for the outcome. <br>  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudprivatenetworkscreate"></a>
# **CloudPrivateNetworksCreate**
> PrivateNetwork CloudPrivateNetworksCreate (PrivateNetworkRequest privateNetworkRequest)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **privateNetworkRequest** | [**PrivateNetworkRequest**](PrivateNetworkRequest.md) |  |  |

### Return type

[**PrivateNetwork**](PrivateNetwork.md)

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

<a id="cloudprivatenetworksdestroy"></a>
# **CloudPrivateNetworksDestroy**
> void CloudPrivateNetworksDestroy (int id)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |

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

<a id="cloudprivatenetworkslist"></a>
# **CloudPrivateNetworksList**
> PaginatedPrivateNetworkList CloudPrivateNetworksList (int page = null)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedPrivateNetworkList**](PaginatedPrivateNetworkList.md)

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

<a id="cloudprivatenetworkspartialupdate"></a>
# **CloudPrivateNetworksPartialUpdate**
> PrivateNetwork CloudPrivateNetworksPartialUpdate (int id, PatchedPrivateNetworkUpdateRequest patchedPrivateNetworkUpdateRequest = null)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |
| **patchedPrivateNetworkUpdateRequest** | [**PatchedPrivateNetworkUpdateRequest**](PatchedPrivateNetworkUpdateRequest.md) |  | [optional]  |

### Return type

[**PrivateNetwork**](PrivateNetwork.md)

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

<a id="cloudprivatenetworksremoveservercreate"></a>
# **CloudPrivateNetworksRemoveServerCreate**
> RemoveServerResponse CloudPrivateNetworksRemoveServerCreate (int id, PrivateNetworkRemoveHostRequest privateNetworkRemoveHostRequest)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |
| **privateNetworkRemoveHostRequest** | [**PrivateNetworkRemoveHostRequest**](PrivateNetworkRemoveHostRequest.md) |  |  |

### Return type

[**RemoveServerResponse**](RemoveServerResponse.md)

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

<a id="cloudprivatenetworksretrieve"></a>
# **CloudPrivateNetworksRetrieve**
> PrivateNetwork CloudPrivateNetworksRetrieve (int id)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |

### Return type

[**PrivateNetwork**](PrivateNetwork.md)

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

<a id="cloudprivatenetworksroutestatusretrieve"></a>
# **CloudPrivateNetworksRouteStatusRetrieve**
> RouteStatus CloudPrivateNetworksRouteStatusRetrieve (int id)



Each server's default route against the spec 6.2 rule, read from Proxmox, and the network's route applies.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**RouteStatus**](RouteStatus.md)

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

<a id="cloudprivatenetworksupdate"></a>
# **CloudPrivateNetworksUpdate**
> PrivateNetwork CloudPrivateNetworksUpdate (int id, PrivateNetworkUpdateRequest privateNetworkUpdateRequest = null)



Manage private networks


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this private network. |  |
| **privateNetworkUpdateRequest** | [**PrivateNetworkUpdateRequest**](PrivateNetworkUpdateRequest.md) |  | [optional]  |

### Return type

[**PrivateNetwork**](PrivateNetwork.md)

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

<a id="cloudserverpackagesbygenerationretrieve"></a>
# **CloudServerPackagesByGenerationRetrieve**
> ServerProduct CloudServerPackagesByGenerationRetrieve ()



List of available server products


### Parameters
This endpoint does not need any parameter.
### Return type

[**ServerProduct**](ServerProduct.md)

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

<a id="cloudserverpackageslist"></a>
# **CloudServerPackagesList**
> PaginatedServerProductList CloudServerPackagesList (string generation = null, int page = null)



List of available server products


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generation** | **string** | Filter packages available on the given hardware generation (slug). Excludes free-tier-only packages when the generation is not free-tier eligible. | [optional]  |
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedServerProductList**](PaginatedServerProductList.md)

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

<a id="cloudserverpackagesretrieve"></a>
# **CloudServerPackagesRetrieve**
> ServerProduct CloudServerPackagesRetrieve (int id)



List of available server products


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this metered product. |  |

### Return type

[**ServerProduct**](ServerProduct.md)

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

<a id="cloudserversactivityretrieve"></a>
# **CloudServersActivityRetrieve**
> ActivityLogResponse CloudServersActivityRetrieve (int id)



Get activity log for a server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ActivityLogResponse**](ActivityLogResponse.md)

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

<a id="cloudserversattachipv4create"></a>
# **CloudServersAttachIpv4Create**
> AttachIPv4Response CloudServersAttachIpv4Create (int id, AttachIPv4Request attachIPv4Request)



Attach IPv4 address to server. The first attach lands on the primary NIC; subsequent attaches add a new secondary NIC carrying just that IPv4. The address is written to the machine's network configuration, which the guest OS only reads while booting: a running server answers `reboot_required: true` and stays unreachable on that address until it is restarted. Send `reboot: true` to have the restart issued here.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **attachIPv4Request** | [**AttachIPv4Request**](AttachIPv4Request.md) |  |  |

### Return type

[**AttachIPv4Response**](AttachIPv4Response.md)

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

<a id="cloudserversattachipv6create"></a>
# **CloudServersAttachIpv6Create**
> AttachIPv6Response CloudServersAttachIpv6Create (int id, AttachIPv6Request attachIPv6Request)



Attach IPv6 address to server. Like IPv4, the address is written to the machine's network configuration and the guest OS reads it while booting: a running server answers `reboot_required: true` until it is restarted. Send `reboot: true` to have the restart issued here.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **attachIPv6Request** | [**AttachIPv6Request**](AttachIPv6Request.md) |  |  |

### Return type

[**AttachIPv6Response**](AttachIPv6Response.md)

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

<a id="cloudserversbootisoslist"></a>
# **CloudServersBootIsosList**
> List&lt;BootISO&gt; CloudServersBootIsosList (int id)



List the ISO catalog entries visible to this user and their package compatibility.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**List&lt;BootISO&gt;**](BootISO.md)

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

<a id="cloudserversconsolecreate"></a>
# **CloudServersConsoleCreate**
> ConsoleToken CloudServersConsoleCreate (int id)



Get a VNC console token for browser-based access.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ConsoleToken**](ConsoleToken.md)

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

<a id="cloudserverscreate"></a>
# **CloudServersCreate**
> ServerAddResponse CloudServersCreate (ServerAddRequest serverAddRequest)



Create new server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverAddRequest** | [**ServerAddRequest**](ServerAddRequest.md) |  |  |

### Return type

[**ServerAddResponse**](ServerAddResponse.md)

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

<a id="cloudserversdestroy"></a>
# **CloudServersDestroy**
> void CloudServersDestroy (int id)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

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

<a id="cloudserversdestroyprotectioncreate"></a>
# **CloudServersDestroyProtectionCreate**
> DestroyProtectionResponse CloudServersDestroyProtectionCreate (int id, DestroyProtectionRequest destroyProtectionRequest)



Enable or disable destroy protection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **destroyProtectionRequest** | [**DestroyProtectionRequest**](DestroyProtectionRequest.md) |  |  |

### Return type

[**DestroyProtectionResponse**](DestroyProtectionResponse.md)

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

<a id="cloudserversdetachipv4create"></a>
# **CloudServersDetachIpv4Create**
> ServerDetachIPv4Response CloudServersDetachIpv4Create (int id, string ipv4 = null)



Detach IPv4 from server. Without `ipv4`, the primary NIC's IPv4 is detached. Pass `ipv4=<id|slug>` to target a specific attached address (required when the server has more than one IPv4).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **ipv4** | **string** | ID or slug of the IPv4 address to detach. | [optional]  |

### Return type

[**ServerDetachIPv4Response**](ServerDetachIPv4Response.md)

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

<a id="cloudserversdetachipv6create"></a>
# **CloudServersDetachIpv6Create**
> DetachIPv6 CloudServersDetachIpv6Create (int id)



Detach IPv6 from server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**DetachIPv6**](DetachIPv6.md)

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

<a id="cloudserverslist"></a>
# **CloudServersList**
> PaginatedServerList CloudServersList (int page = null)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedServerList**](PaginatedServerList.md)

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

<a id="cloudserversmodifypackagecreate"></a>
# **CloudServersModifyPackageCreate**
> ServerUpgradeResponse CloudServersModifyPackageCreate (int id, ServerProductUpgradeRequest serverProductUpgradeRequest)



Modify server package: downgrade available only for packages with the same disk size.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **serverProductUpgradeRequest** | [**ServerProductUpgradeRequest**](ServerProductUpgradeRequest.md) |  |  |

### Return type

[**ServerUpgradeResponse**](ServerUpgradeResponse.md)

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

<a id="cloudserversmonitoringretrieve"></a>
# **CloudServersMonitoringRetrieve**
> ServerMonitoring CloudServersMonitoringRetrieve (int id)



Show whether monitoring alerts are on for this server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ServerMonitoring**](ServerMonitoring.md)

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

<a id="cloudserversmonitoringupdate"></a>
# **CloudServersMonitoringUpdate**
> ServerMonitoring CloudServersMonitoringUpdate (int id, ServerMonitoringRequest serverMonitoringRequest)



Turn monitoring alerts on or off. Only an active server can change it.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **serverMonitoringRequest** | [**ServerMonitoringRequest**](ServerMonitoringRequest.md) |  |  |

### Return type

[**ServerMonitoring**](ServerMonitoring.md)

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

<a id="cloudserverspartialupdate"></a>
# **CloudServersPartialUpdate**
> ServerDetail CloudServersPartialUpdate (int id, PatchedServerDetailRequest patchedServerDetailRequest = null)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **patchedServerDetailRequest** | [**PatchedServerDetailRequest**](PatchedServerDetailRequest.md) |  | [optional]  |

### Return type

[**ServerDetail**](ServerDetail.md)

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

<a id="cloudserverspowermanagementcreate"></a>
# **CloudServersPowerManagementCreate**
> PowerManagement CloudServersPowerManagementCreate (int id, PowerManagementRequest powerManagementRequest)



Queue a power action and return the state observed before queueing. If the state cannot be read, the action is refused with HTTP 503.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **powerManagementRequest** | [**PowerManagementRequest**](PowerManagementRequest.md) |  |  |

### Return type

[**PowerManagement**](PowerManagement.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **503** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudserverspowermanagementretrieve"></a>
# **CloudServersPowerManagementRetrieve**
> PowerManagement CloudServersPowerManagementRetrieve (int id)



Read the server's power state and the reason if it is unavailable.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**PowerManagement**](PowerManagement.md)

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

<a id="cloudserverspublicinterfacecreate"></a>
# **CloudServersPublicInterfaceCreate**
> PublicInterface CloudServersPublicInterfaceCreate (int id, PublicInterfaceRequest publicInterfaceRequest = null)



Public interface


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **publicInterfaceRequest** | [**PublicInterfaceRequest**](PublicInterfaceRequest.md) |  | [optional]  |

### Return type

[**PublicInterface**](PublicInterface.md)

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

<a id="cloudserverspublicinterfacedestroy"></a>
# **CloudServersPublicInterfaceDestroy**
> void CloudServersPublicInterfaceDestroy (int id)



Public interface


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

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

<a id="cloudserverspublicinterfaceretrieve"></a>
# **CloudServersPublicInterfaceRetrieve**
> PublicInterface CloudServersPublicInterfaceRetrieve (int id)



Public interface


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**PublicInterface**](PublicInterface.md)

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

<a id="cloudserversrescueentercreate"></a>
# **CloudServersRescueEnterCreate**
> RescueEnterQueued CloudServersRescueEnterCreate (int id, IsoBootRequest isoBootRequest = null)



Boot the server from the default rescue image or a catalog ISO. The server is powered off first; use the console to complete the repair or installation. Not available for HA servers.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **isoBootRequest** | [**IsoBootRequest**](IsoBootRequest.md) |  | [optional]  |

### Return type

[**RescueEnterQueued**](RescueEnterQueued.md)

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

<a id="cloudserversrescueexitcreate"></a>
# **CloudServersRescueExitCreate**
> RescueExitQueued CloudServersRescueExitCreate (int id)



Exit rescue mode: detach the rescue ISO, restore the original boot order, and boot normally.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**RescueExitQueued**](RescueExitQueued.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudserversretrieve"></a>
# **CloudServersRetrieve**
> ServerDetail CloudServersRetrieve (int id)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ServerDetail**](ServerDetail.md)

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

<a id="cloudserversretryprovisioncreate"></a>
# **CloudServersRetryProvisionCreate**
> RetryProvision CloudServersRetryProvisionCreate (int id)



Retry provision in case of a failed server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**RetryProvision**](RetryProvision.md)

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

<a id="cloudserverssnapshotscreate"></a>
# **CloudServersSnapshotsCreate**
> SnapshotCreateQueued CloudServersSnapshotsCreate (int id, SnapshotCreateRequest snapshotCreateRequest)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **snapshotCreateRequest** | [**SnapshotCreateRequest**](SnapshotCreateRequest.md) |  |  |

### Return type

[**SnapshotCreateQueued**](SnapshotCreateQueued.md)

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

<a id="cloudserverssnapshotsdestroy"></a>
# **CloudServersSnapshotsDestroy**
> SnapshotDeleteQueued CloudServersSnapshotsDestroy (int id, string snapshotName)



Delete a snapshot.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **snapshotName** | **string** |  |  |

### Return type

[**SnapshotDeleteQueued**](SnapshotDeleteQueued.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudserverssnapshotslist"></a>
# **CloudServersSnapshotsList**
> List&lt;Snapshot&gt; CloudServersSnapshotsList (int id)



List snapshots for this server or queue a new snapshot.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**List&lt;Snapshot&gt;**](Snapshot.md)

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

<a id="cloudserverssnapshotsrollbackcreate"></a>
# **CloudServersSnapshotsRollbackCreate**
> SnapshotRollbackQueued CloudServersSnapshotsRollbackCreate (int id, string snapshotName)



Rollback the server to a specific snapshot.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **snapshotName** | **string** |  |  |

### Return type

[**SnapshotRollbackQueued**](SnapshotRollbackQueued.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudserverstrafficretrieve"></a>
# **CloudServersTrafficRetrieve**
> ServerTrafficResponse CloudServersTrafficRetrieve (int id)



Get this month's traffic usage for a server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ServerTrafficResponse**](ServerTrafficResponse.md)

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

<a id="cloudserversupdate"></a>
# **CloudServersUpdate**
> ServerDetail CloudServersUpdate (int id, ServerDetailRequest serverDetailRequest = null)



Cloud servers


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |
| **serverDetailRequest** | [**ServerDetailRequest**](ServerDetailRequest.md) |  | [optional]  |

### Return type

[**ServerDetail**](ServerDetail.md)

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

<a id="cloudserversusageretrieve"></a>
# **CloudServersUsageRetrieve**
> ServerUsageResponse CloudServersUsageRetrieve (int id)



Get current resource usage for a server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this virtual machine. |  |

### Return type

[**ServerUsageResponse**](ServerUsageResponse.md)

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

<a id="cloudserversvolumescreate"></a>
# **CloudServersVolumesCreate**
> Volume CloudServersVolumesCreate (string serverId, VolumeRequest volumeRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |
| **volumeRequest** | [**VolumeRequest**](VolumeRequest.md) |  |  |

### Return type

[**Volume**](Volume.md)

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

<a id="cloudserversvolumesdestroy"></a>
# **CloudServersVolumesDestroy**
> void CloudServersVolumesDestroy (string serverId, string volumeId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |
| **volumeId** | **string** |  |  |

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

<a id="cloudserversvolumeslist"></a>
# **CloudServersVolumesList**
> List&lt;Volume&gt; CloudServersVolumesList (string serverId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |

### Return type

[**List&lt;Volume&gt;**](Volume.md)

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

<a id="cloudserversvolumespartialupdate"></a>
# **CloudServersVolumesPartialUpdate**
> Volume CloudServersVolumesPartialUpdate (string serverId, string volumeId, PatchedVolumeUpdateRequest patchedVolumeUpdateRequest = null)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |
| **volumeId** | **string** |  |  |
| **patchedVolumeUpdateRequest** | [**PatchedVolumeUpdateRequest**](PatchedVolumeUpdateRequest.md) |  | [optional]  |

### Return type

[**Volume**](Volume.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudserversvolumesretrieve"></a>
# **CloudServersVolumesRetrieve**
> Volume CloudServersVolumesRetrieve (string serverId, string volumeId)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |
| **volumeId** | **string** |  |  |

### Return type

[**Volume**](Volume.md)

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

<a id="cloudserversvolumesupdate"></a>
# **CloudServersVolumesUpdate**
> Volume CloudServersVolumesUpdate (string serverId, string volumeId, VolumeUpdateRequest volumeUpdateRequest)



Adds :class:`~account.iam_enforcement.IAMActionPermission` as an intersection with the route's existing permission classes (spec §6).  Detail routes (``self.detail``) defer the role/scope check to ``has_object_permission`` so the account-scoped ``get_object`` answers 404 for foreign IDs before any role denial; every other route enforces in ``has_permission``. A detail action that never calls ``get_object`` would skip enforcement — the route probes pin the denial for each route.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverId** | **string** |  |  |
| **volumeId** | **string** |  |  |
| **volumeUpdateRequest** | [**VolumeUpdateRequest**](VolumeUpdateRequest.md) |  |  |

### Return type

[**Volume**](Volume.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudstorageproductslist"></a>
# **CloudStorageProductsList**
> PaginatedStorageProductList CloudStorageProductsList (int page = null)



List of available storage products


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | A page number within the paginated result set. | [optional]  |

### Return type

[**PaginatedStorageProductList**](PaginatedStorageProductList.md)

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

<a id="cloudstorageproductsretrieve"></a>
# **CloudStorageProductsRetrieve**
> StorageProduct CloudStorageProductsRetrieve (int id)



List of available storage products


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this metered product. |  |

### Return type

[**StorageProduct**](StorageProduct.md)

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

<a id="cloudvolumesattachcreate"></a>
# **CloudVolumesAttachCreate**
> AttachVolume CloudVolumesAttachCreate (int id, AttachVolumeRequest attachVolumeRequest)



Attach existing volume to a server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |
| **attachVolumeRequest** | [**AttachVolumeRequest**](AttachVolumeRequest.md) |  |  |

### Return type

[**AttachVolume**](AttachVolume.md)

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

<a id="cloudvolumesdestroy"></a>
# **CloudVolumesDestroy**
> void CloudVolumesDestroy (int id)



Volumes management


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |

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

<a id="cloudvolumesdetachcreate"></a>
# **CloudVolumesDetachCreate**
> DetachVolume CloudVolumesDetachCreate (int id)



Detach volume from server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |

### Return type

[**DetachVolume**](DetachVolume.md)

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

<a id="cloudvolumeslist"></a>
# **CloudVolumesList**
> List&lt;Volume&gt; CloudVolumesList ()



Volumes management


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Volume&gt;**](Volume.md)

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

<a id="cloudvolumespartialupdate"></a>
# **CloudVolumesPartialUpdate**
> Volume CloudVolumesPartialUpdate (int id, PatchedVolumeUpdateRequest patchedVolumeUpdateRequest = null)



Volumes management


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |
| **patchedVolumeUpdateRequest** | [**PatchedVolumeUpdateRequest**](PatchedVolumeUpdateRequest.md) |  | [optional]  |

### Return type

[**Volume**](Volume.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cloudvolumesretrieve"></a>
# **CloudVolumesRetrieve**
> Volume CloudVolumesRetrieve (int id)



Volumes management


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |

### Return type

[**Volume**](Volume.md)

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

<a id="cloudvolumesupdate"></a>
# **CloudVolumesUpdate**
> Volume CloudVolumesUpdate (int id, VolumeUpdateRequest volumeUpdateRequest)



Volumes management


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this storage. |  |
| **volumeUpdateRequest** | [**VolumeUpdateRequest**](VolumeUpdateRequest.md) |  |  |

### Return type

[**Volume**](Volume.md)

### Authorization

[tokenAuth](../README.md#tokenAuth), [cookieAuth](../README.md#cookieAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


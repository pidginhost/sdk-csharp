# PidginHost.Sdk.Model.ServerRoute
A server's default route on the network (spec 6.3): cloud-init evidence from Proxmox, not proof that the running guest has the route. A server Proxmox could not tell about is unknown.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | **int** |  | 
**Hostname** | **string** |  | 
**Power** | **RoutePowerEnum** |  | 
**Config** | **RouteConfigEnum** | The spec 6.2 rule over current config.  * &#x60;ok&#x60; - ok * &#x60;missing&#x60; - missing * &#x60;duplicate&#x60; - duplicate * &#x60;obsolete&#x60; - obsolete * &#x60;unknown&#x60; - unknown | 
**RoutesHere** | **bool** | The rule gives this network&#39;s interface the default route. | 
**Acknowledged** | **bool** | The last route apply&#39;s config and boot still hold. | 
**Pending** | **RouteConfigEnum** | The rule over the config a reboot applies; null without one.  * &#x60;ok&#x60; - ok * &#x60;missing&#x60; - missing * &#x60;duplicate&#x60; - duplicate * &#x60;obsolete&#x60; - obsolete * &#x60;unknown&#x60; - unknown | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


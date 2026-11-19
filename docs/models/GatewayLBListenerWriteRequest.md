# PidginHost.Sdk.Model.GatewayLBListenerWriteRequest
The fields a customer writes; gateway.lb_listeners.clean_listener decides what they may hold.  protocol, port and mode are set at creation and cannot change.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **GatewayForwardProtocolEnum** |  | [optional] 
**Port** | **int** |  | [optional] 
**Mode** | **GatewayLBListenerModeEnum** | tcp, udp or http; https is not available yet.  * &#x60;tcp&#x60; - tcp * &#x60;udp&#x60; - udp * &#x60;http&#x60; - http * &#x60;https&#x60; - https | [optional] 
**Pool** | **int** | A backend pool&#39;s id; tcp and udp only. | [optional] 
**AllowedSources** | **List&lt;string&gt;** | IPv4 and IPv6 networks; empty means any source. | [optional] 
**Enabled** | **bool** |  | [optional] 
**Comment** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


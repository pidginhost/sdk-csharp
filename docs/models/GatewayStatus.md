# PidginHost.Sdk.Model.GatewayStatus
A gateway's state and the customer part of its last status report; unknown values are null.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **GatewayStateEnum** |  | 
**StateReason** | **string** |  | 
**DesiredRevision** | **int** |  | 
**StateChangedAt** | **string** |  | 
**AppliedRevision** | **int** |  | 
**LastStatusAt** | **string** |  | 
**AgentVersion** | **string** |  | 
**EnvoyVersion** | **string** |  | 
**ImageVersion** | **string** |  | 
**AttemptedRevision** | **int** |  | 
**LocalReady** | **bool** |  | 
**ClockSynchronized** | **bool** |  | 
**ApplyError** | [**GatewayApplyError**](GatewayApplyError.md) |  | 
**Interfaces** | [**List&lt;GatewayInterface&gt;**](GatewayInterface.md) |  | 
**Conntrack** | [**GatewayConntrack**](GatewayConntrack.md) |  | 
**EgressProbe** | [**GatewayEgressProbe**](GatewayEgressProbe.md) |  | 
**SecurityUpdates** | **int** |  | 
**RebootRequired** | **bool** |  | 
**UptimeS** | **int** |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


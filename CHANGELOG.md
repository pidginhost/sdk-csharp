# Changelog

All notable changes to the PidginHost C#/.NET SDK are documented here.

This SDK is auto-generated from the [PidginHost API schema](https://www.pidginhost.com/api/schema/).
Version bumps reflect schema changes, not hand-written code changes.

## v0.18.0

First release of the C#/.NET SDK, covering the same API as the other
PidginHost SDKs at v0.18.0 (including the bucket destroy protection and server
monitoring endpoints added in this release).

### Added

- `PidginHostClient`, a wrapper that takes an API token and exposes one
  property per API group (`Account`, `Auth`, `Billing`, `Cloud`, `Dedicated`,
  `Domain`, `Email`, `Freedns`, `Hosting`, `Kubernetes`, `Support`).
- Decimal amounts (prices, balances) are `string`, matching what the API sends.

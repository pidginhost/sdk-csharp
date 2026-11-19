# PidginHost C# / .NET SDK

Official .NET client for the [PidginHost API](https://www.pidginhost.com/api/schema/).
Targets .NET 8. Every call is async.

This repository is generated from the PidginHost OpenAPI schema; changes made
here directly are overwritten by the next release.

## Install

```bash
dotnet add package PidginHost.Sdk
```

## Quickstart

```csharp
using PidginHost.Sdk;

using var client = new PidginHostClient(Environment.GetEnvironmentVariable("PIDGINHOST_API_TOKEN")!);

// List all servers (paginated: pass page: N for further pages)
var response = await client.Cloud.CloudServersListAsync();
var page = response.Ok()!;
foreach (var server in page.Results)
    Console.WriteLine(server.Hostname);

// List SSH keys
var keys = (await client.Account.AccountSshKeysListAsync()).Ok();
```

Each call returns a response object: `IsOk` tells whether the API answered
200, `Ok()` returns the parsed body, and `RawContent` / `StatusCode` are there
for everything else. The `...OrDefaultAsync` variants return `null` instead of
throwing.

`PidginHostClient(token, baseUrl, emailApiKey)` also takes an alternative API
host and, for `client.Email.EmailSendCreateAsync`, the email sending key
(`phme_...`).

The client exposes these API groups:
- `client.Account` -- account, companies, SSH keys
- `client.Auth` -- authentication, tokens
- `client.Billing` -- invoices, payments, funds
- `client.Cloud` -- servers, images, volumes, IPs, firewalls, networks
- `client.Dedicated` -- dedicated servers
- `client.Domain` -- domains, registrants, TLDs
- `client.Email` -- email services, sending domains, credentials, suppressions
- `client.Freedns` -- free DNS zones and records
- `client.Hosting` -- web hosting
- `client.Kubernetes` -- clusters, resource pools, routes
- `client.Support` -- support tickets

## Dependency injection

Apps built on `Microsoft.Extensions.Hosting` can register the APIs directly
and inject `ICloudApi`, `IAccountApi`, and so on:

```csharp
using PidginHost.Sdk.Client;
using PidginHost.Sdk.Extensions;

builder.ConfigureApi(options =>
{
    options.AddTokens(new ApiKeyToken(token, ClientUtils.ApiKeyHeader.Authorization, "Token "));
    options.AddApiHttpClients(builder: http => http.AddRetryPolicy(3));
});
```

## Documentation

- API groups: [docs/apis](docs/apis)
- Models: [docs/models](docs/models)
- Changes: [CHANGELOG.md](CHANGELOG.md)

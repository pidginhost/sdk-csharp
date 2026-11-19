// PidginHost API client: a simple wrapper around the generated SDK.
//
// Hand-written; injected into the generated output by scripts/post-generate.sh
// (csharp/src/PidginHost.cs in the sdk repo). Edit it there, not in sdk-csharp.
//
// Usage:
//
//     using PidginHost.Sdk;
//
//     using var client = new PidginHostClient("your-api-token");
//     var page = (await client.Cloud.CloudServersListAsync()).Ok();
//     foreach (var server in page!.Results)
//         Console.WriteLine(server.Hostname);
//
// The generated APIs are built for Microsoft.Extensions.DependencyInjection.
// Apps that already use a host can register them directly instead:
// services.AddApi(o => o.AddTokens(new ApiKeyToken(token, ClientUtils.ApiKeyHeader.Authorization, "Token "))).

#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PidginHost.Sdk.Api;
using PidginHost.Sdk.Client;
using PidginHost.Sdk.Extensions;

namespace PidginHost.Sdk
{
    /// <summary>
    /// PidginHost API client. Exposes one property per API group.
    /// </summary>
    public sealed class PidginHostClient : IDisposable, IAsyncDisposable
    {
        private readonly ServiceProvider _services;

        /// <summary>Account, companies, SSH keys.</summary>
        public IAccountApi Account { get; }
        /// <summary>Authentication, tokens.</summary>
        public IAuthApi Auth { get; }
        /// <summary>Invoices, payments, funds.</summary>
        public IBillingApi Billing { get; }
        /// <summary>Servers, images, volumes, IPs, firewalls, networks.</summary>
        public ICloudApi Cloud { get; }
        /// <summary>Dedicated servers.</summary>
        public IDedicatedApi Dedicated { get; }
        /// <summary>Domains, registrants, TLDs.</summary>
        public IDomainApi Domain { get; }
        /// <summary>Email services, sending domains, credentials, suppressions.</summary>
        public IEmailApi Email { get; }
        /// <summary>Free DNS zones and records.</summary>
        public IFreednsApi Freedns { get; }
        /// <summary>Web hosting.</summary>
        public IHostingApi Hosting { get; }
        /// <summary>Clusters, resource pools, routes.</summary>
        public IKubernetesApi Kubernetes { get; }
        /// <summary>Support tickets.</summary>
        public ISupportApi Support { get; }

        /// <summary>
        /// Create a client.
        /// </summary>
        /// <param name="token">API authentication token.</param>
        /// <param name="baseUrl">Override the default API host (https://www.pidginhost.com).</param>
        /// <param name="emailApiKey">
        /// Email sending key (<c>phme_...</c>), needed only by <c>Email.EmailSendCreateAsync</c>.
        /// </param>
        public PidginHostClient(string token, string? baseUrl = null, string? emailApiKey = null)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("An API token is required.", nameof(token));

            var baseAddress = new Uri(baseUrl ?? ClientUtils.BASE_ADDRESS);
            var services = new ServiceCollection();
            services.AddLogging();

            // Every generated API asks for both token providers, so one must be
            // registered even when no email key is given; this one explains why
            // the single endpoint that needs it cannot be called.
            if (emailApiKey is null)
                services.AddSingleton<TokenProvider<BearerToken>, MissingEmailApiKeyProvider>();

            services.AddApi(options =>
            {
                options.AddTokens(new ApiKeyToken(token, ClientUtils.ApiKeyHeader.Authorization, "Token "));
                if (emailApiKey is not null)
                    options.AddTokens(new BearerToken(emailApiKey));
                options.AddApiHttpClients(client => client.BaseAddress = baseAddress);
            });

            _services = services.BuildServiceProvider();

            Account = _services.GetRequiredService<IAccountApi>();
            Auth = _services.GetRequiredService<IAuthApi>();
            Billing = _services.GetRequiredService<IBillingApi>();
            Cloud = _services.GetRequiredService<ICloudApi>();
            Dedicated = _services.GetRequiredService<IDedicatedApi>();
            Domain = _services.GetRequiredService<IDomainApi>();
            Email = _services.GetRequiredService<IEmailApi>();
            Freedns = _services.GetRequiredService<IFreednsApi>();
            Hosting = _services.GetRequiredService<IHostingApi>();
            Kubernetes = _services.GetRequiredService<IKubernetesApi>();
            Support = _services.GetRequiredService<ISupportApi>();
        }

        /// <inheritdoc />
        public void Dispose() => _services.Dispose();

        /// <inheritdoc />
        public ValueTask DisposeAsync() => _services.DisposeAsync();

        private sealed class MissingEmailApiKeyProvider : TokenProvider<BearerToken>
        {
            protected internal override ValueTask<BearerToken> GetAsync(string header = "", CancellationToken cancellation = default) =>
                throw new InvalidOperationException(
                    "This endpoint authenticates with an email API key (phme_...). " +
                    "Pass it as emailApiKey when creating the PidginHostClient.");
        }
    }
}

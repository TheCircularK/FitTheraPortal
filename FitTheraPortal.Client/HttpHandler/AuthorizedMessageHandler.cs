using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace FitTheraPortal.Client.HttpHandler;

public class AuthorizedMessageHandler : DelegatingHandler
{
    private readonly IAccessTokenProvider _accessTokenProvider;
    private readonly IConfiguration _configuration;

    public AuthorizedMessageHandler(IAccessTokenProvider accessTokenProvider, IConfiguration configuration)
    {
        _accessTokenProvider = accessTokenProvider;
        _configuration = configuration;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var tokenResult = await _accessTokenProvider.RequestAccessToken();
        
        if (tokenResult.TryGetToken(out var token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);
            request.Headers.Add("Audience", "https://api.fitthera.com");
        }
        else
        {
            throw new AccessTokenNotAvailableException(null, tokenResult, null);
        }
        
        return await base.SendAsync(request, cancellationToken);
    }
}
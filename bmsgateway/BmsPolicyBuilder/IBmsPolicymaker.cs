using Microsoft.AspNetCore.Mvc;
using Polly;

namespace bmsgateway
{
    public interface IBmsPolicymaker
    {
        IAsyncPolicy<IActionResult> GetAsyncWaitAndRetryPolicy();
        IAsyncPolicy<IActionResult> GetAsyncFallbakPolicy();
    }

}
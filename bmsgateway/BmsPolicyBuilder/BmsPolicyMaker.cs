namespace bmsgateway
{
    using Microsoft.AspNetCore.Mvc;
    using Polly;
    public class BmsPolicyMaker : ControllerBase, IBmsPolicymaker
    {
        public IAsyncPolicy<IActionResult> GetAsyncWaitAndRetryPolicy()
        {
            return Policy<IActionResult>
        .Handle<Exception>()
        .RetryAsync(2);
        }
        public IAsyncPolicy<IActionResult> GetAsyncFallbakPolicy()
        {
            return Policy<IActionResult>
        .Handle<Exception>()
        .FallbackAsync(Content("Sorry, we are currently experiencing issues. Please try again later"));
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Microsoft.Extensions.Primitives;

namespace SnowWarden.Backend.API.Attributes;

public class RequireApiKeyAttribute : ActionFilterAttribute
{
	private const string ApiKeyHeaderName = "Authorization";
	private IConfiguration? _configuration;

	public override void OnActionExecuting(ActionExecutingContext context)
	{
		_configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
		ILogger<RequireApiKeyAttribute> logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<RequireApiKeyAttribute>>();
		if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out StringValues potentialApiKey))
		{
			context.Result = new UnauthorizedResult();
			return;
		}

		string? apiKey = _configuration?.GetValue<string>("Communications:IoT:ApiKey");

		if (!(apiKey?.Equals(potentialApiKey) ?? false))
		{
			context.Result = new UnauthorizedResult();
			return;
		}

		logger.LogInformation("Iot device has been authorized");

		base.OnActionExecuting(context);
	}
}
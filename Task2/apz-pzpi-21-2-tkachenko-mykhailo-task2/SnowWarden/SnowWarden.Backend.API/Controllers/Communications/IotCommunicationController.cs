using Microsoft.AspNetCore.Mvc;
using SnowWarden.Backend.API.Attributes;
using SnowWarden.Backend.Core.Abstractions.Events;
using SnowWarden.Backend.Core.Features.Communications.IoT;
using SnowWarden.Backend.Core.Features.Communications.IoT.Events;
using SnowWarden.Backend.Core.Features.Track;
using SnowWarden.Backend.Core.Features.Track.Services;

namespace SnowWarden.Backend.API.Controllers.Communications;

[Route("communications/iot")]
public class IotCommunicationController(
	ITrackSectionService trackSectionService,
	IEventBus eventBus,
	ILogger<IotCommunicationController> logger) : ControllerBase
{
	[Route("")]
	[HttpPost]
	[RequireApiKey]
	public async Task<IActionResult> ReceiveData([FromBody] IoTMonitoringDeviceMessage iotData)
	{
		logger.LogInformation("Iot device communication is open");

		if (iotData.MessageType > IotMessageType.Monitor)
		{
			await eventBus.PublishAsync(new DangerousWeatherConditionsReceivedEvent(iotData));
		}

		logger.LogInformation("Iot device communication closed");

		return Ok();
	}

	// [Route("./discovery")]
	// [HttpGet]
	// [RequireApiKey]
	// public async Task<IActionResult> GetActiveSections()
	// {
	// 	List<Section> allSections = await trackSectionService.GetLightweightAsync();
	//
	// }
}
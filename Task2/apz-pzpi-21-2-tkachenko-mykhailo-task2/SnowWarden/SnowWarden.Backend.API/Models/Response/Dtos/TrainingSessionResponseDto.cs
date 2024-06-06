using SnowWarden.Backend.Core.Features.Training;

namespace SnowWarden.Backend.API.Models.Response.Dtos;

public class TrainingSessionResponseDto
{
	public int Id { get; private set; }
	public int TrackId { get; set; }
	public int InstructorId { get; set; }
	public ICollection<string> Levels { get; set; } = [];
	public TrainingInformation Information { get; set; }
	public TrackResponseDto Track { get; set; }
	public UserResponseDto Instructor { get; set; }
	public ICollection<InventoryItemResponseDto> ReservedItems { get; set; }
}
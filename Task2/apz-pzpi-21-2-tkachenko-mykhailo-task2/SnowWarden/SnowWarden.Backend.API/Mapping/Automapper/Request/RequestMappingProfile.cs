using AutoMapper;

using SnowWarden.Backend.API.Models.Requests.Dtos;

using SnowWarden.Backend.Core.Features.Inventory;
using SnowWarden.Backend.Core.Features.Members;
using SnowWarden.Backend.Core.Features.Track;
using SnowWarden.Backend.Core.Features.Training;

namespace SnowWarden.Backend.API.Mapping.Automapper.Request;

public class RequestMappingProfile : Profile
{
	public RequestMappingProfile()
	{
		CreateMap<TrainingSessionPostDto, TrainingSession>();
			// .ForMember(s => s.Instructor, opt => opt.MapFrom<InstructorResolver>())
			// .ForMember(s => s.Track, opt => opt.MapFrom<TrackResolver>());
		CreateMap<InventoryPostDto, Inventory>();
		CreateMap<InventoryItemPostDto, InventoryItem>();
		CreateMap<TrackPostDto, Track>();
		CreateMap<SectionPostDto, Section>().ForMember(s => s.DeterminingFactors, opt => opt.MapFrom<FactorResolver>());
	}

	private class FactorResolver : IValueResolver<SectionPostDto, Section, SectionFactors>
	{
		public SectionFactors Resolve(SectionPostDto source, Section destination, SectionFactors destMember, ResolutionContext context)
		{
			destMember = new SectionFactors
			{
				{
					FactorKeys.WIND,
					new SectionFactor
					{
						Key = FactorKeys.WIND,
						MultiplicationValue = source.Factors.Wind
					}
				},
				{
					FactorKeys.SNOW,
					new SectionFactor
					{
						Key = FactorKeys.SNOW,
						MultiplicationValue = source.Factors.Snow
					}
				},
				{
					FactorKeys.ICINESS,
					new SectionFactor
					{
						Key = FactorKeys.ICINESS,
						MultiplicationValue = source.Factors.Iciness
					}
				},
			};

			return destMember;
		}
	}

	// private class InstructorResolver : IValueResolver<TrainingSessionPostDto, TrainingSession, Instructor>
	// {
	// 	public Instructor Resolve(TrainingSessionPostDto source, TrainingSession destination, Instructor destMember, ResolutionContext context)
	// 	{
	// 		Instructor instructor = new();
	// 		instructor.SetExistingId(source.InstructorId);
	// 		return instructor;
	// 	}
	// }

	// private class TrackResolver : IValueResolver<TrainingSessionPostDto, TrainingSession, Track>
	// {
	// 	public Track Resolve(TrainingSessionPostDto source, TrainingSession destination, Track destMember, ResolutionContext context)
	// 	{
	// 		Track track = new();
	// 		track.SetExistingId(source.TrackId);
	// 		return track;
	// 	}
	// }
}
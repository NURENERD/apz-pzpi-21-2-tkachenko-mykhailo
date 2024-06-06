using SnowWarden.Backend.Core.Abstractions;

using SnowWarden.Backend.Core.Features.Track;
using SnowWarden.Backend.Core.Features.Track.Services;

namespace SnowWarden.Backend.Application.Services;

public class TrackService(IRepository<Track> repository) : ServiceBase<Track>(repository), ITrackService
{
	// public Task<ICollection<Track>> CreateRange(params Track[] entities) => repository.CreateRange(entities);
	//
	// public Task<Track> CreateAsync(Track entity) => repository.CreateAsync(entity);
	//
	// public Task<Track> UpdateAsync(Track entity) => repository.UpdateAsync(entity);
	//
	// public Task<Track> DeleteAsync(Track entity) => repository.DeleteAsync(entity);
	//
	// public Task<Track?> GetByIdCompleteAsync(int id) => repository.GetByIdCompleteAsync(id);
	//
	// public Task<IReadOnlyCollection<Track>> GetReadonlyCompleteAsync(Expression<Func<Track, bool>> predicate) =>
	// 	repository.GetReadonlyCompleteAsync(predicate);
	//
	// public Task<IReadOnlyCollection<Track>> GetReadonlyCompleteAsync() => repository.GetReadonlyCompleteAsync();
	//
	// public Task<IReadOnlyCollection<Track>> GetReadonlyLightweightAsync() => repository.GetReadonlyLightweightAsync();
	//
	// public Task<IReadOnlyCollection<Track>> GetReadonlyLightweightAsync(Expression<Func<Track, bool>> predicate) =>
	// 	repository.GetReadonlyLightweightAsync(predicate);
	//
	// public Task<List<Track>> GetCompleteAsync() => repository.GetCompleteAsync();
	//
	// public Task<List<Track>> GetLightweightAsync() => repository.GetLightweightAsync();
}
using Ardalis.Result;
using HelpPlatform.Core.ResourceTypeDomain;
using HelpPlatform.SharedKernel;

namespace HelpPlatform.UseCases.ResourceTypes.List;

public class ListResourceTypeHandler(IReadRepository<ResourceType> _repository) : IQueryHandler<ListResourceTypesQuery, Result<IEnumerable<ResourceTypeDTO>>>
{
    public async Task<Result<IEnumerable<ResourceTypeDTO>>> Handle(ListResourceTypesQuery request, CancellationToken cancellationToken)
    {
        var resourceTypes = await _repository.ListAsync(cancellationToken);
        var resourceTypesDtos = resourceTypes.Select(resourceType => new ResourceTypeDTO(resourceType.Id, resourceType.Name, resourceType.Scale));

        return Result.Success(resourceTypesDtos);
    }
}

using MediatR;

namespace AspNetCore.Infrastructure.Mediation
{
    /// <summary>
    /// Get All Entities Query Interface
    /// </summary>
    /// <typeparam name="T">Type of entity retrieved</typeparam>
    public interface IGetAllQuery<T> : IRequest<OperationResult<IEnumerable<T>>>
    {
    }
}

using AspNetCore.Mediation;

namespace Sample.Application.Teams.Delete;

public class DeleteCommand : IDeleteCommand<Guid>
{
    public DeleteCommand(Guid id)
    {
        this.Id = id;
    }

    public Guid Id { get; }
}

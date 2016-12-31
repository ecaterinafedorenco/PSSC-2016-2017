using CQRS.Commands;
using Models.Repository;
using System;

namespace CQRS.CommandHandlers
{
    public class DeleteItemCommandHandler : ICommandHandler<DeleteItemCommand>
    {
        private readonly IRepository<SubjectsRepository> _repository;

        public DeleteItemCommandHandler(IRepository<SubjectsRepository> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.GetById(command.Id);
            aggregate.Delete();
            _repository.Save(aggregate, aggregate.Version);

        }
    }
}

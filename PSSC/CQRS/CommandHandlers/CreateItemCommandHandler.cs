using CQRS.Commands;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.CommandHandlers
{
    public class CreateItemCommandHandler : ICommandHandler<CreateItemCommand>
    {
        private IRepository<SubjectsRepository> _repository;

        public CreateItemCommandHandler(IRepository<SubjectsRepository> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            var aggregate = new SubjectsRepository(command.Id, command.Title, command.Description, command.From, command.To);
            aggregate.Version = -1;
            _repository.Save(aggregate, aggregate.Version);
        }
    }
}

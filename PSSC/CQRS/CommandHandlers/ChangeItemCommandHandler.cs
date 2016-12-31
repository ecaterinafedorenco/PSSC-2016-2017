using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contexts.Student;
using CQRS.Commands;
using Models.Repository;

namespace CQRS.CommandHandlers
{
    public class ChangeItemCommandHandler : ICommandHandler<ChangeItemCommand>
    {
        private readonly IRepository<SubjectsRepository> _repository;

        public ChangeItemCommandHandler(IRepository<SubjectsRepository> repository)
        {
            _repository = repository;
        }

        public void Execute(ChangeItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.FindById(command.Id);

            if (aggregate.Title != command.Title)
                aggregate.ChangeTitle(command.Title);

            if (aggregate.Description != command.Description)
                aggregate.ChangeDescription(command.Description);

            if (aggregate.From != command.From)
                aggregate.ChangeFrom(command.From);

            if (aggregate.To != command.To)
                aggregate.ChangeTo(command.To);

            _repository.Save(aggregate, command.Version);
        }
    }
}

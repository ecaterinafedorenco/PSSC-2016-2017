using CQRS.Commands;
using Models.Repository;
using System;


namespace CQRS.CommandHandlers
{
    public class ChangeCommandHandler : ICommandHandler<ChangeCommand> 
    {
        private readonly IRepository<SubjectsRepository> _repository;

        public ChangeCommandHandler(IRepository<SubjectsRepository> repository)
        {
            _repository = repository;
        }

        public void Execute(ChangeCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            //var aggregate = new Subject(command.Name, command.Credits);
            //_repository.Save(aggregate);
        }
    }
}

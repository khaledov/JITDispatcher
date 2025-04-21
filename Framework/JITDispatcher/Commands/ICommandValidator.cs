﻿namespace JITDispatcher.Commands;


public interface ICommandValidator<TCommand>  where TCommand : ICommand
{
    ValidationResult Validate(TCommand command);
}

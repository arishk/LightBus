﻿using LiteBus.Messaging.Abstractions;

namespace LiteBus.Commands.Abstractions;

/// <summary>
///     Represents an action that is executed on <typeparamref cref="TCommand" /> post-handle phase
/// </summary>
public interface ICommandPostHandler<in TCommand, in TCommandResult> : ICommandHandler,
                                                                       IAsyncPostHandler<TCommand, TCommandResult>
    where TCommand : ICommand<TCommandResult>
{
}
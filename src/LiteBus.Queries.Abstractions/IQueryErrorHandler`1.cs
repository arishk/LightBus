﻿using LiteBus.Messaging.Abstractions;

namespace LiteBus.Queries.Abstractions;

/// <summary>
///     Represents an action that is executed on <typeparamref cref="TQuery" /> error-handle phase
/// </summary>
public interface IQueryErrorHandler<in TQuery> : IQueryErrorHandlerBase, IAsyncErrorHandler<TQuery>
    where TQuery : IQueryBase
{
}
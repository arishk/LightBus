﻿using LiteBus.Messaging.Abstractions;

namespace LiteBus.Events.Abstractions;

/// <summary>
///     Represents an action that is executed on <typeparamref cref="TEvent" /> pre-handle phase
/// </summary>
public interface IEventPreHandler<in TEvent> : IEventHandler, IAsyncPreHandler<TEvent> where TEvent : IEvent
{
}
using System;
using LiteBus.Messaging.Abstractions;

namespace LiteBus.Messaging.Internal.Mediator;

internal class Mediator : IMediator
{
    private readonly IMessageRegistry _messageRegistry;
    private readonly IServiceProvider _serviceProvider;

    public Mediator(IMessageRegistry messageRegistry, IServiceProvider serviceProvider)
    {
        _messageRegistry = messageRegistry;
        _serviceProvider = serviceProvider;
    }

    public TMessageResult Mediate<TMessage, TMessageResult>(TMessage message,
                                                            IDiscoveryWorkflow discovery,
                                                            IResolutionWorkflow resolution,
                                                            IExecutionWorkflow<TMessage, TMessageResult> execution)
    {
        var messageType = message.GetType();

        var messageDescriptor = discovery.Discover(_messageRegistry, messageType);

        var resolutionContext = resolution.Resolve(messageDescriptor, _serviceProvider);

        return execution.Execute(message, resolutionContext);
    }
}
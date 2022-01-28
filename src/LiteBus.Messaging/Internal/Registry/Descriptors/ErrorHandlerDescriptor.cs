using System;
using LiteBus.Messaging.Abstractions.Metadata;

namespace LiteBus.Messaging.Internal.Registry.Descriptors;

internal class ErrorHandlerDescriptor : IErrorHandlerDescriptor
{
    public ErrorHandlerDescriptor(Type errorHandlerType, Type messageType, int order)
    {
        ErrorHandlerType = errorHandlerType;
        Order = order;
        IsGeneric = messageType.IsGenericType;
        MessageType = IsGeneric ? messageType.GetGenericTypeDefinition() : messageType;
    }

    public Type ErrorHandlerType { get; }

    public int Order { get; }

    public bool IsGeneric { get; set; }

    public Type MessageType { get; }
}
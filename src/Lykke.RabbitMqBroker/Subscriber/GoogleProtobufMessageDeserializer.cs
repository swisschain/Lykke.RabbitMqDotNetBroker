using Google.Protobuf;
using JetBrains.Annotations;

namespace Lykke.RabbitMqBroker.Subscriber
{
    /// <summary>
    /// Uses Google Protobuf to deserialize the message.
    /// </summary>
    [PublicAPI]
    public class GoogleProtobufMessageDeserializer<TMessage> : IMessageDeserializer<TMessage>
        where TMessage : IMessage<TMessage>, new()
    {
        /// <inheritdoc />
        public TMessage Deserialize(byte[] data)
        {
            var message = new TMessage();
            message.MergeFrom(data);

            return message;
        }
    }
}

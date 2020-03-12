using System.IO;
using Google.Protobuf;
using JetBrains.Annotations;

namespace Lykke.RabbitMqBroker.Publisher
{
    [PublicAPI]
    public class GoogleProtobufMessageSerializer<TMessage> : IRabbitMqSerializer<TMessage>
        where TMessage : IMessage<TMessage>, new()
    {
        public byte[] Serialize(TMessage model)
        {
            using (var stream = new MemoryStream())
            {
                model.WriteTo(stream);
                return stream.ToArray();
            }
        }
    }
}

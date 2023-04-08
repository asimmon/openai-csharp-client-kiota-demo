using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateChatCompletionResponse_choices : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The finish_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinishReason { get; set; }
#nullable restore
#else
        public string FinishReason { get; set; }
#endif
        /// <summary>The index property</summary>
        public int? Index { get; set; }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatCompletionResponseMessage? Message { get; set; }
#nullable restore
#else
        public ChatCompletionResponseMessage Message { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateChatCompletionResponse_choices and sets the default values.
        /// </summary>
        public CreateChatCompletionResponse_choices() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateChatCompletionResponse_choices CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateChatCompletionResponse_choices();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"finish_reason", n => { FinishReason = n.GetStringValue(); } },
                {"index", n => { Index = n.GetIntValue(); } },
                {"message", n => { Message = n.GetObjectValue<ChatCompletionResponseMessage>(ChatCompletionResponseMessage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("finish_reason", FinishReason);
            writer.WriteIntValue("index", Index);
            writer.WriteObjectValue<ChatCompletionResponseMessage>("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

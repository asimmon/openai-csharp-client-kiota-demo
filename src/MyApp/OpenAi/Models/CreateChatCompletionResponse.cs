using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateChatCompletionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The choices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CreateChatCompletionResponse_choices>? Choices { get; set; }
#nullable restore
#else
        public List<CreateChatCompletionResponse_choices> Choices { get; set; }
#endif
        /// <summary>The created property</summary>
        public int? Created { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The object property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Object { get; set; }
#nullable restore
#else
        public string Object { get; set; }
#endif
        /// <summary>The usage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateChatCompletionResponse_usage? Usage { get; set; }
#nullable restore
#else
        public CreateChatCompletionResponse_usage Usage { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateChatCompletionResponse and sets the default values.
        /// </summary>
        public CreateChatCompletionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateChatCompletionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateChatCompletionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"choices", n => { Choices = n.GetCollectionOfObjectValues<CreateChatCompletionResponse_choices>(CreateChatCompletionResponse_choices.CreateFromDiscriminatorValue)?.ToList(); } },
                {"created", n => { Created = n.GetIntValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"object", n => { Object = n.GetStringValue(); } },
                {"usage", n => { Usage = n.GetObjectValue<CreateChatCompletionResponse_usage>(CreateChatCompletionResponse_usage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CreateChatCompletionResponse_choices>("choices", Choices);
            writer.WriteIntValue("created", Created);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("object", Object);
            writer.WriteObjectValue<CreateChatCompletionResponse_usage>("usage", Usage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

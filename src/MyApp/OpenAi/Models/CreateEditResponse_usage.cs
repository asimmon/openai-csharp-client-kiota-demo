using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateEditResponse_usage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The completion_tokens property</summary>
        public int? CompletionTokens { get; set; }
        /// <summary>The prompt_tokens property</summary>
        public int? PromptTokens { get; set; }
        /// <summary>The total_tokens property</summary>
        public int? TotalTokens { get; set; }
        /// <summary>
        /// Instantiates a new CreateEditResponse_usage and sets the default values.
        /// </summary>
        public CreateEditResponse_usage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateEditResponse_usage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateEditResponse_usage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completion_tokens", n => { CompletionTokens = n.GetIntValue(); } },
                {"prompt_tokens", n => { PromptTokens = n.GetIntValue(); } },
                {"total_tokens", n => { TotalTokens = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("completion_tokens", CompletionTokens);
            writer.WriteIntValue("prompt_tokens", PromptTokens);
            writer.WriteIntValue("total_tokens", TotalTokens);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
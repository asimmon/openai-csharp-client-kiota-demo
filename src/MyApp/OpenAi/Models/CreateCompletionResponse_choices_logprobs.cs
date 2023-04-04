using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateCompletionResponse_choices_logprobs : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The text_offset property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? TextOffset { get; set; }
#nullable restore
#else
        public List<int?> TextOffset { get; set; }
#endif
        /// <summary>The token_logprobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<double?>? TokenLogprobs { get; set; }
#nullable restore
#else
        public List<double?> TokenLogprobs { get; set; }
#endif
        /// <summary>The tokens property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tokens { get; set; }
#nullable restore
#else
        public List<string> Tokens { get; set; }
#endif
        /// <summary>The top_logprobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CreateCompletionResponse_choices_logprobs_top_logprobs>? TopLogprobs { get; set; }
#nullable restore
#else
        public List<CreateCompletionResponse_choices_logprobs_top_logprobs> TopLogprobs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateCompletionResponse_choices_logprobs and sets the default values.
        /// </summary>
        public CreateCompletionResponse_choices_logprobs() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateCompletionResponse_choices_logprobs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateCompletionResponse_choices_logprobs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"text_offset", n => { TextOffset = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"token_logprobs", n => { TokenLogprobs = n.GetCollectionOfPrimitiveValues<double?>()?.ToList(); } },
                {"tokens", n => { Tokens = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"top_logprobs", n => { TopLogprobs = n.GetCollectionOfObjectValues<CreateCompletionResponse_choices_logprobs_top_logprobs>(CreateCompletionResponse_choices_logprobs_top_logprobs.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("text_offset", TextOffset);
            writer.WriteCollectionOfPrimitiveValues<double?>("token_logprobs", TokenLogprobs);
            writer.WriteCollectionOfPrimitiveValues<string>("tokens", Tokens);
            writer.WriteCollectionOfObjectValues<CreateCompletionResponse_choices_logprobs_top_logprobs>("top_logprobs", TopLogprobs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateEditRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The input text to use as a starting point for the edit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Input { get; set; }
#nullable restore
#else
        public string Input { get; set; }
#endif
        /// <summary>The instruction that tells the model how to edit the prompt.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Instruction { get; set; }
#nullable restore
#else
        public string Instruction { get; set; }
#endif
        /// <summary>ID of the model to use. You can use the `text-davinci-edit-001` or `code-davinci-edit-001` model with this endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>How many edits to generate for the input and instruction.</summary>
        public int? N { get; set; }
        /// <summary>What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.We generally recommend altering this or `top_p` but not both.</summary>
        public double? Temperature { get; set; }
        /// <summary>An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.We generally recommend altering this or `temperature` but not both.</summary>
        public double? TopP { get; set; }
        /// <summary>
        /// Instantiates a new CreateEditRequest and sets the default values.
        /// </summary>
        public CreateEditRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateEditRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateEditRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"input", n => { Input = n.GetStringValue(); } },
                {"instruction", n => { Instruction = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"n", n => { N = n.GetIntValue(); } },
                {"temperature", n => { Temperature = n.GetDoubleValue(); } },
                {"top_p", n => { TopP = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("input", Input);
            writer.WriteStringValue("instruction", Instruction);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("n", N);
            writer.WriteDoubleValue("temperature", Temperature);
            writer.WriteDoubleValue("top_p", TopP);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

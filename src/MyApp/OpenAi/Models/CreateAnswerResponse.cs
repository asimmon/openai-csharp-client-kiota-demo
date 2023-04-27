using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateAnswerResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The answers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Answers { get; set; }
#nullable restore
#else
        public List<string> Answers { get; set; }
#endif
        /// <summary>The completion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Completion { get; set; }
#nullable restore
#else
        public string Completion { get; set; }
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
        /// <summary>The search_model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SearchModel { get; set; }
#nullable restore
#else
        public string SearchModel { get; set; }
#endif
        /// <summary>The selected_documents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CreateAnswerResponse_selected_documents>? SelectedDocuments { get; set; }
#nullable restore
#else
        public List<CreateAnswerResponse_selected_documents> SelectedDocuments { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateAnswerResponse and sets the default values.
        /// </summary>
        public CreateAnswerResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateAnswerResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateAnswerResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"answers", n => { Answers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"completion", n => { Completion = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"object", n => { Object = n.GetStringValue(); } },
                {"search_model", n => { SearchModel = n.GetStringValue(); } },
                {"selected_documents", n => { SelectedDocuments = n.GetCollectionOfObjectValues<CreateAnswerResponse_selected_documents>(CreateAnswerResponse_selected_documents.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("answers", Answers);
            writer.WriteStringValue("completion", Completion);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("object", Object);
            writer.WriteStringValue("search_model", SearchModel);
            writer.WriteCollectionOfObjectValues<CreateAnswerResponse_selected_documents>("selected_documents", SelectedDocuments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

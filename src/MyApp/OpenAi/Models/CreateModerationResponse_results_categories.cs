using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateModerationResponse_results_categories : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hate property</summary>
        public bool? Hate { get; set; }
        /// <summary>The hateThreatening property</summary>
        public bool? HateThreatening { get; set; }
        /// <summary>The selfHarm property</summary>
        public bool? SelfHarm { get; set; }
        /// <summary>The sexual property</summary>
        public bool? Sexual { get; set; }
        /// <summary>The sexualMinors property</summary>
        public bool? SexualMinors { get; set; }
        /// <summary>The violence property</summary>
        public bool? Violence { get; set; }
        /// <summary>The violenceGraphic property</summary>
        public bool? ViolenceGraphic { get; set; }
        /// <summary>
        /// Instantiates a new CreateModerationResponse_results_categories and sets the default values.
        /// </summary>
        public CreateModerationResponse_results_categories() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateModerationResponse_results_categories CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateModerationResponse_results_categories();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hate", n => { Hate = n.GetBoolValue(); } },
                {"hate/threatening", n => { HateThreatening = n.GetBoolValue(); } },
                {"self-harm", n => { SelfHarm = n.GetBoolValue(); } },
                {"sexual", n => { Sexual = n.GetBoolValue(); } },
                {"sexual/minors", n => { SexualMinors = n.GetBoolValue(); } },
                {"violence", n => { Violence = n.GetBoolValue(); } },
                {"violence/graphic", n => { ViolenceGraphic = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hate", Hate);
            writer.WriteBoolValue("hate/threatening", HateThreatening);
            writer.WriteBoolValue("self-harm", SelfHarm);
            writer.WriteBoolValue("sexual", Sexual);
            writer.WriteBoolValue("sexual/minors", SexualMinors);
            writer.WriteBoolValue("violence", Violence);
            writer.WriteBoolValue("violence/graphic", ViolenceGraphic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

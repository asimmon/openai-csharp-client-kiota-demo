using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateModerationResponse_results_category_scores : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hate property</summary>
        public double? Hate { get; set; }
        /// <summary>The hateThreatening property</summary>
        public double? HateThreatening { get; set; }
        /// <summary>The selfHarm property</summary>
        public double? SelfHarm { get; set; }
        /// <summary>The sexual property</summary>
        public double? Sexual { get; set; }
        /// <summary>The sexualMinors property</summary>
        public double? SexualMinors { get; set; }
        /// <summary>The violence property</summary>
        public double? Violence { get; set; }
        /// <summary>The violenceGraphic property</summary>
        public double? ViolenceGraphic { get; set; }
        /// <summary>
        /// Instantiates a new CreateModerationResponse_results_category_scores and sets the default values.
        /// </summary>
        public CreateModerationResponse_results_category_scores() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateModerationResponse_results_category_scores CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateModerationResponse_results_category_scores();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hate", n => { Hate = n.GetDoubleValue(); } },
                {"hate/threatening", n => { HateThreatening = n.GetDoubleValue(); } },
                {"self-harm", n => { SelfHarm = n.GetDoubleValue(); } },
                {"sexual", n => { Sexual = n.GetDoubleValue(); } },
                {"sexual/minors", n => { SexualMinors = n.GetDoubleValue(); } },
                {"violence", n => { Violence = n.GetDoubleValue(); } },
                {"violence/graphic", n => { ViolenceGraphic = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("hate", Hate);
            writer.WriteDoubleValue("hate/threatening", HateThreatening);
            writer.WriteDoubleValue("self-harm", SelfHarm);
            writer.WriteDoubleValue("sexual", Sexual);
            writer.WriteDoubleValue("sexual/minors", SexualMinors);
            writer.WriteDoubleValue("violence", Violence);
            writer.WriteDoubleValue("violence/graphic", ViolenceGraphic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

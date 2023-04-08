using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateModerationResponse_results : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The categories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateModerationResponse_results_categories? Categories { get; set; }
#nullable restore
#else
        public CreateModerationResponse_results_categories Categories { get; set; }
#endif
        /// <summary>The category_scores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateModerationResponse_results_category_scores? CategoryScores { get; set; }
#nullable restore
#else
        public CreateModerationResponse_results_category_scores CategoryScores { get; set; }
#endif
        /// <summary>The flagged property</summary>
        public bool? Flagged { get; set; }
        /// <summary>
        /// Instantiates a new CreateModerationResponse_results and sets the default values.
        /// </summary>
        public CreateModerationResponse_results() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateModerationResponse_results CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateModerationResponse_results();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"categories", n => { Categories = n.GetObjectValue<CreateModerationResponse_results_categories>(CreateModerationResponse_results_categories.CreateFromDiscriminatorValue); } },
                {"category_scores", n => { CategoryScores = n.GetObjectValue<CreateModerationResponse_results_category_scores>(CreateModerationResponse_results_category_scores.CreateFromDiscriminatorValue); } },
                {"flagged", n => { Flagged = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CreateModerationResponse_results_categories>("categories", Categories);
            writer.WriteObjectValue<CreateModerationResponse_results_category_scores>("category_scores", CategoryScores);
            writer.WriteBoolValue("flagged", Flagged);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

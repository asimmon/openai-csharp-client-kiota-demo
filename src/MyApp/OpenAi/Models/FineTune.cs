using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class FineTune : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public int? CreatedAt { get; set; }
        /// <summary>The events property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FineTuneEvent>? Events { get; set; }
#nullable restore
#else
        public List<FineTuneEvent> Events { get; set; }
#endif
        /// <summary>The fine_tuned_model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FineTunedModel { get; set; }
#nullable restore
#else
        public string FineTunedModel { get; set; }
#endif
        /// <summary>The hyperparams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FineTune_hyperparams? Hyperparams { get; set; }
#nullable restore
#else
        public FineTune_hyperparams Hyperparams { get; set; }
#endif
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
        /// <summary>The organization_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>The result_files property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OpenAIFile>? ResultFiles { get; set; }
#nullable restore
#else
        public List<OpenAIFile> ResultFiles { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The training_files property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OpenAIFile>? TrainingFiles { get; set; }
#nullable restore
#else
        public List<OpenAIFile> TrainingFiles { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public int? UpdatedAt { get; set; }
        /// <summary>The validation_files property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OpenAIFile>? ValidationFiles { get; set; }
#nullable restore
#else
        public List<OpenAIFile> ValidationFiles { get; set; }
#endif
        /// <summary>
        /// Instantiates a new FineTune and sets the default values.
        /// </summary>
        public FineTune() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FineTune CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FineTune();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"created_at", n => { CreatedAt = n.GetIntValue(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<FineTuneEvent>(FineTuneEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fine_tuned_model", n => { FineTunedModel = n.GetStringValue(); } },
                {"hyperparams", n => { Hyperparams = n.GetObjectValue<FineTune_hyperparams>(FineTune_hyperparams.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"object", n => { Object = n.GetStringValue(); } },
                {"organization_id", n => { OrganizationId = n.GetStringValue(); } },
                {"result_files", n => { ResultFiles = n.GetCollectionOfObjectValues<OpenAIFile>(OpenAIFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"training_files", n => { TrainingFiles = n.GetCollectionOfObjectValues<OpenAIFile>(OpenAIFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updated_at", n => { UpdatedAt = n.GetIntValue(); } },
                {"validation_files", n => { ValidationFiles = n.GetCollectionOfObjectValues<OpenAIFile>(OpenAIFile.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("created_at", CreatedAt);
            writer.WriteCollectionOfObjectValues<FineTuneEvent>("events", Events);
            writer.WriteStringValue("fine_tuned_model", FineTunedModel);
            writer.WriteObjectValue<FineTune_hyperparams>("hyperparams", Hyperparams);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("object", Object);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteCollectionOfObjectValues<OpenAIFile>("result_files", ResultFiles);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfObjectValues<OpenAIFile>("training_files", TrainingFiles);
            writer.WriteIntValue("updated_at", UpdatedAt);
            writer.WriteCollectionOfObjectValues<OpenAIFile>("validation_files", ValidationFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

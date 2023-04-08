using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class OpenAIFile : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bytes property</summary>
        public int? Bytes { get; set; }
        /// <summary>The created_at property</summary>
        public int? CreatedAt { get; set; }
        /// <summary>The filename property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filename { get; set; }
#nullable restore
#else
        public string Filename { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The object property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Object { get; set; }
#nullable restore
#else
        public string Object { get; set; }
#endif
        /// <summary>The purpose property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Purpose { get; set; }
#nullable restore
#else
        public string Purpose { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The status_details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OpenAIFile_status_details? StatusDetails { get; set; }
#nullable restore
#else
        public OpenAIFile_status_details StatusDetails { get; set; }
#endif
        /// <summary>
        /// Instantiates a new OpenAIFile and sets the default values.
        /// </summary>
        public OpenAIFile() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OpenAIFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OpenAIFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bytes", n => { Bytes = n.GetIntValue(); } },
                {"created_at", n => { CreatedAt = n.GetIntValue(); } },
                {"filename", n => { Filename = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"object", n => { Object = n.GetStringValue(); } },
                {"purpose", n => { Purpose = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"status_details", n => { StatusDetails = n.GetObjectValue<OpenAIFile_status_details>(OpenAIFile_status_details.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bytes", Bytes);
            writer.WriteIntValue("created_at", CreatedAt);
            writer.WriteStringValue("filename", Filename);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("object", Object);
            writer.WriteStringValue("purpose", Purpose);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<OpenAIFile_status_details>("status_details", StatusDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

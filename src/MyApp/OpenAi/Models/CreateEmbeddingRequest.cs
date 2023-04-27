using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateEmbeddingRequest : IParsable {
        /// <summary>Input text to get embeddings for, encoded as a string or array of tokens. To get embeddings for multiple inputs in a single request, pass an array of strings or array of token arrays. Each input must not exceed 8192 tokens in length.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Embeddings? Input { get; set; }
#nullable restore
#else
        public Embeddings Input { get; set; }
#endif
        /// <summary>ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateEmbeddingRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateEmbeddingRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"input", n => { Input = n.GetObjectValue<Embeddings>(Embeddings.CreateFromDiscriminatorValue); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Embeddings>("input", Input);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("user", User);
        }
        /// <summary>
        /// Composed type wrapper for classes string, string, integer, embeddingsMember1
        /// </summary>
        public class Embeddings : IAdditionalDataHolder, IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Composed type representation for type embeddingsMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public MyApp.OpenAi.Models.EmbeddingsMember1? EmbeddingsMember1 { get; set; }
#nullable restore
#else
            public MyApp.OpenAi.Models.EmbeddingsMember1 EmbeddingsMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type integer</summary>
            public int? Integer { get; set; }
            /// <summary>Serialization hint for the current wrapper.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? SerializationHint { get; set; }
#nullable restore
#else
            public string SerializationHint { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Instantiates a new embeddings and sets the default values.
            /// </summary>
            public Embeddings() {
                AdditionalData = new Dictionary<string, object>();
            }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static Embeddings CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new Embeddings();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.EmbeddingsMember1 = new MyApp.OpenAi.Models.EmbeddingsMember1();
                }
                else if(parseNode.GetIntValue() is int integerValue) {
                    result.Integer = integerValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(EmbeddingsMember1 != null) {
                    return EmbeddingsMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(EmbeddingsMember1 != null) {
                    writer.WriteObjectValue<MyApp.OpenAi.Models.EmbeddingsMember1>(null, EmbeddingsMember1);
                }
                else if(Integer != null) {
                    writer.WriteIntValue(null, Integer);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}

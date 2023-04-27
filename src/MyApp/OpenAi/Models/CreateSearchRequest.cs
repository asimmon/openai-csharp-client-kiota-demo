using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateSearchRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Up to 200 documents to search over, provided as a list of strings.The maximum document length (in tokens) is 2034 minus the number of tokens in the query.You should specify either `documents` or a `file`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Documents { get; set; }
#nullable restore
#else
        public List<string> Documents { get; set; }
#endif
        /// <summary>The ID of an uploaded file that contains documents to search over.You should specify either `documents` or a `file`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? File { get; set; }
#nullable restore
#else
        public string File { get; set; }
#endif
        /// <summary>The maximum number of documents to be re-ranked and returned by search.This flag only takes effect when `file` is set.</summary>
        public int? MaxRerank { get; set; }
        /// <summary>Query to search against the documents.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Query { get; set; }
#nullable restore
#else
        public string Query { get; set; }
#endif
        /// <summary>A special boolean flag for showing metadata. If set to `true`, each document entry in the returned JSON will contain a &quot;metadata&quot; field.This flag only takes effect when `file` is set.</summary>
        public bool? ReturnMetadata { get; set; }
        /// <summary>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateSearchRequest and sets the default values.
        /// </summary>
        public CreateSearchRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateSearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateSearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"documents", n => { Documents = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"file", n => { File = n.GetStringValue(); } },
                {"max_rerank", n => { MaxRerank = n.GetIntValue(); } },
                {"query", n => { Query = n.GetStringValue(); } },
                {"return_metadata", n => { ReturnMetadata = n.GetBoolValue(); } },
                {"user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("documents", Documents);
            writer.WriteStringValue("file", File);
            writer.WriteIntValue("max_rerank", MaxRerank);
            writer.WriteStringValue("query", Query);
            writer.WriteBoolValue("return_metadata", ReturnMetadata);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

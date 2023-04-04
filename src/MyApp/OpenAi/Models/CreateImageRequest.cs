using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateImageRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of images to generate. Must be between 1 and 10.</summary>
        public int? N { get; set; }
        /// <summary>A text description of the desired image(s). The maximum length is 1000 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Prompt { get; set; }
#nullable restore
#else
        public string Prompt { get; set; }
#endif
        /// <summary>The format in which the generated images are returned. Must be one of `url` or `b64_json`.</summary>
        public CreateImageRequest_response_format? ResponseFormat { get; set; }
        /// <summary>The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.</summary>
        public CreateImageRequest_size? Size { get; set; }
        /// <summary>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateImageRequest and sets the default values.
        /// </summary>
        public CreateImageRequest() {
            AdditionalData = new Dictionary<string, object>();
            ResponseFormat = CreateImageRequest_response_format.Url;
            Size = CreateImageRequest_size.OneZeroTwoFourx1024;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateImageRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateImageRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"n", n => { N = n.GetIntValue(); } },
                {"prompt", n => { Prompt = n.GetStringValue(); } },
                {"response_format", n => { ResponseFormat = n.GetEnumValue<CreateImageRequest_response_format>(); } },
                {"size", n => { Size = n.GetEnumValue<CreateImageRequest_size>(); } },
                {"user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("n", N);
            writer.WriteStringValue("prompt", Prompt);
            writer.WriteEnumValue<CreateImageRequest_response_format>("response_format", ResponseFormat);
            writer.WriteEnumValue<CreateImageRequest_size>("size", Size);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

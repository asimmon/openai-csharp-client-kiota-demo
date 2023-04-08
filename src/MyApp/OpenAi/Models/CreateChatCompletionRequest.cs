using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace MyApp.OpenAi.Models {
    public class CreateChatCompletionRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&apos;s likelihood to repeat the same line verbatim.[See more information about frequency and presence penalties.](/docs/api-reference/parameter-details)</summary>
        public double? FrequencyPenalty { get; set; }
        /// <summary>Modify the likelihood of specified tokens appearing in the completion.Accepts a json object that maps tokens (specified by their token ID in the tokenizer) to an associated bias value from -100 to 100. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateChatCompletionRequest_logit_bias? LogitBias { get; set; }
#nullable restore
#else
        public CreateChatCompletionRequest_logit_bias LogitBias { get; set; }
#endif
        /// <summary>The maximum number of tokens allowed for the generated answer. By default, the number of tokens the model can return will be (4096 - prompt tokens).</summary>
        public int? MaxTokens { get; set; }
        /// <summary>The messages to generate chat completions for, in the [chat format](/docs/guides/chat/introduction).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatCompletionRequestMessage>? Messages { get; set; }
#nullable restore
#else
        public List<ChatCompletionRequestMessage> Messages { get; set; }
#endif
        /// <summary>ID of the model to use. Currently, only `gpt-3.5-turbo` and `gpt-3.5-turbo-0301` are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>How many chat completion choices to generate for each input message.</summary>
        public int? N { get; set; }
        /// <summary>Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&apos;s likelihood to talk about new topics.[See more information about frequency and presence penalties.](/docs/api-reference/parameter-details)</summary>
        public double? PresencePenalty { get; set; }
        /// <summary>Up to 4 sequences where the API will stop generating further tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Stop { get; set; }
#nullable restore
#else
        public List<string> Stop { get; set; }
#endif
        /// <summary>If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message.</summary>
        public bool? Stream { get; set; }
        /// <summary>What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.We generally recommend altering this or `top_p` but not both.</summary>
        public double? Temperature { get; set; }
        /// <summary>An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.We generally recommend altering this or `temperature` but not both.</summary>
        public double? TopP { get; set; }
        /// <summary>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateChatCompletionRequest and sets the default values.
        /// </summary>
        public CreateChatCompletionRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateChatCompletionRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateChatCompletionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"frequency_penalty", n => { FrequencyPenalty = n.GetDoubleValue(); } },
                {"logit_bias", n => { LogitBias = n.GetObjectValue<CreateChatCompletionRequest_logit_bias>(CreateChatCompletionRequest_logit_bias.CreateFromDiscriminatorValue); } },
                {"max_tokens", n => { MaxTokens = n.GetIntValue(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<ChatCompletionRequestMessage>(ChatCompletionRequestMessage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"n", n => { N = n.GetIntValue(); } },
                {"presence_penalty", n => { PresencePenalty = n.GetDoubleValue(); } },
                {"stop", n => { Stop = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"stream", n => { Stream = n.GetBoolValue(); } },
                {"temperature", n => { Temperature = n.GetDoubleValue(); } },
                {"top_p", n => { TopP = n.GetDoubleValue(); } },
                {"user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("frequency_penalty", FrequencyPenalty);
            writer.WriteObjectValue<CreateChatCompletionRequest_logit_bias>("logit_bias", LogitBias);
            writer.WriteIntValue("max_tokens", MaxTokens);
            writer.WriteCollectionOfObjectValues<ChatCompletionRequestMessage>("messages", Messages);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("n", N);
            writer.WriteDoubleValue("presence_penalty", PresencePenalty);
            writer.WriteCollectionOfPrimitiveValues<string>("stop", Stop);
            writer.WriteBoolValue("stream", Stream);
            writer.WriteDoubleValue("temperature", Temperature);
            writer.WriteDoubleValue("top_p", TopP);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

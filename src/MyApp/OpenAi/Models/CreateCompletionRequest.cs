using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateCompletionRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Generates `best_of` completions server-side and returns the &quot;best&quot; (the one with the highest log probability per token). Results cannot be streamed.When used with `n`, `best_of` controls the number of candidate completions and `n` specifies how many to return – `best_of` must be greater than `n`.**Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.</summary>
        public int? BestOf { get; set; }
        /// <summary>Echo back the prompt in addition to the completion</summary>
        public bool? Echo { get; set; }
        /// <summary>Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&apos;s likelihood to repeat the same line verbatim.[See more information about frequency and presence penalties.](/docs/api-reference/parameter-details)</summary>
        public double? FrequencyPenalty { get; set; }
        /// <summary>Modify the likelihood of specified tokens appearing in the completion.Accepts a json object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this [tokenizer tool](/tokenizer?view=bpe) (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.As an example, you can pass `{&quot;50256&quot;: -100}` to prevent the &lt;|endoftext|&gt; token from being generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateCompletionRequest_logit_bias? LogitBias { get; set; }
#nullable restore
#else
        public CreateCompletionRequest_logit_bias LogitBias { get; set; }
#endif
        /// <summary>Include the log probabilities on the `logprobs` most likely tokens, as well the chosen tokens. For example, if `logprobs` is 5, the API will return a list of the 5 most likely tokens. The API will always return the `logprob` of the sampled token, so there may be up to `logprobs+1` elements in the response.The maximum value for `logprobs` is 5. If you need more than this, please contact us through our [Help center](https://help.openai.com) and describe your use case.</summary>
        public int? Logprobs { get; set; }
        /// <summary>The maximum number of [tokens](/tokenizer) to generate in the completion.The token count of your prompt plus `max_tokens` cannot exceed the model&apos;s context length. Most models have a context length of 2048 tokens (except for the newest models, which support 4096).</summary>
        public int? MaxTokens { get; set; }
        /// <summary>ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>How many completions to generate for each prompt.**Note:** Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.</summary>
        public int? N { get; set; }
        /// <summary>Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&apos;s likelihood to talk about new topics.[See more information about frequency and presence penalties.](/docs/api-reference/parameter-details)</summary>
        public double? PresencePenalty { get; set; }
        /// <summary>The prompt(s) to generate completions for, encoded as a string, array of strings, array of tokens, or array of token arrays.Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a prompt is not specified the model will generate as if from the beginning of a new document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Prompt { get; set; }
#nullable restore
#else
        public List<string> Prompt { get; set; }
#endif
        /// <summary>Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Stop { get; set; }
#nullable restore
#else
        public List<string> Stop { get; set; }
#endif
        /// <summary>Whether to stream back partial progress. If set, tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message.</summary>
        public bool? Stream { get; set; }
        /// <summary>The suffix that comes after a completion of inserted text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Suffix { get; set; }
#nullable restore
#else
        public string Suffix { get; set; }
#endif
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
        /// Instantiates a new CreateCompletionRequest and sets the default values.
        /// </summary>
        public CreateCompletionRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateCompletionRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateCompletionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"best_of", n => { BestOf = n.GetIntValue(); } },
                {"echo", n => { Echo = n.GetBoolValue(); } },
                {"frequency_penalty", n => { FrequencyPenalty = n.GetDoubleValue(); } },
                {"logit_bias", n => { LogitBias = n.GetObjectValue<CreateCompletionRequest_logit_bias>(CreateCompletionRequest_logit_bias.CreateFromDiscriminatorValue); } },
                {"logprobs", n => { Logprobs = n.GetIntValue(); } },
                {"max_tokens", n => { MaxTokens = n.GetIntValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"n", n => { N = n.GetIntValue(); } },
                {"presence_penalty", n => { PresencePenalty = n.GetDoubleValue(); } },
                {"prompt", n => { Prompt = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"stop", n => { Stop = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"stream", n => { Stream = n.GetBoolValue(); } },
                {"suffix", n => { Suffix = n.GetStringValue(); } },
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
            writer.WriteIntValue("best_of", BestOf);
            writer.WriteBoolValue("echo", Echo);
            writer.WriteDoubleValue("frequency_penalty", FrequencyPenalty);
            writer.WriteObjectValue<CreateCompletionRequest_logit_bias>("logit_bias", LogitBias);
            writer.WriteIntValue("logprobs", Logprobs);
            writer.WriteIntValue("max_tokens", MaxTokens);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("n", N);
            writer.WriteDoubleValue("presence_penalty", PresencePenalty);
            writer.WriteCollectionOfPrimitiveValues<string>("prompt", Prompt);
            writer.WriteCollectionOfPrimitiveValues<string>("stop", Stop);
            writer.WriteBoolValue("stream", Stream);
            writer.WriteStringValue("suffix", Suffix);
            writer.WriteDoubleValue("temperature", Temperature);
            writer.WriteDoubleValue("top_p", TopP);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
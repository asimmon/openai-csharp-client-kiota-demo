using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MyApp.OpenAi.Models {
    public class CreateFineTuneRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The batch size to use for training. The batch size is the number oftraining examples used to train a single forward and backward pass.By default, the batch size will be dynamically configured to be~0.2% of the number of examples in the training set, capped at 256 -in general, we&apos;ve found that larger batch sizes tend to work betterfor larger datasets.</summary>
        public int? BatchSize { get; set; }
        /// <summary>If this is provided, we calculate F-beta scores at the specifiedbeta values. The F-beta score is a generalization of F-1 score.This is only used for binary classification.With a beta of 1 (i.e. the F-1 score), precision and recall aregiven the same weight. A larger beta score puts more weight onrecall and less on precision. A smaller beta score puts more weighton precision and less on recall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<double?>? ClassificationBetas { get; set; }
#nullable restore
#else
        public List<double?> ClassificationBetas { get; set; }
#endif
        /// <summary>The number of classes in a classification task.This parameter is required for multiclass classification.</summary>
        public int? ClassificationNClasses { get; set; }
        /// <summary>The positive class in binary classification.This parameter is needed to generate precision, recall, and F1metrics when doing binary classification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassificationPositiveClass { get; set; }
#nullable restore
#else
        public string ClassificationPositiveClass { get; set; }
#endif
        /// <summary>If set, we calculate classification-specific metrics such as accuracyand F-1 score using the validation set at the end of every epoch.These metrics can be viewed in the [results file](/docs/guides/fine-tuning/analyzing-your-fine-tuned-model).In order to compute classification metrics, you must provide a`validation_file`. Additionally, you mustspecify `classification_n_classes` for multiclass classification or`classification_positive_class` for binary classification.</summary>
        public bool? ComputeClassificationMetrics { get; set; }
        /// <summary>The learning rate multiplier to use for training.The fine-tuning learning rate is the original learning rate used forpretraining multiplied by this value.By default, the learning rate multiplier is the 0.05, 0.1, or 0.2depending on final `batch_size` (larger learning rates tend toperform better with larger batch sizes). We recommend experimentingwith values in the range 0.02 to 0.2 to see what produces the bestresults.</summary>
        public double? LearningRateMultiplier { get; set; }
        /// <summary>The name of the base model to fine-tune. You can select one of &quot;ada&quot;,&quot;babbage&quot;, &quot;curie&quot;, &quot;davinci&quot;, or a fine-tuned model created after 2022-04-21.To learn more about these models, see the[Models](https://platform.openai.com/docs/models) documentation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The number of epochs to train the model for. An epoch refers to onefull cycle through the training dataset.</summary>
        public int? NEpochs { get; set; }
        /// <summary>The weight to use for loss on the prompt tokens. This controls howmuch the model tries to learn to generate the prompt (as comparedto the completion which always has a weight of 1.0), and can adda stabilizing effect to training when completions are short.If prompts are extremely long (relative to completions), it may makesense to reduce this weight so as to avoid over-prioritizinglearning the prompt.</summary>
        public double? PromptLossWeight { get; set; }
        /// <summary>A string of up to 40 characters that will be added to your fine-tuned model name.For example, a `suffix` of &quot;custom-model-name&quot; would produce a model name like `ada:ft-your-org:custom-model-name-2022-02-15-04-21-04`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Suffix { get; set; }
#nullable restore
#else
        public string Suffix { get; set; }
#endif
        /// <summary>The ID of an uploaded file that contains training data.See [upload file](/docs/api-reference/files/upload) for how to upload a file.Your dataset must be formatted as a JSONL file, where each trainingexample is a JSON object with the keys &quot;prompt&quot; and &quot;completion&quot;.Additionally, you must upload your file with the purpose `fine-tune`.See the [fine-tuning guide](/docs/guides/fine-tuning/creating-training-data) for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrainingFile { get; set; }
#nullable restore
#else
        public string TrainingFile { get; set; }
#endif
        /// <summary>The ID of an uploaded file that contains validation data.If you provide this file, the data is used to generate validationmetrics periodically during fine-tuning. These metrics can be viewed inthe [fine-tuning results file](/docs/guides/fine-tuning/analyzing-your-fine-tuned-model).Your train and validation data should be mutually exclusive.Your dataset must be formatted as a JSONL file, where each validationexample is a JSON object with the keys &quot;prompt&quot; and &quot;completion&quot;.Additionally, you must upload your file with the purpose `fine-tune`.See the [fine-tuning guide](/docs/guides/fine-tuning/creating-training-data) for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValidationFile { get; set; }
#nullable restore
#else
        public string ValidationFile { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CreateFineTuneRequest and sets the default values.
        /// </summary>
        public CreateFineTuneRequest() {
            AdditionalData = new Dictionary<string, object>();
            Model = "curie";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateFineTuneRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateFineTuneRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"batch_size", n => { BatchSize = n.GetIntValue(); } },
                {"classification_betas", n => { ClassificationBetas = n.GetCollectionOfPrimitiveValues<double?>()?.ToList(); } },
                {"classification_n_classes", n => { ClassificationNClasses = n.GetIntValue(); } },
                {"classification_positive_class", n => { ClassificationPositiveClass = n.GetStringValue(); } },
                {"compute_classification_metrics", n => { ComputeClassificationMetrics = n.GetBoolValue(); } },
                {"learning_rate_multiplier", n => { LearningRateMultiplier = n.GetDoubleValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"n_epochs", n => { NEpochs = n.GetIntValue(); } },
                {"prompt_loss_weight", n => { PromptLossWeight = n.GetDoubleValue(); } },
                {"suffix", n => { Suffix = n.GetStringValue(); } },
                {"training_file", n => { TrainingFile = n.GetStringValue(); } },
                {"validation_file", n => { ValidationFile = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("batch_size", BatchSize);
            writer.WriteCollectionOfPrimitiveValues<double?>("classification_betas", ClassificationBetas);
            writer.WriteIntValue("classification_n_classes", ClassificationNClasses);
            writer.WriteStringValue("classification_positive_class", ClassificationPositiveClass);
            writer.WriteBoolValue("compute_classification_metrics", ComputeClassificationMetrics);
            writer.WriteDoubleValue("learning_rate_multiplier", LearningRateMultiplier);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("n_epochs", NEpochs);
            writer.WriteDoubleValue("prompt_loss_weight", PromptLossWeight);
            writer.WriteStringValue("suffix", Suffix);
            writer.WriteStringValue("training_file", TrainingFile);
            writer.WriteStringValue("validation_file", ValidationFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using MyApp.OpenAi.Audio;
using MyApp.OpenAi.Chat;
using MyApp.OpenAi.Completions;
using MyApp.OpenAi.Edits;
using MyApp.OpenAi.Embeddings;
using MyApp.OpenAi.Files;
using MyApp.OpenAi.FineTunes;
using MyApp.OpenAi.Images;
using MyApp.OpenAi.Models;
using MyApp.OpenAi.Moderations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MyApp.OpenAi {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class OpenAiClient {
        /// <summary>The audio property</summary>
        public AudioRequestBuilder Audio { get =>
            new AudioRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chat property</summary>
        public ChatRequestBuilder Chat { get =>
            new ChatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The completions property</summary>
        public CompletionsRequestBuilder Completions { get =>
            new CompletionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The edits property</summary>
        public EditsRequestBuilder Edits { get =>
            new EditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The embeddings property</summary>
        public EmbeddingsRequestBuilder Embeddings { get =>
            new EmbeddingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The files property</summary>
        public FilesRequestBuilder Files { get =>
            new FilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fineTunes property</summary>
        public FineTunesRequestBuilder FineTunes { get =>
            new FineTunesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The images property</summary>
        public ImagesRequestBuilder Images { get =>
            new ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The models property</summary>
        public ModelsRequestBuilder Models { get =>
            new ModelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The moderations property</summary>
        public ModerationsRequestBuilder Moderations { get =>
            new ModerationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new OpenAiClient and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OpenAiClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://api.openai.com/v1";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}

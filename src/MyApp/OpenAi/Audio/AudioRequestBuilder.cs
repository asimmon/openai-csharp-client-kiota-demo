using Microsoft.Kiota.Abstractions;
using MyApp.OpenAi.Audio.Transcriptions;
using MyApp.OpenAi.Audio.Translations;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace MyApp.OpenAi.Audio {
    /// <summary>
    /// Builds and executes requests for operations under \audio
    /// </summary>
    public class AudioRequestBuilder : BaseRequestBuilder {
        /// <summary>The transcriptions property</summary>
        public TranscriptionsRequestBuilder Transcriptions { get =>
            new TranscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The translations property</summary>
        public TranslationsRequestBuilder Translations { get =>
            new TranslationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AudioRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudioRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/audio", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AudioRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudioRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/audio", rawUrl) {
        }
    }
}

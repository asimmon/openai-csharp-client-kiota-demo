using Microsoft.Kiota.Abstractions;
using MyApp.OpenAi.Images.Edits;
using MyApp.OpenAi.Images.Generations;
using MyApp.OpenAi.Images.Variations;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace MyApp.OpenAi.Images {
    /// <summary>
    /// Builds and executes requests for operations under \images
    /// </summary>
    public class ImagesRequestBuilder : BaseRequestBuilder {
        /// <summary>The edits property</summary>
        public EditsRequestBuilder Edits { get =>
            new EditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generations property</summary>
        public GenerationsRequestBuilder Generations { get =>
            new GenerationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The variations property</summary>
        public VariationsRequestBuilder Variations { get =>
            new VariationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ImagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/images", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ImagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/images", rawUrl) {
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using MyApp.OpenAi.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace MyApp.OpenAi.Classifications {
    /// <summary>
    /// Builds and executes requests for operations under \classifications
    /// </summary>
    public class ClassificationsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ClassificationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClassificationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/classifications", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ClassificationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClassificationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/classifications", rawUrl) {
        }
        /// <summary>
        /// Classifies the specified `query` using provided examples.The endpoint first [searches](/docs/api-reference/searches) over the labeled examplesto select the ones most relevant for the particular query. Then, the relevant examplesare combined with the query to construct a prompt to produce the final label via the[completions](/docs/api-reference/completions) endpoint.Labeled examples can be provided via an uploaded `file`, or explicitly listed in therequest using the `examples` parameter for quick tests and small scale use cases.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CreateClassificationResponse?> PostAsync(CreateClassificationRequest body, Action<ClassificationsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CreateClassificationResponse> PostAsync(CreateClassificationRequest body, Action<ClassificationsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<CreateClassificationResponse>(requestInfo, CreateClassificationResponse.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Classifies the specified `query` using provided examples.The endpoint first [searches](/docs/api-reference/searches) over the labeled examplesto select the ones most relevant for the particular query. Then, the relevant examplesare combined with the query to construct a prompt to produce the final label via the[completions](/docs/api-reference/completions) endpoint.Labeled examples can be provided via an uploaded `file`, or explicitly listed in therequest using the `examples` parameter for quick tests and small scale use cases.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateClassificationRequest body, Action<ClassificationsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateClassificationRequest body, Action<ClassificationsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ClassificationsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ClassificationsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new classificationsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ClassificationsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

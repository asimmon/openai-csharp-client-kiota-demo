using System.Runtime.Serialization;
using System;
namespace MyApp.OpenAi.Models {
    /// <summary>The format in which the generated images are returned. Must be one of `url` or `b64_json`.</summary>
    public enum CreateImageRequest_response_format {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "b64_json")]
        B64_json,
    }
}

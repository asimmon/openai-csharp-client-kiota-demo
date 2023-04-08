using System.Runtime.Serialization;
using System;
namespace MyApp.OpenAi.Models {
    /// <summary>The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.</summary>
    public enum CreateImageRequest_size {
        [EnumMember(Value = "256x256")]
        TwoFiveSixx256,
        [EnumMember(Value = "512x512")]
        FiveOneTwox512,
        [EnumMember(Value = "1024x1024")]
        OneZeroTwoFourx1024,
    }
}

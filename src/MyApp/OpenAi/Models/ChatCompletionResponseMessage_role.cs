using System.Runtime.Serialization;
using System;
namespace MyApp.OpenAi.Models {
    /// <summary>The role of the author of this message.</summary>
    public enum ChatCompletionResponseMessage_role {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant,
    }
}

// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible values for applicationGuardBlockFileTransfer</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ApplicationGuardBlockFileTransferType
    {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Block clipboard to transfer Image and Text file</summary>
        [EnumMember(Value = "blockImageAndTextFile")]
        BlockImageAndTextFile,
        /// <summary>Block clipboard to transfer Image file</summary>
        [EnumMember(Value = "blockImageFile")]
        BlockImageFile,
        /// <summary>Neither of text file or image file is blocked from transferring</summary>
        [EnumMember(Value = "blockNone")]
        BlockNone,
        /// <summary>Block clipboard to transfer Text file</summary>
        [EnumMember(Value = "blockTextFile")]
        BlockTextFile,
    }
}

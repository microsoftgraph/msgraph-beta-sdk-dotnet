using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum ExportOptions {
        [EnumMember(Value = "originalFiles")]
        OriginalFiles,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "pdfReplacement")]
        PdfReplacement,
        [EnumMember(Value = "fileInfo")]
        FileInfo,
        [EnumMember(Value = "tags")]
        Tags,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}

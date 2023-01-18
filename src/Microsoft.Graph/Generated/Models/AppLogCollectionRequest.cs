using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// AppLogCollectionRequest Entity.
    /// </summary>
    public class AppLogCollectionRequest : Entity, IParsable {
        /// <summary>Time at which the upload log request reached a terminal state</summary>
        public DateTimeOffset? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>List of log folders.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? CustomLogFolders {
            get { return BackingStore?.Get<List<string>?>("customLogFolders"); }
            set { BackingStore?.Set("customLogFolders", value); }
        }
#else
        public List<string> CustomLogFolders {
            get { return BackingStore?.Get<List<string>>("customLogFolders"); }
            set { BackingStore?.Set("customLogFolders", value); }
        }
#endif
        /// <summary>Error message if any during the upload process</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ErrorMessage {
            get { return BackingStore?.Get<string?>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#else
        public string ErrorMessage {
            get { return BackingStore?.Get<string>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#endif
        /// <summary>AppLogUploadStatus</summary>
        public AppLogUploadState? Status {
            get { return BackingStore?.Get<AppLogUploadState?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppLogCollectionRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppLogCollectionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customLogFolders", n => { CustomLogFolders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AppLogUploadState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("customLogFolders", CustomLogFolders);
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteEnumValue<AppLogUploadState>("status", Status);
        }
    }
}

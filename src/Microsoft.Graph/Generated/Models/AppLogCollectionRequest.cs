using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppLogCollectionRequest : Entity, IParsable {
        /// <summary>Time at which the upload log request reached a terminal state</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>List of log folders.</summary>
        public List<string> CustomLogFolders { get; set; }
        /// <summary>Error message if any during the upload process</summary>
        public string ErrorMessage { get; set; }
        /// <summary>Log upload status. Possible values are: pending, completed, failed.</summary>
        public AppLogUploadState? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"customLogFolders", n => { CustomLogFolders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AppLogUploadState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

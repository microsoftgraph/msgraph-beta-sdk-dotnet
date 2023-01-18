using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CustomExtensionCalloutResult : AuthenticationEventHandlerResult, IParsable {
        /// <summary>The calloutDateTime property</summary>
        public DateTimeOffset? CalloutDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("calloutDateTime"); }
            set { BackingStore?.Set("calloutDateTime", value); }
        }
        /// <summary>The customExtensionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? CustomExtensionId {
            get { return BackingStore?.Get<string?>("customExtensionId"); }
            set { BackingStore?.Set("customExtensionId", value); }
        }
#else
        public string CustomExtensionId {
            get { return BackingStore?.Get<string>("customExtensionId"); }
            set { BackingStore?.Set("customExtensionId", value); }
        }
#endif
        /// <summary>The errorCode property</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The httpStatus property</summary>
        public int? HttpStatus {
            get { return BackingStore?.Get<int?>("httpStatus"); }
            set { BackingStore?.Set("httpStatus", value); }
        }
        /// <summary>The numberOfAttempts property</summary>
        public int? NumberOfAttempts {
            get { return BackingStore?.Get<int?>("numberOfAttempts"); }
            set { BackingStore?.Set("numberOfAttempts", value); }
        }
        /// <summary>
        /// Instantiates a new CustomExtensionCalloutResult and sets the default values.
        /// </summary>
        public CustomExtensionCalloutResult() : base() {
            OdataType = "#microsoft.graph.customExtensionCalloutResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomExtensionCalloutResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionCalloutResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"calloutDateTime", n => { CalloutDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionId", n => { CustomExtensionId = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"httpStatus", n => { HttpStatus = n.GetIntValue(); } },
                {"numberOfAttempts", n => { NumberOfAttempts = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("calloutDateTime", CalloutDateTime);
            writer.WriteStringValue("customExtensionId", CustomExtensionId);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteIntValue("httpStatus", HttpStatus);
            writer.WriteIntValue("numberOfAttempts", NumberOfAttempts);
        }
    }
}

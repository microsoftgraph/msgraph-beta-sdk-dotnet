using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnTokenIssuanceStartCustomExtensionHandler : OnTokenIssuanceStartHandler, IParsable {
        /// <summary>The customExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnTokenIssuanceStartCustomExtension? CustomExtension {
            get { return BackingStore?.Get<OnTokenIssuanceStartCustomExtension?>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#nullable restore
#else
        public OnTokenIssuanceStartCustomExtension CustomExtension {
            get { return BackingStore?.Get<OnTokenIssuanceStartCustomExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new OnTokenIssuanceStartCustomExtensionHandler and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartCustomExtensionHandler() : base() {
            OdataType = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnTokenIssuanceStartCustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnTokenIssuanceStartCustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customExtension", n => { CustomExtension = n.GetObjectValue<OnTokenIssuanceStartCustomExtension>(OnTokenIssuanceStartCustomExtension.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnTokenIssuanceStartCustomExtension>("customExtension", CustomExtension);
        }
    }
}

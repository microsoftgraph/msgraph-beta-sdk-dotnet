using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnTokenIssuanceStartCustomExtensionHandler : OnTokenIssuanceStartHandler, IParsable {
        /// <summary>The customExtension property</summary>
        public OnTokenIssuanceStartCustomExtension CustomExtension {
            get { return BackingStore?.Get<OnTokenIssuanceStartCustomExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
        /// <summary>
        /// Instantiates a new OnTokenIssuanceStartCustomExtensionHandler and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartCustomExtensionHandler() : base() {
            OdataType = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnTokenIssuanceStartCustomExtension>("customExtension", CustomExtension);
        }
    }
}

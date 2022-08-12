using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnTokenIssuanceStartListener : AuthenticationEventListener, IParsable {
        /// <summary>The handler property</summary>
        public OnTokenIssuanceStartHandler Handler {
            get { return BackingStore?.Get<OnTokenIssuanceStartHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
        /// <summary>
        /// Instantiates a new OnTokenIssuanceStartListener and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartListener() : base() {
            OdataType = "#microsoft.graph.onTokenIssuanceStartListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnTokenIssuanceStartListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnTokenIssuanceStartListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"handler", n => { Handler = n.GetObjectValue<OnTokenIssuanceStartHandler>(OnTokenIssuanceStartHandler.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnTokenIssuanceStartHandler>("handler", Handler);
        }
    }
}

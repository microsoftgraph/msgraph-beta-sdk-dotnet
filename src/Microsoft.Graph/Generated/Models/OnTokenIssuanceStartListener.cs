using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnTokenIssuanceStartListener : AuthenticationEventListener, IParsable {
        /// <summary>The handler to invoke when conditions are met for this onTokenIssuanceStartListener.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnTokenIssuanceStartHandler? Handler {
            get { return BackingStore?.Get<OnTokenIssuanceStartHandler?>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#nullable restore
#else
        public OnTokenIssuanceStartHandler Handler {
            get { return BackingStore?.Get<OnTokenIssuanceStartHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onTokenIssuanceStartListener and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartListener() : base() {
            OdataType = "#microsoft.graph.onTokenIssuanceStartListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnTokenIssuanceStartHandler>("handler", Handler);
        }
    }
}

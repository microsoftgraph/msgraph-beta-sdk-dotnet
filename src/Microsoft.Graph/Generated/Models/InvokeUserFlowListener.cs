using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InvokeUserFlowListener : AuthenticationListener, IParsable {
        /// <summary>The user flow that is invoked when this action executes.</summary>
        public B2xIdentityUserFlow UserFlow {
            get { return BackingStore?.Get<B2xIdentityUserFlow>("userFlow"); }
            set { BackingStore?.Set("userFlow", value); }
        }
        /// <summary>
        /// Instantiates a new InvokeUserFlowListener and sets the default values.
        /// </summary>
        public InvokeUserFlowListener() : base() {
            OdataType = "#microsoft.graph.invokeUserFlowListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InvokeUserFlowListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvokeUserFlowListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userFlow", n => { UserFlow = n.GetObjectValue<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<B2xIdentityUserFlow>("userFlow", UserFlow);
        }
    }
}

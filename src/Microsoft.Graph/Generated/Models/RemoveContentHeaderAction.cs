using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RemoveContentHeaderAction : InformationProtectionAction, IParsable {
        /// <summary>The name of the UI element of the header to be removed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UiElementNames {
            get { return BackingStore?.Get<List<string>?>("uiElementNames"); }
            set { BackingStore?.Set("uiElementNames", value); }
        }
#nullable restore
#else
        public List<string> UiElementNames {
            get { return BackingStore?.Get<List<string>>("uiElementNames"); }
            set { BackingStore?.Set("uiElementNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new RemoveContentHeaderAction and sets the default values.
        /// </summary>
        public RemoveContentHeaderAction() : base() {
            OdataType = "#microsoft.graph.removeContentHeaderAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoveContentHeaderAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoveContentHeaderAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"uiElementNames", n => { UiElementNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("uiElementNames", UiElementNames);
        }
    }
}

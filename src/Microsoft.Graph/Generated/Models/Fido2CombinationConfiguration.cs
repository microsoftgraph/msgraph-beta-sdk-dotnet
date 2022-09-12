using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Fido2CombinationConfiguration : AuthenticationCombinationConfiguration, IParsable {
        /// <summary>The allowedAAGUIDs property</summary>
        public List<string> AllowedAAGUIDs {
            get { return BackingStore?.Get<List<string>>("allowedAAGUIDs"); }
            set { BackingStore?.Set("allowedAAGUIDs", value); }
        }
        /// <summary>
        /// Instantiates a new Fido2CombinationConfiguration and sets the default values.
        /// </summary>
        public Fido2CombinationConfiguration() : base() {
            OdataType = "#microsoft.graph.fido2CombinationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Fido2CombinationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2CombinationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAAGUIDs", n => { AllowedAAGUIDs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAAGUIDs", AllowedAAGUIDs);
        }
    }
}

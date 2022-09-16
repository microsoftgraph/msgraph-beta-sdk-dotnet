using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationCombinationConfiguration : Entity, IParsable {
        /// <summary>The appliesToCombinations property</summary>
        public List<AuthenticationMethodModes?> AppliesToCombinations {
            get { return BackingStore?.Get<List<AuthenticationMethodModes?>>("appliesToCombinations"); }
            set { BackingStore?.Set("appliesToCombinations", value); }
        }
        /// <summary>
        /// Instantiates a new AuthenticationCombinationConfiguration and sets the default values.
        /// </summary>
        public AuthenticationCombinationConfiguration() : base() {
            OdataType = "#microsoft.graph.authenticationCombinationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthenticationCombinationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.fido2CombinationConfiguration" => new Fido2CombinationConfiguration(),
                _ => new AuthenticationCombinationConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliesToCombinations", n => { AppliesToCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("appliesToCombinations", AppliesToCombinations);
        }
    }
}

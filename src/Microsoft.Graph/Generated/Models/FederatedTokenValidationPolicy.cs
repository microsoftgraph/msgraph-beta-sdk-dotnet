using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class FederatedTokenValidationPolicy : DirectoryObject, IParsable {
        /// <summary>The validatingDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ValidatingDomains? ValidatingDomains {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ValidatingDomains?>("validatingDomains"); }
            set { BackingStore?.Set("validatingDomains", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ValidatingDomains ValidatingDomains {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ValidatingDomains>("validatingDomains"); }
            set { BackingStore?.Set("validatingDomains", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new federatedTokenValidationPolicy and sets the default values.
        /// </summary>
        public FederatedTokenValidationPolicy() : base() {
            OdataType = "#microsoft.graph.federatedTokenValidationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FederatedTokenValidationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FederatedTokenValidationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"validatingDomains", n => { ValidatingDomains = n.GetObjectValue<Microsoft.Graph.Beta.Models.ValidatingDomains>(Microsoft.Graph.Beta.Models.ValidatingDomains.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ValidatingDomains>("validatingDomains", ValidatingDomains);
        }
    }
}

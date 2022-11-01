using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class SharedEmailDomain : Entity, IParsable {
        /// <summary>The provisioningStatus property</summary>
        public string ProvisioningStatus {
            get { return BackingStore?.Get<string>("provisioningStatus"); }
            set { BackingStore?.Set("provisioningStatus", value); }
        }
        /// <summary>
        /// Instantiates a new sharedEmailDomain and sets the default values.
        /// </summary>
        public SharedEmailDomain() : base() {
            OdataType = "#microsoft.graph.sharedEmailDomain";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedEmailDomain CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedEmailDomain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"provisioningStatus", n => { ProvisioningStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("provisioningStatus", ProvisioningStatus);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class RiskyServicePrincipalHistoryItem : RiskyServicePrincipal, IParsable {
        /// <summary>The activity related to service principal risk level change.</summary>
        public RiskServicePrincipalActivity Activity {
            get { return BackingStore?.Get<RiskServicePrincipalActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>The identifier of the actor of the operation.</summary>
        public string InitiatedBy {
            get { return BackingStore?.Get<string>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
        /// <summary>The identifier of the service principal.</summary>
        public string ServicePrincipalId {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
        /// <summary>
        /// Instantiates a new riskyServicePrincipalHistoryItem and sets the default values.
        /// </summary>
        public RiskyServicePrincipalHistoryItem() : base() {
            OdataType = "#microsoft.graph.riskyServicePrincipalHistoryItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RiskyServicePrincipalHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskyServicePrincipalHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<RiskServicePrincipalActivity>(RiskServicePrincipalActivity.CreateFromDiscriminatorValue); } },
                {"initiatedBy", n => { InitiatedBy = n.GetStringValue(); } },
                {"servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<RiskServicePrincipalActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RiskyServicePrincipalHistoryItem : RiskyServicePrincipal, IParsable {
        /// <summary>The activity related to service principal risk level change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RiskServicePrincipalActivity? Activity {
            get { return BackingStore?.Get<RiskServicePrincipalActivity?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#else
        public RiskServicePrincipalActivity Activity {
            get { return BackingStore?.Get<RiskServicePrincipalActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The identifier of the actor of the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? InitiatedBy {
            get { return BackingStore?.Get<string?>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#else
        public string InitiatedBy {
            get { return BackingStore?.Get<string>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#endif
        /// <summary>The identifier of the service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ServicePrincipalId {
            get { return BackingStore?.Get<string?>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#else
        public string ServicePrincipalId {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<RiskServicePrincipalActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
        }
    }
}

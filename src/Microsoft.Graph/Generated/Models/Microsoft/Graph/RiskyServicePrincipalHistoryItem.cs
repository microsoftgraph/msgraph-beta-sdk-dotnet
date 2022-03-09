using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityProtectionRoot singleton.</summary>
    public class RiskyServicePrincipalHistoryItem : RiskyServicePrincipal, IParsable {
        /// <summary>The activity related to service principal risk level change.</summary>
        public RiskServicePrincipalActivity Activity { get; set; }
        /// <summary>The identifier of the actor of the operation.</summary>
        public string InitiatedBy { get; set; }
        /// <summary>The identifier of the service principal.</summary>
        public string ServicePrincipalId { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as RiskyServicePrincipalHistoryItem).Activity = n.GetObjectValue<RiskServicePrincipalActivity>(RiskServicePrincipalActivity.CreateFromDiscriminatorValue); } },
                {"initiatedBy", (o,n) => { (o as RiskyServicePrincipalHistoryItem).InitiatedBy = n.GetStringValue(); } },
                {"servicePrincipalId", (o,n) => { (o as RiskyServicePrincipalHistoryItem).ServicePrincipalId = n.GetStringValue(); } },
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

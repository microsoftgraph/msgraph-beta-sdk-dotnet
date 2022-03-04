using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TenantRelationships.ManagedTenants.AggregatedPolicyCompliances {
    public class AggregatedPolicyCompliancesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<AggregatedPolicyCompliance> Value { get; set; }
        /// <summary>
        /// Instantiates a new aggregatedPolicyCompliancesResponse and sets the default values.
        /// </summary>
        public AggregatedPolicyCompliancesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AggregatedPolicyCompliancesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AggregatedPolicyCompliancesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as AggregatedPolicyCompliancesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AggregatedPolicyCompliancesResponse).Value = n.GetCollectionOfObjectValues<AggregatedPolicyCompliance>(AggregatedPolicyCompliance.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<AggregatedPolicyCompliance>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ComanagementEligibleDevicesSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of devices already Co-Managed</summary>
        public int? ComanagedCount { get; set; }
        /// <summary>Count of devices eligible for Co-Management but not yet joined to Azure Active Directory</summary>
        public int? EligibleButNotAzureAdJoinedCount { get; set; }
        /// <summary>Count of devices fully eligible for Co-Management</summary>
        public int? EligibleCount { get; set; }
        /// <summary>Count of devices ineligible for Co-Management</summary>
        public int? IneligibleCount { get; set; }
        /// <summary>Count of devices that will be eligible for Co-Management after an OS update</summary>
        public int? NeedsOsUpdateCount { get; set; }
        /// <summary>
        /// Instantiates a new comanagementEligibleDevicesSummary and sets the default values.
        /// </summary>
        public ComanagementEligibleDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ComanagementEligibleDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComanagementEligibleDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comanagedCount", (o,n) => { (o as ComanagementEligibleDevicesSummary).ComanagedCount = n.GetIntValue(); } },
                {"eligibleButNotAzureAdJoinedCount", (o,n) => { (o as ComanagementEligibleDevicesSummary).EligibleButNotAzureAdJoinedCount = n.GetIntValue(); } },
                {"eligibleCount", (o,n) => { (o as ComanagementEligibleDevicesSummary).EligibleCount = n.GetIntValue(); } },
                {"ineligibleCount", (o,n) => { (o as ComanagementEligibleDevicesSummary).IneligibleCount = n.GetIntValue(); } },
                {"needsOsUpdateCount", (o,n) => { (o as ComanagementEligibleDevicesSummary).NeedsOsUpdateCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("comanagedCount", ComanagedCount);
            writer.WriteIntValue("eligibleButNotAzureAdJoinedCount", EligibleButNotAzureAdJoinedCount);
            writer.WriteIntValue("eligibleCount", EligibleCount);
            writer.WriteIntValue("ineligibleCount", IneligibleCount);
            writer.WriteIntValue("needsOsUpdateCount", NeedsOsUpdateCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

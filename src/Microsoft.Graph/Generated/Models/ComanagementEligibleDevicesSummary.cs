using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ComanagementEligibleDevicesSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of devices already Co-Managed</summary>
        public int? ComanagedCount {
            get { return BackingStore?.Get<int?>("comanagedCount"); }
            set { BackingStore?.Set("comanagedCount", value); }
        }
        /// <summary>Count of devices eligible for Co-Management but not yet joined to Azure Active Directory</summary>
        public int? EligibleButNotAzureAdJoinedCount {
            get { return BackingStore?.Get<int?>("eligibleButNotAzureAdJoinedCount"); }
            set { BackingStore?.Set("eligibleButNotAzureAdJoinedCount", value); }
        }
        /// <summary>Count of devices fully eligible for Co-Management</summary>
        public int? EligibleCount {
            get { return BackingStore?.Get<int?>("eligibleCount"); }
            set { BackingStore?.Set("eligibleCount", value); }
        }
        /// <summary>Count of devices ineligible for Co-Management</summary>
        public int? IneligibleCount {
            get { return BackingStore?.Get<int?>("ineligibleCount"); }
            set { BackingStore?.Set("ineligibleCount", value); }
        }
        /// <summary>Count of devices that will be eligible for Co-Management after an OS update</summary>
        public int? NeedsOsUpdateCount {
            get { return BackingStore?.Get<int?>("needsOsUpdateCount"); }
            set { BackingStore?.Set("needsOsUpdateCount", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Count of devices scheduled for Co-Management enrollment. Valid values 0 to 9999999</summary>
        public int? ScheduledForEnrollmentCount {
            get { return BackingStore?.Get<int?>("scheduledForEnrollmentCount"); }
            set { BackingStore?.Set("scheduledForEnrollmentCount", value); }
        }
        /// <summary>
        /// Instantiates a new comanagementEligibleDevicesSummary and sets the default values.
        /// </summary>
        public ComanagementEligibleDevicesSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ComanagementEligibleDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComanagementEligibleDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comanagedCount", n => { ComanagedCount = n.GetIntValue(); } },
                {"eligibleButNotAzureAdJoinedCount", n => { EligibleButNotAzureAdJoinedCount = n.GetIntValue(); } },
                {"eligibleCount", n => { EligibleCount = n.GetIntValue(); } },
                {"ineligibleCount", n => { IneligibleCount = n.GetIntValue(); } },
                {"needsOsUpdateCount", n => { NeedsOsUpdateCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scheduledForEnrollmentCount", n => { ScheduledForEnrollmentCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("comanagedCount", ComanagedCount);
            writer.WriteIntValue("eligibleButNotAzureAdJoinedCount", EligibleButNotAzureAdJoinedCount);
            writer.WriteIntValue("eligibleCount", EligibleCount);
            writer.WriteIntValue("ineligibleCount", IneligibleCount);
            writer.WriteIntValue("needsOsUpdateCount", NeedsOsUpdateCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("scheduledForEnrollmentCount", ScheduledForEnrollmentCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

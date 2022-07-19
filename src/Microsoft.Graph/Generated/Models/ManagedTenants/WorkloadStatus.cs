using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class WorkloadStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name for the workload. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The date and time the workload was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("offboardedDateTime"); }
            set { BackingStore?.Set("offboardedDateTime", value); }
        }
        /// <summary>The date and time the workload was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onboardedDateTime"); }
            set { BackingStore?.Set("onboardedDateTime", value); }
        }
        /// <summary>The onboardingStatus property</summary>
        public WorkloadOnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<WorkloadOnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>
        /// Instantiates a new workloadStatus and sets the default values.
        /// </summary>
        public WorkloadStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.workloadStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WorkloadStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkloadStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offboardedDateTime", n => { OffboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardedDateTime", n => { OnboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<WorkloadOnboardingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("offboardedDateTime", OffboardedDateTime);
            writer.WriteDateTimeOffsetValue("onboardedDateTime", OnboardedDateTime);
            writer.WriteEnumValue<WorkloadOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

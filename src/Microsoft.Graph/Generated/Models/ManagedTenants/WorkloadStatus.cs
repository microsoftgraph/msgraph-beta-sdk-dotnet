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
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name for the workload. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date and time the workload was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OffboardedDateTime)); }
            set { BackingStore?.Set(nameof(OffboardedDateTime), value); }
        }
        /// <summary>The date and time the workload was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OnboardedDateTime)); }
            set { BackingStore?.Set(nameof(OnboardedDateTime), value); }
        }
        /// <summary>The onboarding status for the workload. Possible values are: notOnboarded, onboarded, unknownFutureValue. Optional. Read-only.</summary>
        public WorkloadOnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<WorkloadOnboardingStatus?>(nameof(OnboardingStatus)); }
            set { BackingStore?.Set(nameof(OnboardingStatus), value); }
        }
        /// <summary>
        /// Instantiates a new workloadStatus and sets the default values.
        /// </summary>
        public WorkloadStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
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
            writer.WriteDateTimeOffsetValue("offboardedDateTime", OffboardedDateTime);
            writer.WriteDateTimeOffsetValue("onboardedDateTime", OnboardedDateTime);
            writer.WriteEnumValue<WorkloadOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

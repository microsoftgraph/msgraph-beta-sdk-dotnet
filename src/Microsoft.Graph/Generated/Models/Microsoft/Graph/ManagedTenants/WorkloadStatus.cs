using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class WorkloadStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name for the workload. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time the workload was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime { get; set; }
        /// <summary>The date and time the workload was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime { get; set; }
        /// <summary>The onboarding status for the workload. Possible values are: notOnboarded, onboarded, unknownFutureValue. Optional. Read-only.</summary>
        public WorkloadOnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>
        /// Instantiates a new workloadStatus and sets the default values.
        /// </summary>
        public WorkloadStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as WorkloadStatus).DisplayName = n.GetStringValue(); } },
                {"offboardedDateTime", (o,n) => { (o as WorkloadStatus).OffboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardedDateTime", (o,n) => { (o as WorkloadStatus).OnboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", (o,n) => { (o as WorkloadStatus).OnboardingStatus = n.GetEnumValue<WorkloadOnboardingStatus>(); } },
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

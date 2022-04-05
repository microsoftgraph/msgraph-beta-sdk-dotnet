using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WorkforceIntegration : ChangeTrackedEntity, IParsable {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion { get; set; }
        /// <summary>Name of the workforce integration.</summary>
        public string DisplayName { get; set; }
        /// <summary>The eligibilityFilteringEnabledEntities property</summary>
        public Microsoft.Graph.Beta.Models.EligibilityFilteringEnabledEntities? EligibilityFilteringEnabledEntities { get; set; }
        /// <summary>The workforce integration encryption resource.</summary>
        public WorkforceIntegrationEncryption Encryption { get; set; }
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. Possible values are: none, shift, swapRequest, userShiftPreferences, openshift, openShiftRequest, offerShiftRequest, unknownFutureValue.</summary>
        public WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. The possible values are: none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences, offerShiftRequest, unknownFutureValue, timeCard, timeOffReason, timeOff, timeOffRequest. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: timeCard, timeOffReason, timeOff, timeOffRequest. If selecting more than one value, all values must start with the first letter in uppercase.</summary>
        public WorkforceIntegrationSupportedEntities? Supports { get; set; }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkforceIntegration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkforceIntegration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiVersion", (o,n) => { (o as WorkforceIntegration).ApiVersion = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as WorkforceIntegration).DisplayName = n.GetStringValue(); } },
                {"eligibilityFilteringEnabledEntities", (o,n) => { (o as WorkforceIntegration).EligibilityFilteringEnabledEntities = n.GetEnumValue<EligibilityFilteringEnabledEntities>(); } },
                {"encryption", (o,n) => { (o as WorkforceIntegration).Encryption = n.GetObjectValue<WorkforceIntegrationEncryption>(WorkforceIntegrationEncryption.CreateFromDiscriminatorValue); } },
                {"isActive", (o,n) => { (o as WorkforceIntegration).IsActive = n.GetBoolValue(); } },
                {"supportedEntities", (o,n) => { (o as WorkforceIntegration).SupportedEntities = n.GetEnumValue<WorkforceIntegrationSupportedEntities>(); } },
                {"supports", (o,n) => { (o as WorkforceIntegration).Supports = n.GetEnumValue<WorkforceIntegrationSupportedEntities>(); } },
                {"url", (o,n) => { (o as WorkforceIntegration).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("apiVersion", ApiVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EligibilityFilteringEnabledEntities>("eligibilityFilteringEnabledEntities", EligibilityFilteringEnabledEntities);
            writer.WriteObjectValue<WorkforceIntegrationEncryption>("encryption", Encryption);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteEnumValue<WorkforceIntegrationSupportedEntities>("supportedEntities", SupportedEntities);
            writer.WriteEnumValue<WorkforceIntegrationSupportedEntities>("supports", Supports);
            writer.WriteStringValue("url", Url);
        }
    }
}

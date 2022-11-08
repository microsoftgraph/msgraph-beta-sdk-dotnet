using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WorkforceIntegration : ChangeTrackedEntity, IParsable {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion {
            get { return BackingStore?.Get<int?>("apiVersion"); }
            set { BackingStore?.Set("apiVersion", value); }
        }
        /// <summary>Name of the workforce integration.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The eligibilityFilteringEnabledEntities property</summary>
        public Microsoft.Graph.Beta.Models.EligibilityFilteringEnabledEntities? EligibilityFilteringEnabledEntities {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EligibilityFilteringEnabledEntities?>("eligibilityFilteringEnabledEntities"); }
            set { BackingStore?.Set("eligibilityFilteringEnabledEntities", value); }
        }
        /// <summary>The workforce integration encryption resource.</summary>
        public WorkforceIntegrationEncryption Encryption {
            get { return BackingStore?.Get<WorkforceIntegrationEncryption>("encryption"); }
            set { BackingStore?.Set("encryption", value); }
        }
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>This property has replaced supports in v1.0. We recommend that you use this property instead of supports. The supports property is still supported in beta for the time being. The possible values are: none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences, offerShiftRequest, unknownFutureValue, timeCard, timeOffReason, timeOff, timeOffRequest. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: timeCard, timeOffReason, timeOff, timeOffRequest. If selecting more than one value, all values must start with the first letter in uppercase.</summary>
        public WorkforceIntegrationSupportedEntities? SupportedEntities {
            get { return BackingStore?.Get<WorkforceIntegrationSupportedEntities?>("supportedEntities"); }
            set { BackingStore?.Set("supportedEntities", value); }
        }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. The possible values are: none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences, offerShiftRequest, unknownFutureValue, timeCard, timeOffReason, timeOff, timeOffRequest. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: timeCard, timeOffReason, timeOff, timeOffRequest. If selecting more than one value, all values must start with the first letter in uppercase.</summary>
        public WorkforceIntegrationSupportedEntities? Supports {
            get { return BackingStore?.Get<WorkforceIntegrationSupportedEntities?>("supports"); }
            set { BackingStore?.Set("supports", value); }
        }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
        /// <summary>
        /// Instantiates a new WorkforceIntegration and sets the default values.
        /// </summary>
        public WorkforceIntegration() : base() {
            OdataType = "#microsoft.graph.workforceIntegration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkforceIntegration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkforceIntegration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apiVersion", n => { ApiVersion = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"eligibilityFilteringEnabledEntities", n => { EligibilityFilteringEnabledEntities = n.GetEnumValue<EligibilityFilteringEnabledEntities>(); } },
                {"encryption", n => { Encryption = n.GetObjectValue<WorkforceIntegrationEncryption>(WorkforceIntegrationEncryption.CreateFromDiscriminatorValue); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"supportedEntities", n => { SupportedEntities = n.GetEnumValue<WorkforceIntegrationSupportedEntities>(); } },
                {"supports", n => { Supports = n.GetEnumValue<WorkforceIntegrationSupportedEntities>(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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

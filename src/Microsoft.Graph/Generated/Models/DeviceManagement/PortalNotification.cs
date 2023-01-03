using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class PortalNotification : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The associated alert impact.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact AlertImpact {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>("alertImpact"); }
            set { BackingStore?.Set("alertImpact", value); }
        }
        /// <summary>The associated alert record ID.</summary>
        public string AlertRecordId {
            get { return BackingStore?.Get<string>("alertRecordId"); }
            set { BackingStore?.Set("alertRecordId", value); }
        }
        /// <summary>The associated alert rule ID.</summary>
        public string AlertRuleId {
            get { return BackingStore?.Get<string>("alertRuleId"); }
            set { BackingStore?.Set("alertRuleId", value); }
        }
        /// <summary>The associated alert rule name.</summary>
        public string AlertRuleName {
            get { return BackingStore?.Get<string>("alertRuleName"); }
            set { BackingStore?.Set("alertRuleName", value); }
        }
        /// <summary>The associated alert rule template. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique identifier for the portal notification.</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>true if the portal notification has already been sent to the user; false otherwise.</summary>
        public bool? IsPortalNotificationSent {
            get { return BackingStore?.Get<bool?>("isPortalNotificationSent"); }
            set { BackingStore?.Set("isPortalNotificationSent", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The associated alert rule severity. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public RuleSeverityType? Severity {
            get { return BackingStore?.Get<RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>
        /// Instantiates a new portalNotification and sets the default values.
        /// </summary>
        public PortalNotification() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PortalNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PortalNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertImpact", n => { AlertImpact = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>(Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact.CreateFromDiscriminatorValue); } },
                {"alertRecordId", n => { AlertRecordId = n.GetStringValue(); } },
                {"alertRuleId", n => { AlertRuleId = n.GetStringValue(); } },
                {"alertRuleName", n => { AlertRuleName = n.GetStringValue(); } },
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isPortalNotificationSent", n => { IsPortalNotificationSent = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagement.AlertImpact>("alertImpact", AlertImpact);
            writer.WriteStringValue("alertRecordId", AlertRecordId);
            writer.WriteStringValue("alertRuleId", AlertRuleId);
            writer.WriteStringValue("alertRuleName", AlertRuleName);
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isPortalNotificationSent", IsPortalNotificationSent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

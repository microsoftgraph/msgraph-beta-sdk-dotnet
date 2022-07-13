using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class EmailThreatSubmissionPolicy : Entity, IParsable {
        /// <summary>The customizedNotificationSenderEmailAddress property</summary>
        public string CustomizedNotificationSenderEmailAddress {
            get { return BackingStore?.Get<string>("customizedNotificationSenderEmailAddress"); }
            set { BackingStore?.Set("customizedNotificationSenderEmailAddress", value); }
        }
        /// <summary>The customizedReportRecipientEmailAddress property</summary>
        public string CustomizedReportRecipientEmailAddress {
            get { return BackingStore?.Get<string>("customizedReportRecipientEmailAddress"); }
            set { BackingStore?.Set("customizedReportRecipientEmailAddress", value); }
        }
        /// <summary>The isAlwaysReportEnabledForUsers property</summary>
        public bool? IsAlwaysReportEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isAlwaysReportEnabledForUsers"); }
            set { BackingStore?.Set("isAlwaysReportEnabledForUsers", value); }
        }
        /// <summary>The isAskMeEnabledForUsers property</summary>
        public bool? IsAskMeEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isAskMeEnabledForUsers"); }
            set { BackingStore?.Set("isAskMeEnabledForUsers", value); }
        }
        /// <summary>The isCustomizedMessageEnabled property</summary>
        public bool? IsCustomizedMessageEnabled {
            get { return BackingStore?.Get<bool?>("isCustomizedMessageEnabled"); }
            set { BackingStore?.Set("isCustomizedMessageEnabled", value); }
        }
        /// <summary>The isCustomizedMessageEnabledForPhishing property</summary>
        public bool? IsCustomizedMessageEnabledForPhishing {
            get { return BackingStore?.Get<bool?>("isCustomizedMessageEnabledForPhishing"); }
            set { BackingStore?.Set("isCustomizedMessageEnabledForPhishing", value); }
        }
        /// <summary>The isCustomizedNotificationSenderEnabled property</summary>
        public bool? IsCustomizedNotificationSenderEnabled {
            get { return BackingStore?.Get<bool?>("isCustomizedNotificationSenderEnabled"); }
            set { BackingStore?.Set("isCustomizedNotificationSenderEnabled", value); }
        }
        /// <summary>The isNeverReportEnabledForUsers property</summary>
        public bool? IsNeverReportEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isNeverReportEnabledForUsers"); }
            set { BackingStore?.Set("isNeverReportEnabledForUsers", value); }
        }
        /// <summary>The isOrganizationBrandingEnabled property</summary>
        public bool? IsOrganizationBrandingEnabled {
            get { return BackingStore?.Get<bool?>("isOrganizationBrandingEnabled"); }
            set { BackingStore?.Set("isOrganizationBrandingEnabled", value); }
        }
        /// <summary>The isReportFromQuarantineEnabled property</summary>
        public bool? IsReportFromQuarantineEnabled {
            get { return BackingStore?.Get<bool?>("isReportFromQuarantineEnabled"); }
            set { BackingStore?.Set("isReportFromQuarantineEnabled", value); }
        }
        /// <summary>The isReportToCustomizedEmailAddressEnabled property</summary>
        public bool? IsReportToCustomizedEmailAddressEnabled {
            get { return BackingStore?.Get<bool?>("isReportToCustomizedEmailAddressEnabled"); }
            set { BackingStore?.Set("isReportToCustomizedEmailAddressEnabled", value); }
        }
        /// <summary>The isReportToMicrosoftEnabled property</summary>
        public bool? IsReportToMicrosoftEnabled {
            get { return BackingStore?.Get<bool?>("isReportToMicrosoftEnabled"); }
            set { BackingStore?.Set("isReportToMicrosoftEnabled", value); }
        }
        /// <summary>The isReviewEmailNotificationEnabled property</summary>
        public bool? IsReviewEmailNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isReviewEmailNotificationEnabled"); }
            set { BackingStore?.Set("isReviewEmailNotificationEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EmailThreatSubmissionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailThreatSubmissionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customizedNotificationSenderEmailAddress", n => { CustomizedNotificationSenderEmailAddress = n.GetStringValue(); } },
                {"customizedReportRecipientEmailAddress", n => { CustomizedReportRecipientEmailAddress = n.GetStringValue(); } },
                {"isAlwaysReportEnabledForUsers", n => { IsAlwaysReportEnabledForUsers = n.GetBoolValue(); } },
                {"isAskMeEnabledForUsers", n => { IsAskMeEnabledForUsers = n.GetBoolValue(); } },
                {"isCustomizedMessageEnabled", n => { IsCustomizedMessageEnabled = n.GetBoolValue(); } },
                {"isCustomizedMessageEnabledForPhishing", n => { IsCustomizedMessageEnabledForPhishing = n.GetBoolValue(); } },
                {"isCustomizedNotificationSenderEnabled", n => { IsCustomizedNotificationSenderEnabled = n.GetBoolValue(); } },
                {"isNeverReportEnabledForUsers", n => { IsNeverReportEnabledForUsers = n.GetBoolValue(); } },
                {"isOrganizationBrandingEnabled", n => { IsOrganizationBrandingEnabled = n.GetBoolValue(); } },
                {"isReportFromQuarantineEnabled", n => { IsReportFromQuarantineEnabled = n.GetBoolValue(); } },
                {"isReportToCustomizedEmailAddressEnabled", n => { IsReportToCustomizedEmailAddressEnabled = n.GetBoolValue(); } },
                {"isReportToMicrosoftEnabled", n => { IsReportToMicrosoftEnabled = n.GetBoolValue(); } },
                {"isReviewEmailNotificationEnabled", n => { IsReviewEmailNotificationEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customizedNotificationSenderEmailAddress", CustomizedNotificationSenderEmailAddress);
            writer.WriteStringValue("customizedReportRecipientEmailAddress", CustomizedReportRecipientEmailAddress);
            writer.WriteBoolValue("isAlwaysReportEnabledForUsers", IsAlwaysReportEnabledForUsers);
            writer.WriteBoolValue("isAskMeEnabledForUsers", IsAskMeEnabledForUsers);
            writer.WriteBoolValue("isCustomizedMessageEnabled", IsCustomizedMessageEnabled);
            writer.WriteBoolValue("isCustomizedMessageEnabledForPhishing", IsCustomizedMessageEnabledForPhishing);
            writer.WriteBoolValue("isCustomizedNotificationSenderEnabled", IsCustomizedNotificationSenderEnabled);
            writer.WriteBoolValue("isNeverReportEnabledForUsers", IsNeverReportEnabledForUsers);
            writer.WriteBoolValue("isOrganizationBrandingEnabled", IsOrganizationBrandingEnabled);
            writer.WriteBoolValue("isReportFromQuarantineEnabled", IsReportFromQuarantineEnabled);
            writer.WriteBoolValue("isReportToCustomizedEmailAddressEnabled", IsReportToCustomizedEmailAddressEnabled);
            writer.WriteBoolValue("isReportToMicrosoftEnabled", IsReportToMicrosoftEnabled);
            writer.WriteBoolValue("isReviewEmailNotificationEnabled", IsReviewEmailNotificationEnabled);
        }
    }
}

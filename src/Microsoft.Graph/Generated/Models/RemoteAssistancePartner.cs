using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// RemoteAssistPartner resources represent the metadata and status of a given Remote Assistance partner service.
    /// </summary>
    public class RemoteAssistancePartner : Entity, IParsable {
        /// <summary>Display name of the partner.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Timestamp of the last request sent to Intune by the TEM partner.</summary>
        public DateTimeOffset? LastConnectionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastConnectionDateTime"); }
            set { BackingStore?.Set("lastConnectionDateTime", value); }
        }
        /// <summary>When the OnboardingStatus is Onboarding, This is the date time when the onboarding request expires.</summary>
        public DateTimeOffset? OnboardingRequestExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onboardingRequestExpiryDateTime"); }
            set { BackingStore?.Set("onboardingRequestExpiryDateTime", value); }
        }
        /// <summary>The current TeamViewer connector status</summary>
        public RemoteAssistanceOnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<RemoteAssistanceOnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</summary>
        public string OnboardingUrl {
            get { return BackingStore?.Get<string>("onboardingUrl"); }
            set { BackingStore?.Set("onboardingUrl", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoteAssistancePartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteAssistancePartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", n => { LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingRequestExpiryDateTime", n => { OnboardingRequestExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<RemoteAssistanceOnboardingStatus>(); } },
                {"onboardingUrl", n => { OnboardingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteDateTimeOffsetValue("onboardingRequestExpiryDateTime", OnboardingRequestExpiryDateTime);
            writer.WriteEnumValue<RemoteAssistanceOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteStringValue("onboardingUrl", OnboardingUrl);
        }
    }
}

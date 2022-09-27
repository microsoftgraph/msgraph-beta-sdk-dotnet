using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ChromeOSOnboardingSettings : Entity, IParsable {
        /// <summary>The ChromebookTenant&apos;s LastDirectorySyncDateTime</summary>
        public DateTimeOffset? LastDirectorySyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastDirectorySyncDateTime"); }
            set { BackingStore?.Set("lastDirectorySyncDateTime", value); }
        }
        /// <summary>The ChromebookTenant&apos;s LastModifiedDateTime</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The onboarding status of the tenant.</summary>
        public Microsoft.Graph.Beta.Models.OnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>The ChromebookTenant&apos;s OwnerUserPrincipalName</summary>
        public string OwnerUserPrincipalName {
            get { return BackingStore?.Get<string>("ownerUserPrincipalName"); }
            set { BackingStore?.Set("ownerUserPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new ChromeOSOnboardingSettings and sets the default values.
        /// </summary>
        public ChromeOSOnboardingSettings() : base() {
            OdataType = "#microsoft.graph.chromeOSOnboardingSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChromeOSOnboardingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChromeOSOnboardingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastDirectorySyncDateTime", n => { LastDirectorySyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<OnboardingStatus>(); } },
                {"ownerUserPrincipalName", n => { OwnerUserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastDirectorySyncDateTime", LastDirectorySyncDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<OnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteStringValue("ownerUserPrincipalName", OwnerUserPrincipalName);
        }
    }
}

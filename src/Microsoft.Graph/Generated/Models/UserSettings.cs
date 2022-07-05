using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class UserSettings : Entity, IParsable {
        /// <summary>The user&apos;s settings for the visibility of merge suggestion for the duplicate contacts in the user&apos;s contact list.</summary>
        public Microsoft.Graph.Beta.Models.ContactMergeSuggestions ContactMergeSuggestions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContactMergeSuggestions>(nameof(ContactMergeSuggestions)); }
            set { BackingStore?.Set(nameof(ContactMergeSuggestions), value); }
        }
        /// <summary>Reflects the Office Delve organization level setting. When set to true, the organization doesn&apos;t have access to Office Delve. This setting is read-only and can only be changed by administrators in the SharePoint admin center.</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ContributionToContentDiscoveryAsOrganizationDisabled)); }
            set { BackingStore?.Set(nameof(ContributionToContentDiscoveryAsOrganizationDisabled), value); }
        }
        /// <summary>When set to true, documents in the user&apos;s Office Delve are disabled. Users can control this setting in Office Delve.</summary>
        public bool? ContributionToContentDiscoveryDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ContributionToContentDiscoveryDisabled)); }
            set { BackingStore?.Set(nameof(ContributionToContentDiscoveryDisabled), value); }
        }
        /// <summary>The user&apos;s settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites. Get userInsightsSettings through this navigation property.</summary>
        public UserInsightsSettings ItemInsights {
            get { return BackingStore?.Get<UserInsightsSettings>(nameof(ItemInsights)); }
            set { BackingStore?.Set(nameof(ItemInsights), value); }
        }
        /// <summary>The user&apos;s preferences for languages, regional locale and date/time formatting.</summary>
        public Microsoft.Graph.Beta.Models.RegionalAndLanguageSettings RegionalAndLanguageSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RegionalAndLanguageSettings>(nameof(RegionalAndLanguageSettings)); }
            set { BackingStore?.Set(nameof(RegionalAndLanguageSettings), value); }
        }
        /// <summary>The shift preferences for the user.</summary>
        public Microsoft.Graph.Beta.Models.ShiftPreferences ShiftPreferences {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ShiftPreferences>(nameof(ShiftPreferences)); }
            set { BackingStore?.Set(nameof(ShiftPreferences), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contactMergeSuggestions", n => { ContactMergeSuggestions = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContactMergeSuggestions>(Microsoft.Graph.Beta.Models.ContactMergeSuggestions.CreateFromDiscriminatorValue); } },
                {"contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                {"contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                {"itemInsights", n => { ItemInsights = n.GetObjectValue<UserInsightsSettings>(UserInsightsSettings.CreateFromDiscriminatorValue); } },
                {"regionalAndLanguageSettings", n => { RegionalAndLanguageSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.RegionalAndLanguageSettings>(Microsoft.Graph.Beta.Models.RegionalAndLanguageSettings.CreateFromDiscriminatorValue); } },
                {"shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<Microsoft.Graph.Beta.Models.ShiftPreferences>(Microsoft.Graph.Beta.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContactMergeSuggestions>("contactMergeSuggestions", ContactMergeSuggestions);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<UserInsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RegionalAndLanguageSettings>("regionalAndLanguageSettings", RegionalAndLanguageSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
        }
    }
}

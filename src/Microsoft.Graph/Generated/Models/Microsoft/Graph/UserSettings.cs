using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserSettings : Entity, IParsable {
        public MicrosoftGraph.Models.Microsoft.Graph.ContactMergeSuggestions ContactMergeSuggestions { get; set; }
        /// <summary>Reflects the Office Delve organization level setting. When set to true, the organization doesn't have access to Office Delve. This setting is read-only and can only be changed by administrators in the SharePoint admin center.</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        /// <summary>When set to true, documents in the user's Office Delve are disabled. Users can control this setting in Office Delve.</summary>
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
        /// <summary>The user's settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites. Get userInsightsSettings through this navigation property.</summary>
        public UserInsightsSettings ItemInsights { get; set; }
        /// <summary>The user's preferences for languages, regional locale and date/time formatting.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.RegionalAndLanguageSettings RegionalAndLanguageSettings { get; set; }
        /// <summary>The shift preferences for the user.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.ShiftPreferences ShiftPreferences { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contactMergeSuggestions", (o,n) => { (o as UserSettings).ContactMergeSuggestions = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ContactMergeSuggestions>(); } },
                {"contributionToContentDiscoveryAsOrganizationDisabled", (o,n) => { (o as UserSettings).ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                {"contributionToContentDiscoveryDisabled", (o,n) => { (o as UserSettings).ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                {"itemInsights", (o,n) => { (o as UserSettings).ItemInsights = n.GetObjectValue<UserInsightsSettings>(); } },
                {"regionalAndLanguageSettings", (o,n) => { (o as UserSettings).RegionalAndLanguageSettings = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.RegionalAndLanguageSettings>(); } },
                {"shiftPreferences", (o,n) => { (o as UserSettings).ShiftPreferences = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ShiftPreferences>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ContactMergeSuggestions>("contactMergeSuggestions", ContactMergeSuggestions);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<UserInsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.RegionalAndLanguageSettings>("regionalAndLanguageSettings", RegionalAndLanguageSettings);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ShiftPreferences>("shiftPreferences", ShiftPreferences);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationSettings : Entity, IParsable {
        /// <summary>Contains the properties that are configured by an administrator for the visibility of Microsoft Graph-derived insights, between a user and other items in Microsoft 365, such as documents or sites. List itemInsights returns the settings to display or return item insights in an organization.</summary>
        public InsightsSettings ItemInsights { get; set; }
        /// <summary>The microsoftApplicationDataAccess property</summary>
        public MicrosoftApplicationDataAccessSettings MicrosoftApplicationDataAccess { get; set; }
        /// <summary>Contains the properties that are configured by an administrator for the visibility of a list of people relevant and working with a user in Microsoft 365. List peopleInsights returns the settings to display or return people insights in an organization.</summary>
        public InsightsSettings PeopleInsights { get; set; }
        /// <summary>Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.</summary>
        public List<ProfileCardProperty> ProfileCardProperties { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"itemInsights", (o,n) => { (o as OrganizationSettings).ItemInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"microsoftApplicationDataAccess", (o,n) => { (o as OrganizationSettings).MicrosoftApplicationDataAccess = n.GetObjectValue<MicrosoftApplicationDataAccessSettings>(MicrosoftApplicationDataAccessSettings.CreateFromDiscriminatorValue); } },
                {"peopleInsights", (o,n) => { (o as OrganizationSettings).PeopleInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"profileCardProperties", (o,n) => { (o as OrganizationSettings).ProfileCardProperties = n.GetCollectionOfObjectValues<ProfileCardProperty>(ProfileCardProperty.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<InsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess", MicrosoftApplicationDataAccess);
            writer.WriteObjectValue<InsightsSettings>("peopleInsights", PeopleInsights);
            writer.WriteCollectionOfObjectValues<ProfileCardProperty>("profileCardProperties", ProfileCardProperties);
        }
    }
}

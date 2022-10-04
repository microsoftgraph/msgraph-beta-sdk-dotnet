using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationSettings : Entity, IParsable {
        /// <summary>Contains the properties that are configured by an administrator as a tenant-level privacy control whether to identify duplicate contacts among a user&apos;s contacts list and suggest the user to merge those contacts to have a cleaner contacts list. List contactInsights returns the settings to display or return contact insights in an organization.</summary>
        public InsightsSettings ContactInsights {
            get { return BackingStore?.Get<InsightsSettings>("contactInsights"); }
            set { BackingStore?.Set("contactInsights", value); }
        }
        /// <summary>Contains the properties that are configured by an administrator for the visibility of Microsoft Graph-derived insights, between a user and other items in Microsoft 365, such as documents or sites. List itemInsights returns the settings to display or return item insights in an organization.</summary>
        public InsightsSettings ItemInsights {
            get { return BackingStore?.Get<InsightsSettings>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
        /// <summary>The microsoftApplicationDataAccess property</summary>
        public MicrosoftApplicationDataAccessSettings MicrosoftApplicationDataAccess {
            get { return BackingStore?.Get<MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess"); }
            set { BackingStore?.Set("microsoftApplicationDataAccess", value); }
        }
        /// <summary>Contains the properties that are configured by an administrator for the visibility of a list of people relevant and working with a user in Microsoft 365. List peopleInsights returns the settings to display or return people insights in an organization.</summary>
        public InsightsSettings PeopleInsights {
            get { return BackingStore?.Get<InsightsSettings>("peopleInsights"); }
            set { BackingStore?.Set("peopleInsights", value); }
        }
        /// <summary>Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.</summary>
        public List<ProfileCardProperty> ProfileCardProperties {
            get { return BackingStore?.Get<List<ProfileCardProperty>>("profileCardProperties"); }
            set { BackingStore?.Set("profileCardProperties", value); }
        }
        /// <summary>
        /// Instantiates a new organizationSettings and sets the default values.
        /// </summary>
        public OrganizationSettings() : base() {
            OdataType = "#microsoft.graph.organizationSettings";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contactInsights", n => { ContactInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"itemInsights", n => { ItemInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"microsoftApplicationDataAccess", n => { MicrosoftApplicationDataAccess = n.GetObjectValue<MicrosoftApplicationDataAccessSettings>(MicrosoftApplicationDataAccessSettings.CreateFromDiscriminatorValue); } },
                {"peopleInsights", n => { PeopleInsights = n.GetObjectValue<InsightsSettings>(InsightsSettings.CreateFromDiscriminatorValue); } },
                {"profileCardProperties", n => { ProfileCardProperties = n.GetCollectionOfObjectValues<ProfileCardProperty>(ProfileCardProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<InsightsSettings>("contactInsights", ContactInsights);
            writer.WriteObjectValue<InsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess", MicrosoftApplicationDataAccess);
            writer.WriteObjectValue<InsightsSettings>("peopleInsights", PeopleInsights);
            writer.WriteCollectionOfObjectValues<ProfileCardProperty>("profileCardProperties", ProfileCardProperties);
        }
    }
}

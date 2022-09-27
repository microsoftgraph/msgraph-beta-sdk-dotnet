using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Profile : Entity, IParsable {
        /// <summary>The account property</summary>
        public List<UserAccountInformation> Account {
            get { return BackingStore?.Get<List<UserAccountInformation>>("account"); }
            set { BackingStore?.Set("account", value); }
        }
        /// <summary>Represents details of addresses associated with the user.</summary>
        public List<ItemAddress> Addresses {
            get { return BackingStore?.Get<List<ItemAddress>>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
        /// <summary>Represents the details of meaningful dates associated with a person.</summary>
        public List<PersonAnnualEvent> Anniversaries {
            get { return BackingStore?.Get<List<PersonAnnualEvent>>("anniversaries"); }
            set { BackingStore?.Set("anniversaries", value); }
        }
        /// <summary>Represents the details of awards or honors associated with a person.</summary>
        public List<PersonAward> Awards {
            get { return BackingStore?.Get<List<PersonAward>>("awards"); }
            set { BackingStore?.Set("awards", value); }
        }
        /// <summary>Represents the details of certifications associated with a person.</summary>
        public List<PersonCertification> Certifications {
            get { return BackingStore?.Get<List<PersonCertification>>("certifications"); }
            set { BackingStore?.Set("certifications", value); }
        }
        /// <summary>Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.</summary>
        public List<EducationalActivity> EducationalActivities {
            get { return BackingStore?.Get<List<EducationalActivity>>("educationalActivities"); }
            set { BackingStore?.Set("educationalActivities", value); }
        }
        /// <summary>Represents detailed information about email addresses associated with the user.</summary>
        public List<ItemEmail> Emails {
            get { return BackingStore?.Get<List<ItemEmail>>("emails"); }
            set { BackingStore?.Set("emails", value); }
        }
        /// <summary>Provides detailed information about interests the user has associated with themselves in various services.</summary>
        public List<PersonInterest> Interests {
            get { return BackingStore?.Get<List<PersonInterest>>("interests"); }
            set { BackingStore?.Set("interests", value); }
        }
        /// <summary>Represents detailed information about languages that a user has added to their profile.</summary>
        public List<LanguageProficiency> Languages {
            get { return BackingStore?.Get<List<LanguageProficiency>>("languages"); }
            set { BackingStore?.Set("languages", value); }
        }
        /// <summary>Represents the names a user has added to their profile.</summary>
        public List<PersonName> Names {
            get { return BackingStore?.Get<List<PersonName>>("names"); }
            set { BackingStore?.Set("names", value); }
        }
        /// <summary>Represents notes that a user has added to their profile.</summary>
        public List<PersonAnnotation> Notes {
            get { return BackingStore?.Get<List<PersonAnnotation>>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>Represents patents that a user has added to their profile.</summary>
        public List<ItemPatent> Patents {
            get { return BackingStore?.Get<List<ItemPatent>>("patents"); }
            set { BackingStore?.Set("patents", value); }
        }
        /// <summary>Represents detailed information about phone numbers associated with a user in various services.</summary>
        public List<ItemPhone> Phones {
            get { return BackingStore?.Get<List<ItemPhone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
        /// <summary>Represents detailed information about work positions associated with a user&apos;s profile.</summary>
        public List<WorkPosition> Positions {
            get { return BackingStore?.Get<List<WorkPosition>>("positions"); }
            set { BackingStore?.Set("positions", value); }
        }
        /// <summary>Represents detailed information about projects associated with a user.</summary>
        public List<ProjectParticipation> Projects {
            get { return BackingStore?.Get<List<ProjectParticipation>>("projects"); }
            set { BackingStore?.Set("projects", value); }
        }
        /// <summary>Represents details of any publications a user has added to their profile.</summary>
        public List<ItemPublication> Publications {
            get { return BackingStore?.Get<List<ItemPublication>>("publications"); }
            set { BackingStore?.Set("publications", value); }
        }
        /// <summary>Represents detailed information about skills associated with a user in various services.</summary>
        public List<SkillProficiency> Skills {
            get { return BackingStore?.Get<List<SkillProficiency>>("skills"); }
            set { BackingStore?.Set("skills", value); }
        }
        /// <summary>Represents web accounts the user has indicated they use or has added to their user profile.</summary>
        public List<WebAccount> WebAccounts {
            get { return BackingStore?.Get<List<WebAccount>>("webAccounts"); }
            set { BackingStore?.Set("webAccounts", value); }
        }
        /// <summary>Represents detailed information about websites associated with a user in various services.</summary>
        public List<PersonWebsite> Websites {
            get { return BackingStore?.Get<List<PersonWebsite>>("websites"); }
            set { BackingStore?.Set("websites", value); }
        }
        /// <summary>
        /// Instantiates a new profile and sets the default values.
        /// </summary>
        public Profile() : base() {
            OdataType = "#microsoft.graph.profile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Profile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Profile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetCollectionOfObjectValues<UserAccountInformation>(UserAccountInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"addresses", n => { Addresses = n.GetCollectionOfObjectValues<ItemAddress>(ItemAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"anniversaries", n => { Anniversaries = n.GetCollectionOfObjectValues<PersonAnnualEvent>(PersonAnnualEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"awards", n => { Awards = n.GetCollectionOfObjectValues<PersonAward>(PersonAward.CreateFromDiscriminatorValue)?.ToList(); } },
                {"certifications", n => { Certifications = n.GetCollectionOfObjectValues<PersonCertification>(PersonCertification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"educationalActivities", n => { EducationalActivities = n.GetCollectionOfObjectValues<EducationalActivity>(EducationalActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emails", n => { Emails = n.GetCollectionOfObjectValues<ItemEmail>(ItemEmail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"interests", n => { Interests = n.GetCollectionOfObjectValues<PersonInterest>(PersonInterest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"languages", n => { Languages = n.GetCollectionOfObjectValues<LanguageProficiency>(LanguageProficiency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"names", n => { Names = n.GetCollectionOfObjectValues<PersonName>(PersonName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notes", n => { Notes = n.GetCollectionOfObjectValues<PersonAnnotation>(PersonAnnotation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"patents", n => { Patents = n.GetCollectionOfObjectValues<ItemPatent>(ItemPatent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<ItemPhone>(ItemPhone.CreateFromDiscriminatorValue)?.ToList(); } },
                {"positions", n => { Positions = n.GetCollectionOfObjectValues<WorkPosition>(WorkPosition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"projects", n => { Projects = n.GetCollectionOfObjectValues<ProjectParticipation>(ProjectParticipation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publications", n => { Publications = n.GetCollectionOfObjectValues<ItemPublication>(ItemPublication.CreateFromDiscriminatorValue)?.ToList(); } },
                {"skills", n => { Skills = n.GetCollectionOfObjectValues<SkillProficiency>(SkillProficiency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"webAccounts", n => { WebAccounts = n.GetCollectionOfObjectValues<WebAccount>(WebAccount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"websites", n => { Websites = n.GetCollectionOfObjectValues<PersonWebsite>(PersonWebsite.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserAccountInformation>("account", Account);
            writer.WriteCollectionOfObjectValues<ItemAddress>("addresses", Addresses);
            writer.WriteCollectionOfObjectValues<PersonAnnualEvent>("anniversaries", Anniversaries);
            writer.WriteCollectionOfObjectValues<PersonAward>("awards", Awards);
            writer.WriteCollectionOfObjectValues<PersonCertification>("certifications", Certifications);
            writer.WriteCollectionOfObjectValues<EducationalActivity>("educationalActivities", EducationalActivities);
            writer.WriteCollectionOfObjectValues<ItemEmail>("emails", Emails);
            writer.WriteCollectionOfObjectValues<PersonInterest>("interests", Interests);
            writer.WriteCollectionOfObjectValues<LanguageProficiency>("languages", Languages);
            writer.WriteCollectionOfObjectValues<PersonName>("names", Names);
            writer.WriteCollectionOfObjectValues<PersonAnnotation>("notes", Notes);
            writer.WriteCollectionOfObjectValues<ItemPatent>("patents", Patents);
            writer.WriteCollectionOfObjectValues<ItemPhone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<WorkPosition>("positions", Positions);
            writer.WriteCollectionOfObjectValues<ProjectParticipation>("projects", Projects);
            writer.WriteCollectionOfObjectValues<ItemPublication>("publications", Publications);
            writer.WriteCollectionOfObjectValues<SkillProficiency>("skills", Skills);
            writer.WriteCollectionOfObjectValues<WebAccount>("webAccounts", WebAccounts);
            writer.WriteCollectionOfObjectValues<PersonWebsite>("websites", Websites);
        }
    }
}

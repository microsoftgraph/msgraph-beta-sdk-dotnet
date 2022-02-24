using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Profile : Entity, IParsable {
        public List<UserAccountInformation> Account { get; set; }
        /// <summary>Represents details of addresses associated with the user.</summary>
        public List<ItemAddress> Addresses { get; set; }
        /// <summary>Represents the details of meaningful dates associated with a person.</summary>
        public List<PersonAnnualEvent> Anniversaries { get; set; }
        /// <summary>Represents the details of awards or honors associated with a person.</summary>
        public List<PersonAward> Awards { get; set; }
        /// <summary>Represents the details of certifications associated with a person.</summary>
        public List<PersonCertification> Certifications { get; set; }
        /// <summary>Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.</summary>
        public List<EducationalActivity> EducationalActivities { get; set; }
        /// <summary>Represents detailed information about email addresses associated with the user.</summary>
        public List<ItemEmail> Emails { get; set; }
        /// <summary>Provides detailed information about interests the user has associated with themselves in various services.</summary>
        public List<PersonInterest> Interests { get; set; }
        /// <summary>Represents detailed information about languages that a user has added to their profile.</summary>
        public List<LanguageProficiency> Languages { get; set; }
        /// <summary>Represents the names a user has added to their profile.</summary>
        public List<PersonName> Names { get; set; }
        /// <summary>Represents notes that a user has added to their profile.</summary>
        public List<PersonAnnotation> Notes { get; set; }
        /// <summary>Represents patents that a user has added to their profile.</summary>
        public List<ItemPatent> Patents { get; set; }
        /// <summary>Represents detailed information about phone numbers associated with a user in various services.</summary>
        public List<ItemPhone> Phones { get; set; }
        /// <summary>Represents detailed information about work positions associated with a user's profile.</summary>
        public List<WorkPosition> Positions { get; set; }
        /// <summary>Represents detailed information about projects associated with a user.</summary>
        public List<ProjectParticipation> Projects { get; set; }
        /// <summary>Represents details of any publications a user has added to their profile.</summary>
        public List<ItemPublication> Publications { get; set; }
        /// <summary>Represents detailed information about skills associated with a user in various services.</summary>
        public List<SkillProficiency> Skills { get; set; }
        /// <summary>Represents web accounts the user has indicated they use or has added to their user profile.</summary>
        public List<WebAccount> WebAccounts { get; set; }
        /// <summary>Represents detailed information about websites associated with a user in various services.</summary>
        public List<PersonWebsite> Websites { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as Profile).Account = n.GetCollectionOfObjectValues<UserAccountInformation>().ToList(); } },
                {"addresses", (o,n) => { (o as Profile).Addresses = n.GetCollectionOfObjectValues<ItemAddress>().ToList(); } },
                {"anniversaries", (o,n) => { (o as Profile).Anniversaries = n.GetCollectionOfObjectValues<PersonAnnualEvent>().ToList(); } },
                {"awards", (o,n) => { (o as Profile).Awards = n.GetCollectionOfObjectValues<PersonAward>().ToList(); } },
                {"certifications", (o,n) => { (o as Profile).Certifications = n.GetCollectionOfObjectValues<PersonCertification>().ToList(); } },
                {"educationalActivities", (o,n) => { (o as Profile).EducationalActivities = n.GetCollectionOfObjectValues<EducationalActivity>().ToList(); } },
                {"emails", (o,n) => { (o as Profile).Emails = n.GetCollectionOfObjectValues<ItemEmail>().ToList(); } },
                {"interests", (o,n) => { (o as Profile).Interests = n.GetCollectionOfObjectValues<PersonInterest>().ToList(); } },
                {"languages", (o,n) => { (o as Profile).Languages = n.GetCollectionOfObjectValues<LanguageProficiency>().ToList(); } },
                {"names", (o,n) => { (o as Profile).Names = n.GetCollectionOfObjectValues<PersonName>().ToList(); } },
                {"notes", (o,n) => { (o as Profile).Notes = n.GetCollectionOfObjectValues<PersonAnnotation>().ToList(); } },
                {"patents", (o,n) => { (o as Profile).Patents = n.GetCollectionOfObjectValues<ItemPatent>().ToList(); } },
                {"phones", (o,n) => { (o as Profile).Phones = n.GetCollectionOfObjectValues<ItemPhone>().ToList(); } },
                {"positions", (o,n) => { (o as Profile).Positions = n.GetCollectionOfObjectValues<WorkPosition>().ToList(); } },
                {"projects", (o,n) => { (o as Profile).Projects = n.GetCollectionOfObjectValues<ProjectParticipation>().ToList(); } },
                {"publications", (o,n) => { (o as Profile).Publications = n.GetCollectionOfObjectValues<ItemPublication>().ToList(); } },
                {"skills", (o,n) => { (o as Profile).Skills = n.GetCollectionOfObjectValues<SkillProficiency>().ToList(); } },
                {"webAccounts", (o,n) => { (o as Profile).WebAccounts = n.GetCollectionOfObjectValues<WebAccount>().ToList(); } },
                {"websites", (o,n) => { (o as Profile).Websites = n.GetCollectionOfObjectValues<PersonWebsite>().ToList(); } },
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

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Contact : OutlookItem, IParsable {
        /// <summary>The name of the contact&apos;s assistant.</summary>
        public string AssistantName { get; set; }
        /// <summary>The contact&apos;s birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>The names of the contact&apos;s children.</summary>
        public List<string> Children { get; set; }
        /// <summary>The name of the contact&apos;s company.</summary>
        public string CompanyName { get; set; }
        /// <summary>The contact&apos;s department.</summary>
        public string Department { get; set; }
        /// <summary>The contact&apos;s display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
        public string DisplayName { get; set; }
        /// <summary>The contact&apos;s email addresses.</summary>
        public List<TypedEmailAddress> EmailAddresses { get; set; }
        /// <summary>The collection of open extensions defined for the contact. Read-only. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The name the contact is filed under.</summary>
        public string FileAs { get; set; }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the contact.</summary>
        public FollowupFlag Flag { get; set; }
        /// <summary>The contact&apos;s gender.</summary>
        public string Gender { get; set; }
        /// <summary>The contact&apos;s generation.</summary>
        public string Generation { get; set; }
        /// <summary>The contact&apos;s given name.</summary>
        public string GivenName { get; set; }
        /// <summary>The imAddresses property</summary>
        public List<string> ImAddresses { get; set; }
        /// <summary>The initials property</summary>
        public string Initials { get; set; }
        /// <summary>The isFavorite property</summary>
        public bool? IsFavorite { get; set; }
        /// <summary>The jobTitle property</summary>
        public string JobTitle { get; set; }
        /// <summary>The manager property</summary>
        public string Manager { get; set; }
        /// <summary>The middleName property</summary>
        public string MiddleName { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The nickName property</summary>
        public string NickName { get; set; }
        /// <summary>The officeLocation property</summary>
        public string OfficeLocation { get; set; }
        /// <summary>The parentFolderId property</summary>
        public string ParentFolderId { get; set; }
        /// <summary>The personalNotes property</summary>
        public string PersonalNotes { get; set; }
        /// <summary>The phones property</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
        public ProfilePhoto Photo { get; set; }
        /// <summary>The postalAddresses property</summary>
        public List<PhysicalAddress> PostalAddresses { get; set; }
        /// <summary>The profession property</summary>
        public string Profession { get; set; }
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The spouseName property</summary>
        public string SpouseName { get; set; }
        /// <summary>The surname property</summary>
        public string Surname { get; set; }
        /// <summary>The title property</summary>
        public string Title { get; set; }
        /// <summary>The websites property</summary>
        public List<Website> Websites { get; set; }
        /// <summary>The weddingAnniversary property</summary>
        public Date? WeddingAnniversary { get; set; }
        /// <summary>The yomiCompanyName property</summary>
        public string YomiCompanyName { get; set; }
        /// <summary>The yomiGivenName property</summary>
        public string YomiGivenName { get; set; }
        /// <summary>The yomiSurname property</summary>
        public string YomiSurname { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Contact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assistantName", (o,n) => { (o as Contact).AssistantName = n.GetStringValue(); } },
                {"birthday", (o,n) => { (o as Contact).Birthday = n.GetDateTimeOffsetValue(); } },
                {"children", (o,n) => { (o as Contact).Children = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"companyName", (o,n) => { (o as Contact).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Contact).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Contact).DisplayName = n.GetStringValue(); } },
                {"emailAddresses", (o,n) => { (o as Contact).EmailAddresses = n.GetCollectionOfObjectValues<TypedEmailAddress>(TypedEmailAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", (o,n) => { (o as Contact).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"fileAs", (o,n) => { (o as Contact).FileAs = n.GetStringValue(); } },
                {"flag", (o,n) => { (o as Contact).Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"gender", (o,n) => { (o as Contact).Gender = n.GetStringValue(); } },
                {"generation", (o,n) => { (o as Contact).Generation = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as Contact).GivenName = n.GetStringValue(); } },
                {"imAddresses", (o,n) => { (o as Contact).ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"initials", (o,n) => { (o as Contact).Initials = n.GetStringValue(); } },
                {"isFavorite", (o,n) => { (o as Contact).IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", (o,n) => { (o as Contact).JobTitle = n.GetStringValue(); } },
                {"manager", (o,n) => { (o as Contact).Manager = n.GetStringValue(); } },
                {"middleName", (o,n) => { (o as Contact).MiddleName = n.GetStringValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Contact).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"nickName", (o,n) => { (o as Contact).NickName = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as Contact).OfficeLocation = n.GetStringValue(); } },
                {"parentFolderId", (o,n) => { (o as Contact).ParentFolderId = n.GetStringValue(); } },
                {"personalNotes", (o,n) => { (o as Contact).PersonalNotes = n.GetStringValue(); } },
                {"phones", (o,n) => { (o as Contact).Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", (o,n) => { (o as Contact).Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"postalAddresses", (o,n) => { (o as Contact).PostalAddresses = n.GetCollectionOfObjectValues<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"profession", (o,n) => { (o as Contact).Profession = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Contact).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"spouseName", (o,n) => { (o as Contact).SpouseName = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as Contact).Surname = n.GetStringValue(); } },
                {"title", (o,n) => { (o as Contact).Title = n.GetStringValue(); } },
                {"websites", (o,n) => { (o as Contact).Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue).ToList(); } },
                {"weddingAnniversary", (o,n) => { (o as Contact).WeddingAnniversary = n.GetDateValue(); } },
                {"yomiCompanyName", (o,n) => { (o as Contact).YomiCompanyName = n.GetStringValue(); } },
                {"yomiGivenName", (o,n) => { (o as Contact).YomiGivenName = n.GetStringValue(); } },
                {"yomiSurname", (o,n) => { (o as Contact).YomiSurname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assistantName", AssistantName);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("children", Children);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<TypedEmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("fileAs", FileAs);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteStringValue("gender", Gender);
            writer.WriteStringValue("generation", Generation);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteStringValue("initials", Initials);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("manager", Manager);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("nickName", NickName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteStringValue("personalNotes", PersonalNotes);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<PhysicalAddress>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("spouseName", SpouseName);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteDateValue("weddingAnniversary", WeddingAnniversary);
            writer.WriteStringValue("yomiCompanyName", YomiCompanyName);
            writer.WriteStringValue("yomiGivenName", YomiGivenName);
            writer.WriteStringValue("yomiSurname", YomiSurname);
        }
    }
}

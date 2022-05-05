using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        /// <summary>The collection of open extensions defined for the contact. Nullable.</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assistantName", n => { AssistantName = n.GetStringValue(); } },
                {"birthday", n => { Birthday = n.GetDateTimeOffsetValue(); } },
                {"children", n => { Children = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"emailAddresses", n => { EmailAddresses = n.GetCollectionOfObjectValues<TypedEmailAddress>(TypedEmailAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"fileAs", n => { FileAs = n.GetStringValue(); } },
                {"flag", n => { Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"gender", n => { Gender = n.GetStringValue(); } },
                {"generation", n => { Generation = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"imAddresses", n => { ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"initials", n => { Initials = n.GetStringValue(); } },
                {"isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"manager", n => { Manager = n.GetStringValue(); } },
                {"middleName", n => { MiddleName = n.GetStringValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"nickName", n => { NickName = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"personalNotes", n => { PersonalNotes = n.GetStringValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"postalAddresses", n => { PostalAddresses = n.GetCollectionOfObjectValues<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"profession", n => { Profession = n.GetStringValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"spouseName", n => { SpouseName = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"websites", n => { Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue).ToList(); } },
                {"weddingAnniversary", n => { WeddingAnniversary = n.GetDateValue(); } },
                {"yomiCompanyName", n => { YomiCompanyName = n.GetStringValue(); } },
                {"yomiGivenName", n => { YomiGivenName = n.GetStringValue(); } },
                {"yomiSurname", n => { YomiSurname = n.GetStringValue(); } },
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

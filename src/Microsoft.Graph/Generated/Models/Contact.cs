using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class Contact : OutlookItem, IParsable {
        /// <summary>The name of the contact&apos;s assistant.</summary>
        public string AssistantName {
            get { return BackingStore?.Get<string>(nameof(AssistantName)); }
            set { BackingStore?.Set(nameof(AssistantName), value); }
        }
        /// <summary>The contact&apos;s birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(Birthday)); }
            set { BackingStore?.Set(nameof(Birthday), value); }
        }
        /// <summary>The names of the contact&apos;s children.</summary>
        public List<string> Children {
            get { return BackingStore?.Get<List<string>>(nameof(Children)); }
            set { BackingStore?.Set(nameof(Children), value); }
        }
        /// <summary>The name of the contact&apos;s company.</summary>
        public string CompanyName {
            get { return BackingStore?.Get<string>(nameof(CompanyName)); }
            set { BackingStore?.Set(nameof(CompanyName), value); }
        }
        /// <summary>The contact&apos;s department.</summary>
        public string Department {
            get { return BackingStore?.Get<string>(nameof(Department)); }
            set { BackingStore?.Set(nameof(Department), value); }
        }
        /// <summary>The contact&apos;s display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The contact&apos;s email addresses.</summary>
        public List<TypedEmailAddress> EmailAddresses {
            get { return BackingStore?.Get<List<TypedEmailAddress>>(nameof(EmailAddresses)); }
            set { BackingStore?.Set(nameof(EmailAddresses), value); }
        }
        /// <summary>The collection of open extensions defined for the contact. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>The name the contact is filed under.</summary>
        public string FileAs {
            get { return BackingStore?.Get<string>(nameof(FileAs)); }
            set { BackingStore?.Set(nameof(FileAs), value); }
        }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the contact.</summary>
        public FollowupFlag Flag {
            get { return BackingStore?.Get<FollowupFlag>(nameof(Flag)); }
            set { BackingStore?.Set(nameof(Flag), value); }
        }
        /// <summary>The contact&apos;s gender.</summary>
        public string Gender {
            get { return BackingStore?.Get<string>(nameof(Gender)); }
            set { BackingStore?.Set(nameof(Gender), value); }
        }
        /// <summary>The contact&apos;s generation.</summary>
        public string Generation {
            get { return BackingStore?.Get<string>(nameof(Generation)); }
            set { BackingStore?.Set(nameof(Generation), value); }
        }
        /// <summary>The contact&apos;s given name.</summary>
        public string GivenName {
            get { return BackingStore?.Get<string>(nameof(GivenName)); }
            set { BackingStore?.Set(nameof(GivenName), value); }
        }
        /// <summary>The imAddresses property</summary>
        public List<string> ImAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ImAddresses)); }
            set { BackingStore?.Set(nameof(ImAddresses), value); }
        }
        /// <summary>The initials property</summary>
        public string Initials {
            get { return BackingStore?.Get<string>(nameof(Initials)); }
            set { BackingStore?.Set(nameof(Initials), value); }
        }
        /// <summary>The isFavorite property</summary>
        public bool? IsFavorite {
            get { return BackingStore?.Get<bool?>(nameof(IsFavorite)); }
            set { BackingStore?.Set(nameof(IsFavorite), value); }
        }
        /// <summary>The jobTitle property</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>(nameof(JobTitle)); }
            set { BackingStore?.Set(nameof(JobTitle), value); }
        }
        /// <summary>The manager property</summary>
        public string Manager {
            get { return BackingStore?.Get<string>(nameof(Manager)); }
            set { BackingStore?.Set(nameof(Manager), value); }
        }
        /// <summary>The middleName property</summary>
        public string MiddleName {
            get { return BackingStore?.Get<string>(nameof(MiddleName)); }
            set { BackingStore?.Set(nameof(MiddleName), value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>(nameof(MultiValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(MultiValueExtendedProperties), value); }
        }
        /// <summary>The nickName property</summary>
        public string NickName {
            get { return BackingStore?.Get<string>(nameof(NickName)); }
            set { BackingStore?.Set(nameof(NickName), value); }
        }
        /// <summary>The officeLocation property</summary>
        public string OfficeLocation {
            get { return BackingStore?.Get<string>(nameof(OfficeLocation)); }
            set { BackingStore?.Set(nameof(OfficeLocation), value); }
        }
        /// <summary>The parentFolderId property</summary>
        public string ParentFolderId {
            get { return BackingStore?.Get<string>(nameof(ParentFolderId)); }
            set { BackingStore?.Set(nameof(ParentFolderId), value); }
        }
        /// <summary>The personalNotes property</summary>
        public string PersonalNotes {
            get { return BackingStore?.Get<string>(nameof(PersonalNotes)); }
            set { BackingStore?.Set(nameof(PersonalNotes), value); }
        }
        /// <summary>The phones property</summary>
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>(nameof(Phones)); }
            set { BackingStore?.Set(nameof(Phones), value); }
        }
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>(nameof(Photo)); }
            set { BackingStore?.Set(nameof(Photo), value); }
        }
        /// <summary>The postalAddresses property</summary>
        public List<PhysicalAddress> PostalAddresses {
            get { return BackingStore?.Get<List<PhysicalAddress>>(nameof(PostalAddresses)); }
            set { BackingStore?.Set(nameof(PostalAddresses), value); }
        }
        /// <summary>The profession property</summary>
        public string Profession {
            get { return BackingStore?.Get<string>(nameof(Profession)); }
            set { BackingStore?.Set(nameof(Profession), value); }
        }
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>(nameof(SingleValueExtendedProperties)); }
            set { BackingStore?.Set(nameof(SingleValueExtendedProperties), value); }
        }
        /// <summary>The spouseName property</summary>
        public string SpouseName {
            get { return BackingStore?.Get<string>(nameof(SpouseName)); }
            set { BackingStore?.Set(nameof(SpouseName), value); }
        }
        /// <summary>The surname property</summary>
        public string Surname {
            get { return BackingStore?.Get<string>(nameof(Surname)); }
            set { BackingStore?.Set(nameof(Surname), value); }
        }
        /// <summary>The title property</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>The websites property</summary>
        public List<Website> Websites {
            get { return BackingStore?.Get<List<Website>>(nameof(Websites)); }
            set { BackingStore?.Set(nameof(Websites), value); }
        }
        /// <summary>The weddingAnniversary property</summary>
        public Date? WeddingAnniversary {
            get { return BackingStore?.Get<Date?>(nameof(WeddingAnniversary)); }
            set { BackingStore?.Set(nameof(WeddingAnniversary), value); }
        }
        /// <summary>The yomiCompanyName property</summary>
        public string YomiCompanyName {
            get { return BackingStore?.Get<string>(nameof(YomiCompanyName)); }
            set { BackingStore?.Set(nameof(YomiCompanyName), value); }
        }
        /// <summary>The yomiGivenName property</summary>
        public string YomiGivenName {
            get { return BackingStore?.Get<string>(nameof(YomiGivenName)); }
            set { BackingStore?.Set(nameof(YomiGivenName), value); }
        }
        /// <summary>The yomiSurname property</summary>
        public string YomiSurname {
            get { return BackingStore?.Get<string>(nameof(YomiSurname)); }
            set { BackingStore?.Set(nameof(YomiSurname), value); }
        }
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

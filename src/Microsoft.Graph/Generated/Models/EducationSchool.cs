using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSchool : EducationOrganization, IParsable {
        /// <summary>Address of the school.</summary>
        public PhysicalAddress Address {
            get { return BackingStore?.Get<PhysicalAddress>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>The underlying administrativeUnit for this school.</summary>
        public Microsoft.Graph.Beta.Models.AdministrativeUnit AdministrativeUnit {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdministrativeUnit>(nameof(AdministrativeUnit)); }
            set { BackingStore?.Set(nameof(AdministrativeUnit), value); }
        }
        /// <summary>Classes taught at the school. Nullable.</summary>
        public List<EducationClass> Classes {
            get { return BackingStore?.Get<List<EducationClass>>(nameof(Classes)); }
            set { BackingStore?.Set(nameof(Classes), value); }
        }
        /// <summary>Entity who created the school.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>ID of school in syncing system.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>(nameof(ExternalId)); }
            set { BackingStore?.Set(nameof(ExternalId), value); }
        }
        /// <summary>ID of principal in syncing system.</summary>
        public string ExternalPrincipalId {
            get { return BackingStore?.Get<string>(nameof(ExternalPrincipalId)); }
            set { BackingStore?.Set(nameof(ExternalPrincipalId), value); }
        }
        /// <summary>The fax property</summary>
        public string Fax {
            get { return BackingStore?.Get<string>(nameof(Fax)); }
            set { BackingStore?.Set(nameof(Fax), value); }
        }
        /// <summary>Highest grade taught.</summary>
        public string HighestGrade {
            get { return BackingStore?.Get<string>(nameof(HighestGrade)); }
            set { BackingStore?.Set(nameof(HighestGrade), value); }
        }
        /// <summary>Lowest grade taught.</summary>
        public string LowestGrade {
            get { return BackingStore?.Get<string>(nameof(LowestGrade)); }
            set { BackingStore?.Set(nameof(LowestGrade), value); }
        }
        /// <summary>Phone number of school.</summary>
        public string Phone {
            get { return BackingStore?.Get<string>(nameof(Phone)); }
            set { BackingStore?.Set(nameof(Phone), value); }
        }
        /// <summary>Email address of the principal.</summary>
        public string PrincipalEmail {
            get { return BackingStore?.Get<string>(nameof(PrincipalEmail)); }
            set { BackingStore?.Set(nameof(PrincipalEmail), value); }
        }
        /// <summary>Name of the principal.</summary>
        public string PrincipalName {
            get { return BackingStore?.Get<string>(nameof(PrincipalName)); }
            set { BackingStore?.Set(nameof(PrincipalName), value); }
        }
        /// <summary>School Number.</summary>
        public string SchoolNumber {
            get { return BackingStore?.Get<string>(nameof(SchoolNumber)); }
            set { BackingStore?.Set(nameof(SchoolNumber), value); }
        }
        /// <summary>Users in the school. Nullable.</summary>
        public List<EducationUser> Users {
            get { return BackingStore?.Get<List<EducationUser>>(nameof(Users)); }
            set { BackingStore?.Set(nameof(Users), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSchool CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSchool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"administrativeUnit", n => { AdministrativeUnit = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdministrativeUnit>(Microsoft.Graph.Beta.Models.AdministrativeUnit.CreateFromDiscriminatorValue); } },
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"externalPrincipalId", n => { ExternalPrincipalId = n.GetStringValue(); } },
                {"fax", n => { Fax = n.GetStringValue(); } },
                {"highestGrade", n => { HighestGrade = n.GetStringValue(); } },
                {"lowestGrade", n => { LowestGrade = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"principalEmail", n => { PrincipalEmail = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"schoolNumber", n => { SchoolNumber = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdministrativeUnit>("administrativeUnit", AdministrativeUnit);
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalPrincipalId", ExternalPrincipalId);
            writer.WriteStringValue("fax", Fax);
            writer.WriteStringValue("highestGrade", HighestGrade);
            writer.WriteStringValue("lowestGrade", LowestGrade);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("principalEmail", PrincipalEmail);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("schoolNumber", SchoolNumber);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
        }
    }
}

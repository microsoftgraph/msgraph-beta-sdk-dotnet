using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of activityStatistics entities.
    /// </summary>
    public class Employee : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address {
            get { return BackingStore?.Get<PostalAddressType>("address"); }
            set { BackingStore?.Set("address", value); }
        }
        /// <summary>The birthDate property</summary>
        public Date? BirthDate {
            get { return BackingStore?.Get<Date?>("birthDate"); }
            set { BackingStore?.Set("birthDate", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The email property</summary>
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
        /// <summary>The employmentDate property</summary>
        public Date? EmploymentDate {
            get { return BackingStore?.Get<Date?>("employmentDate"); }
            set { BackingStore?.Set("employmentDate", value); }
        }
        /// <summary>The givenName property</summary>
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
        /// <summary>The jobTitle property</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The middleName property</summary>
        public string MiddleName {
            get { return BackingStore?.Get<string>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
        /// <summary>The mobilePhone property</summary>
        public string MobilePhone {
            get { return BackingStore?.Get<string>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
        /// <summary>The personalEmail property</summary>
        public string PersonalEmail {
            get { return BackingStore?.Get<string>("personalEmail"); }
            set { BackingStore?.Set("personalEmail", value); }
        }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
        /// <summary>The statisticsGroupCode property</summary>
        public string StatisticsGroupCode {
            get { return BackingStore?.Get<string>("statisticsGroupCode"); }
            set { BackingStore?.Set("statisticsGroupCode", value); }
        }
        /// <summary>The status property</summary>
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The surname property</summary>
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
        /// <summary>The terminationDate property</summary>
        public Date? TerminationDate {
            get { return BackingStore?.Get<Date?>("terminationDate"); }
            set { BackingStore?.Set("terminationDate", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Employee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Employee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"birthDate", n => { BirthDate = n.GetDateValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"employmentDate", n => { EmploymentDate = n.GetDateValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"middleName", n => { MiddleName = n.GetStringValue(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"personalEmail", n => { PersonalEmail = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"statisticsGroupCode", n => { StatisticsGroupCode = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"terminationDate", n => { TerminationDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteDateValue("birthDate", BirthDate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteDateValue("employmentDate", EmploymentDate);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("personalEmail", PersonalEmail);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteStringValue("statisticsGroupCode", StatisticsGroupCode);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("surname", Surname);
            writer.WriteDateValue("terminationDate", TerminationDate);
        }
    }
}

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Employee : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address { get; set; }
        /// <summary>The birthDate property</summary>
        public Date? BirthDate { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The employmentDate property</summary>
        public Date? EmploymentDate { get; set; }
        /// <summary>The givenName property</summary>
        public string GivenName { get; set; }
        /// <summary>The jobTitle property</summary>
        public string JobTitle { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The middleName property</summary>
        public string MiddleName { get; set; }
        /// <summary>The mobilePhone property</summary>
        public string MobilePhone { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The personalEmail property</summary>
        public string PersonalEmail { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The picture property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture> Picture { get; set; }
        /// <summary>The statisticsGroupCode property</summary>
        public string StatisticsGroupCode { get; set; }
        /// <summary>The status property</summary>
        public string Status { get; set; }
        /// <summary>The surname property</summary>
        public string Surname { get; set; }
        /// <summary>The terminationDate property</summary>
        public Date? TerminationDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Employee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Employee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as Employee).Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"birthDate", (o,n) => { (o as Employee).BirthDate = n.GetDateValue(); } },
                {"displayName", (o,n) => { (o as Employee).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as Employee).Email = n.GetStringValue(); } },
                {"employmentDate", (o,n) => { (o as Employee).EmploymentDate = n.GetDateValue(); } },
                {"givenName", (o,n) => { (o as Employee).GivenName = n.GetStringValue(); } },
                {"jobTitle", (o,n) => { (o as Employee).JobTitle = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Employee).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"middleName", (o,n) => { (o as Employee).MiddleName = n.GetStringValue(); } },
                {"mobilePhone", (o,n) => { (o as Employee).MobilePhone = n.GetStringValue(); } },
                {"number", (o,n) => { (o as Employee).Number = n.GetStringValue(); } },
                {"personalEmail", (o,n) => { (o as Employee).PersonalEmail = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as Employee).PhoneNumber = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as Employee).Picture = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>(MicrosoftGraphSdk.Models.Microsoft.Graph.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"statisticsGroupCode", (o,n) => { (o as Employee).StatisticsGroupCode = n.GetStringValue(); } },
                {"status", (o,n) => { (o as Employee).Status = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as Employee).Surname = n.GetStringValue(); } },
                {"terminationDate", (o,n) => { (o as Employee).TerminationDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>("picture", Picture);
            writer.WriteStringValue("statisticsGroupCode", StatisticsGroupCode);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("surname", Surname);
            writer.WriteDateValue("terminationDate", TerminationDate);
        }
    }
}

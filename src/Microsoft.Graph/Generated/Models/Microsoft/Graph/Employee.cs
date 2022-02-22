using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Employee : Entity, IParsable {
        public PostalAddressType Address { get; set; }
        public Date? BirthDate { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public Date? EmploymentDate { get; set; }
        public string GivenName { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Number { get; set; }
        public string PersonalEmail { get; set; }
        public string PhoneNumber { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.Picture> Picture { get; set; }
        public string StatisticsGroupCode { get; set; }
        public string Status { get; set; }
        public string Surname { get; set; }
        public Date? TerminationDate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as Employee).Address = n.GetObjectValue<PostalAddressType>(); } },
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
                {"picture", (o,n) => { (o as Employee).Picture = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Picture>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Picture>("picture", Picture);
            writer.WriteStringValue("statisticsGroupCode", StatisticsGroupCode);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("surname", Surname);
            writer.WriteDateValue("terminationDate", TerminationDate);
        }
    }
}

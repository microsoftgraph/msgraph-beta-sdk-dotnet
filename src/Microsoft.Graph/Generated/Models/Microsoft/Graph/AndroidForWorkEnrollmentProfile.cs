using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AndroidForWorkEnrollmentProfile : Entity, IParsable {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
        public string AccountId { get; set; }
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description for the enrollment profile.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the enrollment profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
        public string QrCodeContent { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
        public MimeContent QrCodeImage { get; set; }
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
        public string TokenValue { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountId", (o,n) => { (o as AndroidForWorkEnrollmentProfile).AccountId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AndroidForWorkEnrollmentProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AndroidForWorkEnrollmentProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AndroidForWorkEnrollmentProfile).DisplayName = n.GetStringValue(); } },
                {"enrolledDeviceCount", (o,n) => { (o as AndroidForWorkEnrollmentProfile).EnrolledDeviceCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AndroidForWorkEnrollmentProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"qrCodeContent", (o,n) => { (o as AndroidForWorkEnrollmentProfile).QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", (o,n) => { (o as AndroidForWorkEnrollmentProfile).QrCodeImage = n.GetObjectValue<MimeContent>(); } },
                {"tokenExpirationDateTime", (o,n) => { (o as AndroidForWorkEnrollmentProfile).TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenValue", (o,n) => { (o as AndroidForWorkEnrollmentProfile).TokenValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenValue", TokenValue);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DataSharingConsent : Entity, IParsable {
        /// <summary>The time consent was granted for this account</summary>
        public DateTimeOffset? GrantDateTime { get; set; }
        /// <summary>The granted state for the data sharing consent</summary>
        public bool? Granted { get; set; }
        /// <summary>The Upn of the user that granted consent for this account</summary>
        public string GrantedByUpn { get; set; }
        /// <summary>The UserId of the user that granted consent for this account</summary>
        public string GrantedByUserId { get; set; }
        /// <summary>The display name of the service work flow</summary>
        public string ServiceDisplayName { get; set; }
        /// <summary>The TermsUrl for the data sharing consent</summary>
        public string TermsUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataSharingConsent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataSharingConsent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"grantDateTime", (o,n) => { (o as DataSharingConsent).GrantDateTime = n.GetDateTimeOffsetValue(); } },
                {"granted", (o,n) => { (o as DataSharingConsent).Granted = n.GetBoolValue(); } },
                {"grantedByUpn", (o,n) => { (o as DataSharingConsent).GrantedByUpn = n.GetStringValue(); } },
                {"grantedByUserId", (o,n) => { (o as DataSharingConsent).GrantedByUserId = n.GetStringValue(); } },
                {"serviceDisplayName", (o,n) => { (o as DataSharingConsent).ServiceDisplayName = n.GetStringValue(); } },
                {"termsUrl", (o,n) => { (o as DataSharingConsent).TermsUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("grantDateTime", GrantDateTime);
            writer.WriteBoolValue("granted", Granted);
            writer.WriteStringValue("grantedByUpn", GrantedByUpn);
            writer.WriteStringValue("grantedByUserId", GrantedByUserId);
            writer.WriteStringValue("serviceDisplayName", ServiceDisplayName);
            writer.WriteStringValue("termsUrl", TermsUrl);
        }
    }
}

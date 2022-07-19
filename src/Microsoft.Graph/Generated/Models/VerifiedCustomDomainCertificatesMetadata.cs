using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class VerifiedCustomDomainCertificatesMetadata : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpiryDate {
            get { return BackingStore?.Get<DateTimeOffset?>("expiryDate"); }
            set { BackingStore?.Set("expiryDate", value); }
        }
        /// <summary>The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? IssueDate {
            get { return BackingStore?.Get<DateTimeOffset?>("issueDate"); }
            set { BackingStore?.Set("issueDate", value); }
        }
        /// <summary>The issuer name of the custom domain certificate.</summary>
        public string IssuerName {
            get { return BackingStore?.Get<string>("issuerName"); }
            set { BackingStore?.Set("issuerName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The subject name of the custom domain certificate.</summary>
        public string SubjectName {
            get { return BackingStore?.Get<string>("subjectName"); }
            set { BackingStore?.Set("subjectName", value); }
        }
        /// <summary>The thumbprint associated with the custom domain certificate.</summary>
        public string Thumbprint {
            get { return BackingStore?.Get<string>("thumbprint"); }
            set { BackingStore?.Set("thumbprint", value); }
        }
        /// <summary>
        /// Instantiates a new verifiedCustomDomainCertificatesMetadata and sets the default values.
        /// </summary>
        public VerifiedCustomDomainCertificatesMetadata() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.verifiedCustomDomainCertificatesMetadata";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VerifiedCustomDomainCertificatesMetadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiedCustomDomainCertificatesMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expiryDate", n => { ExpiryDate = n.GetDateTimeOffsetValue(); } },
                {"issueDate", n => { IssueDate = n.GetDateTimeOffsetValue(); } },
                {"issuerName", n => { IssuerName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"subjectName", n => { SubjectName = n.GetStringValue(); } },
                {"thumbprint", n => { Thumbprint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiryDate", ExpiryDate);
            writer.WriteDateTimeOffsetValue("issueDate", IssueDate);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

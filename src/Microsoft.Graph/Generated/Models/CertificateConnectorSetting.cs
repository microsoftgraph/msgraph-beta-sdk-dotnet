using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Certificate connector settings.</summary>
    public class CertificateConnectorSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Certificate expire time</summary>
        public DateTimeOffset? CertExpiryTime { get; set; }
        /// <summary>Version of certificate connector</summary>
        public string ConnectorVersion { get; set; }
        /// <summary>Certificate connector enrollment error</summary>
        public string EnrollmentError { get; set; }
        /// <summary>Last time certificate connector connected</summary>
        public DateTimeOffset? LastConnectorConnectionTime { get; set; }
        /// <summary>Version of last uploaded certificate connector</summary>
        public long? LastUploadVersion { get; set; }
        /// <summary>Certificate connector status</summary>
        public int? Status { get; set; }
        /// <summary>
        /// Instantiates a new certificateConnectorSetting and sets the default values.
        /// </summary>
        public CertificateConnectorSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CertificateConnectorSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certExpiryTime", n => { CertExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"connectorVersion", n => { ConnectorVersion = n.GetStringValue(); } },
                {"enrollmentError", n => { EnrollmentError = n.GetStringValue(); } },
                {"lastConnectorConnectionTime", n => { LastConnectorConnectionTime = n.GetDateTimeOffsetValue(); } },
                {"lastUploadVersion", n => { LastUploadVersion = n.GetLongValue(); } },
                {"status", n => { Status = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("certExpiryTime", CertExpiryTime);
            writer.WriteStringValue("connectorVersion", ConnectorVersion);
            writer.WriteStringValue("enrollmentError", EnrollmentError);
            writer.WriteDateTimeOffsetValue("lastConnectorConnectionTime", LastConnectorConnectionTime);
            writer.WriteLongValue("lastUploadVersion", LastUploadVersion);
            writer.WriteIntValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

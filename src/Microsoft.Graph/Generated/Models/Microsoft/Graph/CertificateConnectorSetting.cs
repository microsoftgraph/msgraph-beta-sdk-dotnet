using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CertificateConnectorSetting : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certExpiryTime", (o,n) => { (o as CertificateConnectorSetting).CertExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"connectorVersion", (o,n) => { (o as CertificateConnectorSetting).ConnectorVersion = n.GetStringValue(); } },
                {"enrollmentError", (o,n) => { (o as CertificateConnectorSetting).EnrollmentError = n.GetStringValue(); } },
                {"lastConnectorConnectionTime", (o,n) => { (o as CertificateConnectorSetting).LastConnectorConnectionTime = n.GetDateTimeOffsetValue(); } },
                {"lastUploadVersion", (o,n) => { (o as CertificateConnectorSetting).LastUploadVersion = n.GetLongValue(); } },
                {"status", (o,n) => { (o as CertificateConnectorSetting).Status = n.GetIntValue(); } },
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

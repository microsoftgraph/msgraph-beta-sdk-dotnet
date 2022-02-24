using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AndroidEnrollmentCompanyCode : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enrollment Token used by the User to enroll their device.</summary>
        public string EnrollmentToken { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
        public string QrCodeContent { get; set; }
        /// <summary>Generated QR code for the token.</summary>
        public MimeContent QrCodeImage { get; set; }
        /// <summary>
        /// Instantiates a new androidEnrollmentCompanyCode and sets the default values.
        /// </summary>
        public AndroidEnrollmentCompanyCode() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enrollmentToken", (o,n) => { (o as AndroidEnrollmentCompanyCode).EnrollmentToken = n.GetStringValue(); } },
                {"qrCodeContent", (o,n) => { (o as AndroidEnrollmentCompanyCode).QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", (o,n) => { (o as AndroidEnrollmentCompanyCode).QrCodeImage = n.GetObjectValue<MimeContent>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("enrollmentToken", EnrollmentToken);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

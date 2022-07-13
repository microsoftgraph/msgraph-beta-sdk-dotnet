using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class to hold specialty enrollment data used for enrolling via Google&apos;s Android Management API, such as Token, Url, and QR code content</summary>
    public class AndroidEnrollmentCompanyCode : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Enrollment Token used by the User to enroll their device.</summary>
        public string EnrollmentToken {
            get { return BackingStore?.Get<string>("enrollmentToken"); }
            set { BackingStore?.Set("enrollmentToken", value); }
        }
        /// <summary>String used to generate a QR code for the token.</summary>
        public string QrCodeContent {
            get { return BackingStore?.Get<string>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
        /// <summary>Generated QR code for the token.</summary>
        public MimeContent QrCodeImage {
            get { return BackingStore?.Get<MimeContent>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
        /// <summary>
        /// Instantiates a new androidEnrollmentCompanyCode and sets the default values.
        /// </summary>
        public AndroidEnrollmentCompanyCode() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AndroidEnrollmentCompanyCode CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidEnrollmentCompanyCode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"enrollmentToken", n => { EnrollmentToken = n.GetStringValue(); } },
                {"qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", n => { QrCodeImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
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

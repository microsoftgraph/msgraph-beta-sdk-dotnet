using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A class to hold specialty enrollment data used for enrolling via Google&apos;s Android Management API, such as Token, Url, and QR code content
    /// </summary>
    public class AndroidEnrollmentCompanyCode : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Enrollment Token used by the User to enroll their device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentToken {
            get { return BackingStore?.Get<string?>("enrollmentToken"); }
            set { BackingStore?.Set("enrollmentToken", value); }
        }
#nullable restore
#else
        public string EnrollmentToken {
            get { return BackingStore?.Get<string>("enrollmentToken"); }
            set { BackingStore?.Set("enrollmentToken", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QrCodeContent {
            get { return BackingStore?.Get<string?>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#nullable restore
#else
        public string QrCodeContent {
            get { return BackingStore?.Get<string>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#endif
        /// <summary>Generated QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? QrCodeImage {
            get { return BackingStore?.Get<MimeContent?>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#nullable restore
#else
        public MimeContent QrCodeImage {
            get { return BackingStore?.Get<MimeContent>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidEnrollmentCompanyCode and sets the default values.
        /// </summary>
        public AndroidEnrollmentCompanyCode() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", n => { QrCodeImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("enrollmentToken", EnrollmentToken);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the logo&apos;s binary content or a url to the logo&apos;s downloadable location. Either both logo and contentType contain valid values or logoCdnUrl contains a valid url</summary>
    public class OrganizationalMessageLogo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The content type of the logo that is contained in the logo array. This is null when logoCdnUrl is used to send the logo. Possible values are: png.</summary>
        public OrganizationalMessageLogoType? ContentType {
            get { return BackingStore?.Get<OrganizationalMessageLogoType?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
        /// <summary>The binary contents of the logo. This is null when logoCdnUrl is used to send the logo</summary>
        public byte[] Logo {
            get { return BackingStore?.Get<byte[]>("logo"); }
            set { BackingStore?.Set("logo", value); }
        }
        /// <summary>The url at which the logo resides. This is null when logo and contentType are used to send the logo</summary>
        public string LogoCdnUrl {
            get { return BackingStore?.Get<string>("logoCdnUrl"); }
            set { BackingStore?.Set("logoCdnUrl", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageLogo and sets the default values.
        /// </summary>
        public OrganizationalMessageLogo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageLogo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageLogo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageLogo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentType", n => { ContentType = n.GetEnumValue<OrganizationalMessageLogoType>(); } },
                {"logo", n => { Logo = n.GetByteArrayValue(); } },
                {"logoCdnUrl", n => { LogoCdnUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<OrganizationalMessageLogoType>("contentType", ContentType);
            writer.WriteByteArrayValue("logo", Logo);
            writer.WriteStringValue("logoCdnUrl", LogoCdnUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

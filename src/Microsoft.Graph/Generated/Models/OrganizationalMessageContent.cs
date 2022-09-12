using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the entire content of the message that will be displayed to the clients</summary>
    public class OrganizationalMessageContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ID of the guided content that this content is using</summary>
        public string GuidedContentId {
            get { return BackingStore?.Get<string>("guidedContentId"); }
            set { BackingStore?.Set("guidedContentId", value); }
        }
        /// <summary>The logo that will be displayed to the clients. This will contain ether the binary contents of the logo or a url to the logo&apos;s location</summary>
        public OrganizationalMessageLogo LogoInfo {
            get { return BackingStore?.Get<OrganizationalMessageLogo>("logoInfo"); }
            set { BackingStore?.Set("logoInfo", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Contains the different types of text content that can be displayed to customers along with their localized values</summary>
        public List<OrganizationalMessagePlacementDetail> PlacementDetails {
            get { return BackingStore?.Get<List<OrganizationalMessagePlacementDetail>>("placementDetails"); }
            set { BackingStore?.Set("placementDetails", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageContent and sets the default values.
        /// </summary>
        public OrganizationalMessageContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"guidedContentId", n => { GuidedContentId = n.GetStringValue(); } },
                {"logoInfo", n => { LogoInfo = n.GetObjectValue<OrganizationalMessageLogo>(OrganizationalMessageLogo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"placementDetails", n => { PlacementDetails = n.GetCollectionOfObjectValues<OrganizationalMessagePlacementDetail>(OrganizationalMessagePlacementDetail.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("guidedContentId", GuidedContentId);
            writer.WriteObjectValue<OrganizationalMessageLogo>("logoInfo", LogoInfo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<OrganizationalMessagePlacementDetail>("placementDetails", PlacementDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

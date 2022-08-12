using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the different variants of text that can be displayed for a given placement within a surface</summary>
    public class OrganizationalMessagePlacementDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Indicates the name of the placement. Possible values are: default, card0, card1, card2, card3.</summary>
        public OrganizationalMessagePlacement? Placement {
            get { return BackingStore?.Get<OrganizationalMessagePlacement?>("placement"); }
            set { BackingStore?.Set("placement", value); }
        }
        /// <summary>The list of different variants that can be displayed for this placement</summary>
        public List<OrganizationalMessageVariant> Variants {
            get { return BackingStore?.Get<List<OrganizationalMessageVariant>>("variants"); }
            set { BackingStore?.Set("variants", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessagePlacementDetail and sets the default values.
        /// </summary>
        public OrganizationalMessagePlacementDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessagePlacementDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessagePlacementDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessagePlacementDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"placement", n => { Placement = n.GetEnumValue<OrganizationalMessagePlacement>(); } },
                {"variants", n => { Variants = n.GetCollectionOfObjectValues<OrganizationalMessageVariant>(OrganizationalMessageVariant.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OrganizationalMessagePlacement>("placement", Placement);
            writer.WriteCollectionOfObjectValues<OrganizationalMessageVariant>("variants", Variants);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

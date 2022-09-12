using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationLicenseAssignment : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The user role type to assign to license. Possible values are: student, teacher, faculty.</summary>
        public EducationUserRole? AppliesTo {
            get { return BackingStore?.Get<EducationUserRole?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Represents the SKU identifiers of the licenses to assign.</summary>
        public List<string> SkuIds {
            get { return BackingStore?.Get<List<string>>("skuIds"); }
            set { BackingStore?.Set("skuIds", value); }
        }
        /// <summary>
        /// Instantiates a new educationSynchronizationLicenseAssignment and sets the default values.
        /// </summary>
        public EducationSynchronizationLicenseAssignment() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.educationSynchronizationLicenseAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationSynchronizationLicenseAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationLicenseAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appliesTo", n => { AppliesTo = n.GetEnumValue<EducationUserRole>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skuIds", n => { SkuIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EducationUserRole>("appliesTo", AppliesTo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("skuIds", SkuIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

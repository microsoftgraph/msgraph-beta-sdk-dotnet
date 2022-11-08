using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAnswerChoice : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The actual value of the selected choice. This is typically a string value which is understandable by applications. Required.</summary>
        public string ActualValue {
            get { return BackingStore?.Get<string>("actualValue"); }
            set { BackingStore?.Set("actualValue", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The localized display values shown to the requestor and approvers. Required.</summary>
        public AccessPackageLocalizedContent DisplayValue {
            get { return BackingStore?.Get<AccessPackageLocalizedContent>("displayValue"); }
            set { BackingStore?.Set("displayValue", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageAnswerChoice and sets the default values.
        /// </summary>
        public AccessPackageAnswerChoice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.accessPackageAnswerChoice";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageAnswerChoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAnswerChoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actualValue", n => { ActualValue = n.GetStringValue(); } },
                {"displayValue", n => { DisplayValue = n.GetObjectValue<AccessPackageLocalizedContent>(AccessPackageLocalizedContent.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actualValue", ActualValue);
            writer.WriteObjectValue<AccessPackageLocalizedContent>("displayValue", DisplayValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

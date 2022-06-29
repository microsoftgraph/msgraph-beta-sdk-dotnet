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
            get { return BackingStore?.Get<string>(nameof(ActualValue)); }
            set { BackingStore?.Set(nameof(ActualValue), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The localized display values shown to the requestor and approvers. Required.</summary>
        public AccessPackageLocalizedContent DisplayValue {
            get { return BackingStore?.Get<AccessPackageLocalizedContent>(nameof(DisplayValue)); }
            set { BackingStore?.Set(nameof(DisplayValue), value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageAnswerChoice and sets the default values.
        /// </summary>
        public AccessPackageAnswerChoice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actualValue", ActualValue);
            writer.WriteObjectValue<AccessPackageLocalizedContent>("displayValue", DisplayValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

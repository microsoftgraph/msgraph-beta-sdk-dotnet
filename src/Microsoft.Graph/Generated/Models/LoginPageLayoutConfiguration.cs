using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LoginPageLayoutConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Option to show the footer on the sign-in page.</summary>
        public bool? IsFooterShown {
            get { return BackingStore?.Get<bool?>("isFooterShown"); }
            set { BackingStore?.Set("isFooterShown", value); }
        }
        /// <summary>Option to show the header on the sign-in page.</summary>
        public bool? IsHeaderShown {
            get { return BackingStore?.Get<bool?>("isHeaderShown"); }
            set { BackingStore?.Set("isHeaderShown", value); }
        }
        /// <summary>Represents the layout template to be displayed on the login page for a tenant. The possible values are  default - Represents the default Microsoft layout with a centered lightbox.  verticalSplit - Represents a layout with a backgound on the left side and a full-height lightbox to the right.  unknownFutureValue - Evolvable enumeration sentinel value. Do not use.</summary>
        public Microsoft.Graph.Beta.Models.LayoutTemplateType? LayoutTemplateType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LayoutTemplateType?>("layoutTemplateType"); }
            set { BackingStore?.Set("layoutTemplateType", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new loginPageLayoutConfiguration and sets the default values.
        /// </summary>
        public LoginPageLayoutConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LoginPageLayoutConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginPageLayoutConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isFooterShown", n => { IsFooterShown = n.GetBoolValue(); } },
                {"isHeaderShown", n => { IsHeaderShown = n.GetBoolValue(); } },
                {"layoutTemplateType", n => { LayoutTemplateType = n.GetEnumValue<LayoutTemplateType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isFooterShown", IsFooterShown);
            writer.WriteBoolValue("isHeaderShown", IsHeaderShown);
            writer.WriteEnumValue<LayoutTemplateType>("layoutTemplateType", LayoutTemplateType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

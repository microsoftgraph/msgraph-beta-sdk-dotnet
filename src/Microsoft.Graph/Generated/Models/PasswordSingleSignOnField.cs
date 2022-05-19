using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PasswordSingleSignOnField : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Title/label override for customization.</summary>
        public string CustomizedLabel {
            get { return BackingStore?.Get<string>(nameof(CustomizedLabel)); }
            set { BackingStore?.Set(nameof(CustomizedLabel), value); }
        }
        /// <summary>Label that would be used if no customizedLabel is provided. Read only.</summary>
        public string DefaultLabel {
            get { return BackingStore?.Get<string>(nameof(DefaultLabel)); }
            set { BackingStore?.Set(nameof(DefaultLabel), value); }
        }
        /// <summary>Id used to identity the field type. This is an internal id and possible values are param_1, param_2, param_userName, param_password.</summary>
        public string FieldId {
            get { return BackingStore?.Get<string>(nameof(FieldId)); }
            set { BackingStore?.Set(nameof(FieldId), value); }
        }
        /// <summary>Type of the credential. The values can be text, password.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Instantiates a new passwordSingleSignOnField and sets the default values.
        /// </summary>
        public PasswordSingleSignOnField() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PasswordSingleSignOnField CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordSingleSignOnField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"customizedLabel", n => { CustomizedLabel = n.GetStringValue(); } },
                {"defaultLabel", n => { DefaultLabel = n.GetStringValue(); } },
                {"fieldId", n => { FieldId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customizedLabel", CustomizedLabel);
            writer.WriteStringValue("defaultLabel", DefaultLabel);
            writer.WriteStringValue("fieldId", FieldId);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

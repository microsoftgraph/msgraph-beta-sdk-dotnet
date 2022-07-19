using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class Setting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name for the setting. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The value for the setting serialized as string of JSON. Required. Read-only.</summary>
        public string JsonValue {
            get { return BackingStore?.Get<string>("jsonValue"); }
            set { BackingStore?.Set("jsonValue", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>A flag indicating whether the setting can be override existing configurations when applied. Required. Read-only.</summary>
        public bool? OverwriteAllowed {
            get { return BackingStore?.Get<bool?>("overwriteAllowed"); }
            set { BackingStore?.Set("overwriteAllowed", value); }
        }
        /// <summary>The settingId property</summary>
        public string SettingId {
            get { return BackingStore?.Get<string>("settingId"); }
            set { BackingStore?.Set("settingId", value); }
        }
        /// <summary>The valueType property</summary>
        public ManagementParameterValueType? ValueType {
            get { return BackingStore?.Get<ManagementParameterValueType?>("valueType"); }
            set { BackingStore?.Set("valueType", value); }
        }
        /// <summary>
        /// Instantiates a new setting and sets the default values.
        /// </summary>
        public Setting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.setting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Setting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Setting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"jsonValue", n => { JsonValue = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"overwriteAllowed", n => { OverwriteAllowed = n.GetBoolValue(); } },
                {"settingId", n => { SettingId = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<ManagementParameterValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("jsonValue", JsonValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("overwriteAllowed", OverwriteAllowed);
            writer.WriteStringValue("settingId", SettingId);
            writer.WriteEnumValue<ManagementParameterValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

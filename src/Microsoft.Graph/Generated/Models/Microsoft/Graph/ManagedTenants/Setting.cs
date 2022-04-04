using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class Setting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name for the setting. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The value for the setting serialized as string of JSON. Required. Read-only.</summary>
        public string JsonValue { get; set; }
        /// <summary>A flag indicating whether the setting can be override existing configurations when applied. Required. Read-only.</summary>
        public bool? OverwriteAllowed { get; set; }
        /// <summary>The settingId property</summary>
        public string SettingId { get; set; }
        /// <summary>The data type for the setting. Possible values are: string, integer, boolean, guid, stringCollection, integerCollection, booleanCollection, guidCollection, unknownFutureValue. Required. Read-only.</summary>
        public ManagementParameterValueType? ValueType { get; set; }
        /// <summary>
        /// Instantiates a new setting and sets the default values.
        /// </summary>
        public Setting() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as Setting).DisplayName = n.GetStringValue(); } },
                {"jsonValue", (o,n) => { (o as Setting).JsonValue = n.GetStringValue(); } },
                {"overwriteAllowed", (o,n) => { (o as Setting).OverwriteAllowed = n.GetBoolValue(); } },
                {"settingId", (o,n) => { (o as Setting).SettingId = n.GetStringValue(); } },
                {"valueType", (o,n) => { (o as Setting).ValueType = n.GetEnumValue<ManagementParameterValueType>(); } },
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
            writer.WriteBoolValue("overwriteAllowed", OverwriteAllowed);
            writer.WriteStringValue("settingId", SettingId);
            writer.WriteEnumValue<ManagementParameterValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.Templates.Item.MigratableTo.Item.CreateInstance {
    public class CreateInstanceRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public List<string> RoleScopeTagIds { get; set; }
        public List<DeviceManagementSettingInstance> SettingsDelta { get; set; }
        /// <summary>
        /// Instantiates a new createInstanceRequestBody and sets the default values.
        /// </summary>
        public CreateInstanceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as CreateInstanceRequestBody).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CreateInstanceRequestBody).DisplayName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as CreateInstanceRequestBody).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"settingsDelta", (o,n) => { (o as CreateInstanceRequestBody).SettingsDelta = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("settingsDelta", SettingsDelta);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

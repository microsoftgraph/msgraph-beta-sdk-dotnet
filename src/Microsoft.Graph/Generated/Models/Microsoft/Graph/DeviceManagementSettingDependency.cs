using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementSettingDependency : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of constraints for the dependency setting value</summary>
        public List<DeviceManagementConstraint> Constraints { get; set; }
        /// <summary>The setting definition ID of the setting depended on</summary>
        public string DefinitionId { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementSettingDependency and sets the default values.
        /// </summary>
        public DeviceManagementSettingDependency() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementSettingDependency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingDependency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"constraints", (o,n) => { (o as DeviceManagementSettingDependency).Constraints = n.GetCollectionOfObjectValues<DeviceManagementConstraint>(DeviceManagementConstraint.CreateFromDiscriminatorValue).ToList(); } },
                {"definitionId", (o,n) => { (o as DeviceManagementSettingDependency).DefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementConstraint>("constraints", Constraints);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

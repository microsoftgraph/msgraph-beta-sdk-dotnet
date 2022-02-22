using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceAppManagement.IosLobAppProvisioningConfigurations.Item.Assign {
    public class AssignRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<MobileAppProvisioningConfigGroupAssignment> AppProvisioningConfigurationGroupAssignments { get; set; }
        public List<IosLobAppProvisioningConfigurationAssignment> IOSLobAppProvisioningConfigAssignments { get; set; }
        /// <summary>
        /// Instantiates a new assignRequestBody and sets the default values.
        /// </summary>
        public AssignRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appProvisioningConfigurationGroupAssignments", (o,n) => { (o as AssignRequestBody).AppProvisioningConfigurationGroupAssignments = n.GetCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>().ToList(); } },
                {"iOSLobAppProvisioningConfigAssignments", (o,n) => { (o as AssignRequestBody).IOSLobAppProvisioningConfigAssignments = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>("appProvisioningConfigurationGroupAssignments", AppProvisioningConfigurationGroupAssignments);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>("iOSLobAppProvisioningConfigAssignments", IOSLobAppProvisioningConfigAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

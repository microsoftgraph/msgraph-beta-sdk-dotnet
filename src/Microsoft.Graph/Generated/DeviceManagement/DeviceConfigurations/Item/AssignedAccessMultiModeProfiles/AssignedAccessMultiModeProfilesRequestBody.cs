using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.DeviceConfigurations.Item.AssignedAccessMultiModeProfiles {
    public class AssignedAccessMultiModeProfilesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<WindowsAssignedAccessProfile> AssignedAccessMultiModeProfiles { get; set; }
        /// <summary>
        /// Instantiates a new assignedAccessMultiModeProfilesRequestBody and sets the default values.
        /// </summary>
        public AssignedAccessMultiModeProfilesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedAccessMultiModeProfiles", (o,n) => { (o as AssignedAccessMultiModeProfilesRequestBody).AssignedAccessMultiModeProfiles = n.GetCollectionOfObjectValues<WindowsAssignedAccessProfile>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WindowsAssignedAccessProfile>("assignedAccessMultiModeProfiles", AssignedAccessMultiModeProfiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

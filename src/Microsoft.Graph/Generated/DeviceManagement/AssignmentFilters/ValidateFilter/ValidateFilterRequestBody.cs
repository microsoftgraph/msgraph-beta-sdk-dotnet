using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.AssignmentFilters.ValidateFilter {
    public class ValidateFilterRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DeviceAndAppManagementAssignmentFilter DeviceAndAppManagementAssignmentFilter { get; set; }
        /// <summary>
        /// Instantiates a new validateFilterRequestBody and sets the default values.
        /// </summary>
        public ValidateFilterRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceAndAppManagementAssignmentFilter", (o,n) => { (o as ValidateFilterRequestBody).DeviceAndAppManagementAssignmentFilter = n.GetObjectValue<DeviceAndAppManagementAssignmentFilter>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentFilter>("deviceAndAppManagementAssignmentFilter", DeviceAndAppManagementAssignmentFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.AssignmentFilters.ValidateFilter {
    /// <summary>Provides operations to call the validateFilter method.</summary>
    public class ValidateFilterRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceAndAppManagementAssignmentFilter property</summary>
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter DeviceAndAppManagementAssignmentFilter { get; set; }
        /// <summary>
        /// Instantiates a new validateFilterRequestBody and sets the default values.
        /// </summary>
        public ValidateFilterRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidateFilterRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateFilterRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceAndAppManagementAssignmentFilter", (o,n) => { (o as ValidateFilterRequestBody).DeviceAndAppManagementAssignmentFilter = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>(Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>("deviceAndAppManagementAssignmentFilter", DeviceAndAppManagementAssignmentFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

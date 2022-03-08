using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the assignments property of the microsoft.graph.windowsAutopilotDeploymentProfile entity.</summary>
    public class WindowsAutopilotDeploymentProfileAssignmentCollectionResponse : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<WindowsAutopilotDeploymentProfileAssignment> Value { get; set; }
        /// <summary>
        /// Instantiates a new WindowsAutopilotDeploymentProfileAssignmentCollectionResponse and sets the default values.
        /// </summary>
        public WindowsAutopilotDeploymentProfileAssignmentCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsAutopilotDeploymentProfileAssignmentCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotDeploymentProfileAssignmentCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as WindowsAutopilotDeploymentProfileAssignmentCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as WindowsAutopilotDeploymentProfileAssignmentCollectionResponse).Value = n.GetCollectionOfObjectValues<WindowsAutopilotDeploymentProfileAssignment>(WindowsAutopilotDeploymentProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeploymentProfileAssignment>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsDriverUpdateProfiles.Item.ExecuteAction {
    /// <summary>Provides operations to call the executeAction method.</summary>
    public class ExecuteActionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The actionName property</summary>
        public DriverApprovalAction? ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deploymentDate property</summary>
        public DateTimeOffset? DeploymentDate { get; set; }
        /// <summary>The driverIds property</summary>
        public List<string> DriverIds { get; set; }
        /// <summary>
        /// Instantiates a new executeActionRequestBody and sets the default values.
        /// </summary>
        public ExecuteActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExecuteActionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetEnumValue<DriverApprovalAction>(); } },
                {"deploymentDate", n => { DeploymentDate = n.GetDateTimeOffsetValue(); } },
                {"driverIds", n => { DriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DriverApprovalAction>("actionName", ActionName);
            writer.WriteDateTimeOffsetValue("deploymentDate", DeploymentDate);
            writer.WriteCollectionOfPrimitiveValues<string>("driverIds", DriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

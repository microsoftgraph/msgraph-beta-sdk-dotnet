using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsDriverUpdateProfiles.Item.MicrosoftGraphExecuteAction {
    public class ExecuteActionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>An enum type to represent approval actions of single or list of drivers.</summary>
        public DriverApprovalAction? ActionName {
            get { return BackingStore?.Get<DriverApprovalAction?>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deploymentDate property</summary>
        public DateTimeOffset? DeploymentDate {
            get { return BackingStore?.Get<DateTimeOffset?>("deploymentDate"); }
            set { BackingStore?.Set("deploymentDate", value); }
        }
        /// <summary>The driverIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DriverIds {
            get { return BackingStore?.Get<List<string>?>("driverIds"); }
            set { BackingStore?.Set("driverIds", value); }
        }
#nullable restore
#else
        public List<string> DriverIds {
            get { return BackingStore?.Get<List<string>>("driverIds"); }
            set { BackingStore?.Set("driverIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new executeActionPostRequestBody and sets the default values.
        /// </summary>
        public ExecuteActionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExecuteActionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetEnumValue<DriverApprovalAction>(); } },
                {"deploymentDate", n => { DeploymentDate = n.GetDateTimeOffsetValue(); } },
                {"driverIds", n => { DriverIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DriverApprovalAction>("actionName", ActionName);
            writer.WriteDateTimeOffsetValue("deploymentDate", DeploymentDate);
            writer.WriteCollectionOfPrimitiveValues<string>("driverIds", DriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

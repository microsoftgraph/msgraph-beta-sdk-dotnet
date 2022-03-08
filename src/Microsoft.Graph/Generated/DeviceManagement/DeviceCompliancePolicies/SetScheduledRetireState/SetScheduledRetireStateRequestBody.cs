using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicies.SetScheduledRetireState {
    /// <summary>Provides operations to call the setScheduledRetireState method.</summary>
    public class SetScheduledRetireStateRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> ManagedDeviceIds { get; set; }
        public ScheduledRetireState? State { get; set; }
        /// <summary>
        /// Instantiates a new setScheduledRetireStateRequestBody and sets the default values.
        /// </summary>
        public SetScheduledRetireStateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetScheduledRetireStateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetScheduledRetireStateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managedDeviceIds", (o,n) => { (o as SetScheduledRetireStateRequestBody).ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as SetScheduledRetireStateRequestBody).State = n.GetEnumValue<ScheduledRetireState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteEnumValue<ScheduledRetireState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

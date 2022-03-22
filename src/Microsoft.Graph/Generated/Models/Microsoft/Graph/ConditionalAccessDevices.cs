using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ConditionalAccessDevices : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Filter that defines the dynamic-device-syntax rule to include/exclude devices. A filter can use device properties (such as extension attributes) to include/exclude them.</summary>
        public ConditionalAccessFilter DeviceFilter { get; set; }
        /// <summary>States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.</summary>
        public List<string> ExcludeDevices { get; set; }
        public List<string> ExcludeDeviceStates { get; set; }
        /// <summary>States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFIlter is set.</summary>
        public List<string> IncludeDevices { get; set; }
        public List<string> IncludeDeviceStates { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessDevices and sets the default values.
        /// </summary>
        public ConditionalAccessDevices() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessDevices CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessDevices();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceFilter", (o,n) => { (o as ConditionalAccessDevices).DeviceFilter = n.GetObjectValue<ConditionalAccessFilter>(ConditionalAccessFilter.CreateFromDiscriminatorValue); } },
                {"excludeDevices", (o,n) => { (o as ConditionalAccessDevices).ExcludeDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeDeviceStates", (o,n) => { (o as ConditionalAccessDevices).ExcludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeDevices", (o,n) => { (o as ConditionalAccessDevices).IncludeDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeDeviceStates", (o,n) => { (o as ConditionalAccessDevices).IncludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessFilter>("deviceFilter", DeviceFilter);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeDevices", ExcludeDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeDeviceStates", ExcludeDeviceStates);
            writer.WriteCollectionOfPrimitiveValues<string>("includeDevices", IncludeDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("includeDeviceStates", IncludeDeviceStates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

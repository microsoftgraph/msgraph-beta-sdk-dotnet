using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessDevices : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Filter that defines the dynamic-device-syntax rule to include/exclude devices. A filter can use device properties (such as extension attributes) to include/exclude them. Cannot be set if includeDevices or excludeDevices is set.</summary>
        public ConditionalAccessFilter DeviceFilter {
            get { return BackingStore?.Get<ConditionalAccessFilter>(nameof(DeviceFilter)); }
            set { BackingStore?.Set(nameof(DeviceFilter), value); }
        }
        /// <summary>States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.</summary>
        public List<string> ExcludeDevices {
            get { return BackingStore?.Get<List<string>>(nameof(ExcludeDevices)); }
            set { BackingStore?.Set(nameof(ExcludeDevices), value); }
        }
        /// <summary>The excludeDeviceStates property</summary>
        public List<string> ExcludeDeviceStates {
            get { return BackingStore?.Get<List<string>>(nameof(ExcludeDeviceStates)); }
            set { BackingStore?.Set(nameof(ExcludeDeviceStates), value); }
        }
        /// <summary>States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFIlter is set.</summary>
        public List<string> IncludeDevices {
            get { return BackingStore?.Get<List<string>>(nameof(IncludeDevices)); }
            set { BackingStore?.Set(nameof(IncludeDevices), value); }
        }
        /// <summary>The includeDeviceStates property</summary>
        public List<string> IncludeDeviceStates {
            get { return BackingStore?.Get<List<string>>(nameof(IncludeDeviceStates)); }
            set { BackingStore?.Set(nameof(IncludeDeviceStates), value); }
        }
        /// <summary>
        /// Instantiates a new conditionalAccessDevices and sets the default values.
        /// </summary>
        public ConditionalAccessDevices() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceFilter", n => { DeviceFilter = n.GetObjectValue<ConditionalAccessFilter>(ConditionalAccessFilter.CreateFromDiscriminatorValue); } },
                {"excludeDevices", n => { ExcludeDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeDeviceStates", n => { ExcludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeDevices", n => { IncludeDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeDeviceStates", n => { IncludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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

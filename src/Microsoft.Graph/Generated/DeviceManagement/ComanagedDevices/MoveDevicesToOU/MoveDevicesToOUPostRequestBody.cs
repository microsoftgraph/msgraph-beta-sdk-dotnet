using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.MoveDevicesToOU {
    public class MoveDevicesToOUPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceIds property</summary>
        public List<Guid?> DeviceIds {
            get { return BackingStore?.Get<List<Guid?>>("deviceIds"); }
            set { BackingStore?.Set("deviceIds", value); }
        }
        /// <summary>The organizationalUnitPath property</summary>
        public string OrganizationalUnitPath {
            get { return BackingStore?.Get<string>("organizationalUnitPath"); }
            set { BackingStore?.Set("organizationalUnitPath", value); }
        }
        /// <summary>
        /// Instantiates a new moveDevicesToOUPostRequestBody and sets the default values.
        /// </summary>
        public MoveDevicesToOUPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MoveDevicesToOUPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MoveDevicesToOUPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceIds", n => { DeviceIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"organizationalUnitPath", n => { OrganizationalUnitPath = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<Guid?>("deviceIds", DeviceIds);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

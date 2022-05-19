using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharedAppleDeviceUser : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data quota</summary>
        public long? DataQuota {
            get { return BackingStore?.Get<long?>(nameof(DataQuota)); }
            set { BackingStore?.Set(nameof(DataQuota), value); }
        }
        /// <summary>Data to sync</summary>
        public bool? DataToSync {
            get { return BackingStore?.Get<bool?>(nameof(DataToSync)); }
            set { BackingStore?.Set(nameof(DataToSync), value); }
        }
        /// <summary>Data quota</summary>
        public long? DataUsed {
            get { return BackingStore?.Get<long?>(nameof(DataUsed)); }
            set { BackingStore?.Set(nameof(DataUsed), value); }
        }
        /// <summary>User name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Instantiates a new sharedAppleDeviceUser and sets the default values.
        /// </summary>
        public SharedAppleDeviceUser() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharedAppleDeviceUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedAppleDeviceUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataQuota", n => { DataQuota = n.GetLongValue(); } },
                {"dataToSync", n => { DataToSync = n.GetBoolValue(); } },
                {"dataUsed", n => { DataUsed = n.GetLongValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("dataQuota", DataQuota);
            writer.WriteBoolValue("dataToSync", DataToSync);
            writer.WriteLongValue("dataUsed", DataUsed);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

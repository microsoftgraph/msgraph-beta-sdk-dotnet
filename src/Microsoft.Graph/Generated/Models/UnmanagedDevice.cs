using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Unmanaged device discovered in the network.</summary>
    public class UnmanagedDevice : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device name.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Domain.</summary>
        public string Domain {
            get { return BackingStore?.Get<string>(nameof(Domain)); }
            set { BackingStore?.Set(nameof(Domain), value); }
        }
        /// <summary>IP address.</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>(nameof(IpAddress)); }
            set { BackingStore?.Set(nameof(IpAddress), value); }
        }
        /// <summary>Last logged on user.</summary>
        public string LastLoggedOnUser {
            get { return BackingStore?.Get<string>(nameof(LastLoggedOnUser)); }
            set { BackingStore?.Set(nameof(LastLoggedOnUser), value); }
        }
        /// <summary>Last seen date and time.</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSeenDateTime)); }
            set { BackingStore?.Set(nameof(LastSeenDateTime), value); }
        }
        /// <summary>Location.</summary>
        public string Location {
            get { return BackingStore?.Get<string>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>MAC address.</summary>
        public string MacAddress {
            get { return BackingStore?.Get<string>(nameof(MacAddress)); }
            set { BackingStore?.Set(nameof(MacAddress), value); }
        }
        /// <summary>Manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>Model.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>Operating system.</summary>
        public string Os {
            get { return BackingStore?.Get<string>(nameof(Os)); }
            set { BackingStore?.Set(nameof(Os), value); }
        }
        /// <summary>Operating system version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>
        /// Instantiates a new unmanagedDevice and sets the default values.
        /// </summary>
        public UnmanagedDevice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UnmanagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnmanagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"domain", n => { Domain = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"lastLoggedOnUser", n => { LastLoggedOnUser = n.GetStringValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"location", n => { Location = n.GetStringValue(); } },
                {"macAddress", n => { MacAddress = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("lastLoggedOnUser", LastLoggedOnUser);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("os", Os);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

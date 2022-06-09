using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Platform specific enrollment restrictions</summary>
    public class DeviceEnrollmentPlatformRestriction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Collection of blocked Manufacturers.</summary>
        public List<string> BlockedManufacturers {
            get { return BackingStore?.Get<List<string>>(nameof(BlockedManufacturers)); }
            set { BackingStore?.Set(nameof(BlockedManufacturers), value); }
        }
        /// <summary>Collection of blocked Skus.</summary>
        public List<string> BlockedSkus {
            get { return BackingStore?.Get<List<string>>(nameof(BlockedSkus)); }
            set { BackingStore?.Set(nameof(BlockedSkus), value); }
        }
        /// <summary>Max OS version supported</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Min OS version supported</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Block personally owned devices from enrolling</summary>
        public bool? PersonalDeviceEnrollmentBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PersonalDeviceEnrollmentBlocked)); }
            set { BackingStore?.Set(nameof(PersonalDeviceEnrollmentBlocked), value); }
        }
        /// <summary>Block the platform from enrolling</summary>
        public bool? PlatformBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PlatformBlocked)); }
            set { BackingStore?.Set(nameof(PlatformBlocked), value); }
        }
        /// <summary>
        /// Instantiates a new deviceEnrollmentPlatformRestriction and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestriction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceEnrollmentPlatformRestriction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestriction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"blockedManufacturers", n => { BlockedManufacturers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"blockedSkus", n => { BlockedSkus = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"personalDeviceEnrollmentBlocked", n => { PersonalDeviceEnrollmentBlocked = n.GetBoolValue(); } },
                {"platformBlocked", n => { PlatformBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("blockedManufacturers", BlockedManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("blockedSkus", BlockedSkus);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("personalDeviceEnrollmentBlocked", PersonalDeviceEnrollmentBlocked);
            writer.WriteBoolValue("platformBlocked", PlatformBlocked);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

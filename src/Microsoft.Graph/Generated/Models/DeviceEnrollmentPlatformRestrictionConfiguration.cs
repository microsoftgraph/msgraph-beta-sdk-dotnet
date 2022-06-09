using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentPlatformRestrictionConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction PlatformRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(PlatformRestriction)); }
            set { BackingStore?.Set(nameof(PlatformRestriction), value); }
        }
        /// <summary>Type of platform for which this restriction applies. Possible values are: allPlatforms, ios, windows, windowsPhone, android, androidForWork, mac.</summary>
        public EnrollmentRestrictionPlatformType? PlatformType {
            get { return BackingStore?.Get<EnrollmentRestrictionPlatformType?>(nameof(PlatformType)); }
            set { BackingStore?.Set(nameof(PlatformType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentPlatformRestrictionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestrictionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"platformRestriction", n => { PlatformRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<EnrollmentRestrictionPlatformType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("platformRestriction", PlatformRestriction);
            writer.WriteEnumValue<EnrollmentRestrictionPlatformType>("platformType", PlatformType);
        }
    }
}

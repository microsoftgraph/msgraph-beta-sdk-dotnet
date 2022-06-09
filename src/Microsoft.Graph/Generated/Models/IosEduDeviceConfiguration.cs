using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosEduDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>The Trusted Root and PFX certificates for Device</summary>
        public IosEduCertificateSettings DeviceCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>(nameof(DeviceCertificateSettings)); }
            set { BackingStore?.Set(nameof(DeviceCertificateSettings), value); }
        }
        /// <summary>The Trusted Root and PFX certificates for Student</summary>
        public IosEduCertificateSettings StudentCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>(nameof(StudentCertificateSettings)); }
            set { BackingStore?.Set(nameof(StudentCertificateSettings), value); }
        }
        /// <summary>Trusted Root and PFX certificates for iOS EDU.</summary>
        public IosEduCertificateSettings TeacherCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>(nameof(TeacherCertificateSettings)); }
            set { BackingStore?.Set(nameof(TeacherCertificateSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosEduDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosEduDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceCertificateSettings", n => { DeviceCertificateSettings = n.GetObjectValue<IosEduCertificateSettings>(IosEduCertificateSettings.CreateFromDiscriminatorValue); } },
                {"studentCertificateSettings", n => { StudentCertificateSettings = n.GetObjectValue<IosEduCertificateSettings>(IosEduCertificateSettings.CreateFromDiscriminatorValue); } },
                {"teacherCertificateSettings", n => { TeacherCertificateSettings = n.GetObjectValue<IosEduCertificateSettings>(IosEduCertificateSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosEduCertificateSettings>("deviceCertificateSettings", DeviceCertificateSettings);
            writer.WriteObjectValue<IosEduCertificateSettings>("studentCertificateSettings", StudentCertificateSettings);
            writer.WriteObjectValue<IosEduCertificateSettings>("teacherCertificateSettings", TeacherCertificateSettings);
        }
    }
}

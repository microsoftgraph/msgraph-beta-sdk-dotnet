using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosEduDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>The Trusted Root and PFX certificates for Device</summary>
        public IosEduCertificateSettings DeviceCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("deviceCertificateSettings"); }
            set { BackingStore?.Set("deviceCertificateSettings", value); }
        }
        /// <summary>The Trusted Root and PFX certificates for Student</summary>
        public IosEduCertificateSettings StudentCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("studentCertificateSettings"); }
            set { BackingStore?.Set("studentCertificateSettings", value); }
        }
        /// <summary>Trusted Root and PFX certificates for iOS EDU.</summary>
        public IosEduCertificateSettings TeacherCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("teacherCertificateSettings"); }
            set { BackingStore?.Set("teacherCertificateSettings", value); }
        }
        /// <summary>
        /// Instantiates a new IosEduDeviceConfiguration and sets the default values.
        /// </summary>
        public IosEduDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.iosEduDeviceConfiguration";
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

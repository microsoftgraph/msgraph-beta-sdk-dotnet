using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IosEduDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>The Trusted Root and PFX certificates for Device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosEduCertificateSettings? DeviceCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings?>("deviceCertificateSettings"); }
            set { BackingStore?.Set("deviceCertificateSettings", value); }
        }
#nullable restore
#else
        public IosEduCertificateSettings DeviceCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("deviceCertificateSettings"); }
            set { BackingStore?.Set("deviceCertificateSettings", value); }
        }
#endif
        /// <summary>The Trusted Root and PFX certificates for Student</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosEduCertificateSettings? StudentCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings?>("studentCertificateSettings"); }
            set { BackingStore?.Set("studentCertificateSettings", value); }
        }
#nullable restore
#else
        public IosEduCertificateSettings StudentCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("studentCertificateSettings"); }
            set { BackingStore?.Set("studentCertificateSettings", value); }
        }
#endif
        /// <summary>Trusted Root and PFX certificates for iOS EDU.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosEduCertificateSettings? TeacherCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings?>("teacherCertificateSettings"); }
            set { BackingStore?.Set("teacherCertificateSettings", value); }
        }
#nullable restore
#else
        public IosEduCertificateSettings TeacherCertificateSettings {
            get { return BackingStore?.Get<IosEduCertificateSettings>("teacherCertificateSettings"); }
            set { BackingStore?.Set("teacherCertificateSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IosEduDeviceConfiguration and sets the default values.
        /// </summary>
        public IosEduDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.iosEduDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosEduCertificateSettings>("deviceCertificateSettings", DeviceCertificateSettings);
            writer.WriteObjectValue<IosEduCertificateSettings>("studentCertificateSettings", StudentCertificateSettings);
            writer.WriteObjectValue<IosEduCertificateSettings>("teacherCertificateSettings", TeacherCertificateSettings);
        }
    }
}

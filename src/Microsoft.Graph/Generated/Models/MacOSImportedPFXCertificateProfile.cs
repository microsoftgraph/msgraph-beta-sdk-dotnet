using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSImportedPFXCertificateProfile : MacOSCertificateProfileBase, IParsable {
        /// <summary>PFX Import Options.</summary>
        public Microsoft.Graph.Beta.Models.IntendedPurpose? IntendedPurpose {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IntendedPurpose?>("intendedPurpose"); }
            set { BackingStore?.Set("intendedPurpose", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSImportedPFXCertificateProfile and sets the default values.
        /// </summary>
        public MacOSImportedPFXCertificateProfile() : base() {
            OdataType = "#microsoft.graph.macOSImportedPFXCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSImportedPFXCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSImportedPFXCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"intendedPurpose", n => { IntendedPurpose = n.GetEnumValue<IntendedPurpose>(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<IntendedPurpose>("intendedPurpose", IntendedPurpose);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
        }
    }
}

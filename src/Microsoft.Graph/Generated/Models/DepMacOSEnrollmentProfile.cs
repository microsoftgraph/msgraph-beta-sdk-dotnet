using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DepMacOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Accessibility screen is disabled</summary>
        public bool? AccessibilityScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(AccessibilityScreenDisabled)); }
            set { BackingStore?.Set(nameof(AccessibilityScreenDisabled), value); }
        }
        /// <summary>Indicates if UnlockWithWatch screen is disabled</summary>
        public bool? AutoUnlockWithWatchDisabled {
            get { return BackingStore?.Get<bool?>(nameof(AutoUnlockWithWatchDisabled)); }
            set { BackingStore?.Set(nameof(AutoUnlockWithWatchDisabled), value); }
        }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ChooseYourLockScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ChooseYourLockScreenDisabled)); }
            set { BackingStore?.Set(nameof(ChooseYourLockScreenDisabled), value); }
        }
        /// <summary>Indicates if file vault is disabled</summary>
        public bool? FileVaultDisabled {
            get { return BackingStore?.Get<bool?>(nameof(FileVaultDisabled)); }
            set { BackingStore?.Set(nameof(FileVaultDisabled), value); }
        }
        /// <summary>Indicates if iCloud Analytics screen is disabled</summary>
        public bool? ICloudDiagnosticsDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ICloudDiagnosticsDisabled)); }
            set { BackingStore?.Set(nameof(ICloudDiagnosticsDisabled), value); }
        }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ICloudStorageDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ICloudStorageDisabled)); }
            set { BackingStore?.Set(nameof(ICloudStorageDisabled), value); }
        }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>(nameof(PassCodeDisabled)); }
            set { BackingStore?.Set(nameof(PassCodeDisabled), value); }
        }
        /// <summary>Indicates if registration is disabled</summary>
        public bool? RegistrationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(RegistrationDisabled)); }
            set { BackingStore?.Set(nameof(RegistrationDisabled), value); }
        }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ZoomDisabled)); }
            set { BackingStore?.Set(nameof(ZoomDisabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DepMacOSEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepMacOSEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessibilityScreenDisabled", n => { AccessibilityScreenDisabled = n.GetBoolValue(); } },
                {"autoUnlockWithWatchDisabled", n => { AutoUnlockWithWatchDisabled = n.GetBoolValue(); } },
                {"chooseYourLockScreenDisabled", n => { ChooseYourLockScreenDisabled = n.GetBoolValue(); } },
                {"fileVaultDisabled", n => { FileVaultDisabled = n.GetBoolValue(); } },
                {"iCloudDiagnosticsDisabled", n => { ICloudDiagnosticsDisabled = n.GetBoolValue(); } },
                {"iCloudStorageDisabled", n => { ICloudStorageDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"registrationDisabled", n => { RegistrationDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accessibilityScreenDisabled", AccessibilityScreenDisabled);
            writer.WriteBoolValue("autoUnlockWithWatchDisabled", AutoUnlockWithWatchDisabled);
            writer.WriteBoolValue("chooseYourLockScreenDisabled", ChooseYourLockScreenDisabled);
            writer.WriteBoolValue("fileVaultDisabled", FileVaultDisabled);
            writer.WriteBoolValue("iCloudDiagnosticsDisabled", ICloudDiagnosticsDisabled);
            writer.WriteBoolValue("iCloudStorageDisabled", ICloudStorageDisabled);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteBoolValue("registrationDisabled", RegistrationDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}

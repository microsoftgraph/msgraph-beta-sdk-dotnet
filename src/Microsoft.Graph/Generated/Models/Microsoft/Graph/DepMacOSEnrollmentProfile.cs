using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DepMacOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Accessibility screen is disabled</summary>
        public bool? AccessibilityScreenDisabled { get; set; }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ChooseYourLockScreenDisabled { get; set; }
        /// <summary>Indicates if file vault is disabled</summary>
        public bool? FileVaultDisabled { get; set; }
        /// <summary>Indicates if iCloud Analytics screen is disabled</summary>
        public bool? ICloudDiagnosticsDisabled { get; set; }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ICloudStorageDisabled { get; set; }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled { get; set; }
        /// <summary>Indicates if registration is disabled</summary>
        public bool? RegistrationDisabled { get; set; }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessibilityScreenDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).AccessibilityScreenDisabled = n.GetBoolValue(); } },
                {"chooseYourLockScreenDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).ChooseYourLockScreenDisabled = n.GetBoolValue(); } },
                {"fileVaultDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).FileVaultDisabled = n.GetBoolValue(); } },
                {"iCloudDiagnosticsDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).ICloudDiagnosticsDisabled = n.GetBoolValue(); } },
                {"iCloudStorageDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).ICloudStorageDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).PassCodeDisabled = n.GetBoolValue(); } },
                {"registrationDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).RegistrationDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", (o,n) => { (o as DepMacOSEnrollmentProfile).ZoomDisabled = n.GetBoolValue(); } },
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

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsDefenderAdvancedThreatProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Auto populate onboarding blob programmatically from Advanced Threat protection service</summary>
        public bool? AdvancedThreatProtectionAutoPopulateOnboardingBlob {
            get { return BackingStore?.Get<bool?>("advancedThreatProtectionAutoPopulateOnboardingBlob"); }
            set { BackingStore?.Set("advancedThreatProtectionAutoPopulateOnboardingBlob", value); }
        }
        /// <summary>Windows Defender AdvancedThreatProtection Offboarding Blob.</summary>
        public string AdvancedThreatProtectionOffboardingBlob {
            get { return BackingStore?.Get<string>("advancedThreatProtectionOffboardingBlob"); }
            set { BackingStore?.Set("advancedThreatProtectionOffboardingBlob", value); }
        }
        /// <summary>Name of the file from which AdvancedThreatProtectionOffboardingBlob was obtained.</summary>
        public string AdvancedThreatProtectionOffboardingFilename {
            get { return BackingStore?.Get<string>("advancedThreatProtectionOffboardingFilename"); }
            set { BackingStore?.Set("advancedThreatProtectionOffboardingFilename", value); }
        }
        /// <summary>Windows Defender AdvancedThreatProtection Onboarding Blob.</summary>
        public string AdvancedThreatProtectionOnboardingBlob {
            get { return BackingStore?.Get<string>("advancedThreatProtectionOnboardingBlob"); }
            set { BackingStore?.Set("advancedThreatProtectionOnboardingBlob", value); }
        }
        /// <summary>Name of the file from which AdvancedThreatProtectionOnboardingBlob was obtained.</summary>
        public string AdvancedThreatProtectionOnboardingFilename {
            get { return BackingStore?.Get<string>("advancedThreatProtectionOnboardingFilename"); }
            set { BackingStore?.Set("advancedThreatProtectionOnboardingFilename", value); }
        }
        /// <summary>Windows Defender AdvancedThreatProtection &apos;Allow Sample Sharing&apos; Rule</summary>
        public bool? AllowSampleSharing {
            get { return BackingStore?.Get<bool?>("allowSampleSharing"); }
            set { BackingStore?.Set("allowSampleSharing", value); }
        }
        /// <summary>Expedite Windows Defender Advanced Threat Protection telemetry reporting frequency.</summary>
        public bool? EnableExpeditedTelemetryReporting {
            get { return BackingStore?.Get<bool?>("enableExpeditedTelemetryReporting"); }
            set { BackingStore?.Set("enableExpeditedTelemetryReporting", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDefenderAdvancedThreatProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderAdvancedThreatProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionAutoPopulateOnboardingBlob", n => { AdvancedThreatProtectionAutoPopulateOnboardingBlob = n.GetBoolValue(); } },
                {"advancedThreatProtectionOffboardingBlob", n => { AdvancedThreatProtectionOffboardingBlob = n.GetStringValue(); } },
                {"advancedThreatProtectionOffboardingFilename", n => { AdvancedThreatProtectionOffboardingFilename = n.GetStringValue(); } },
                {"advancedThreatProtectionOnboardingBlob", n => { AdvancedThreatProtectionOnboardingBlob = n.GetStringValue(); } },
                {"advancedThreatProtectionOnboardingFilename", n => { AdvancedThreatProtectionOnboardingFilename = n.GetStringValue(); } },
                {"allowSampleSharing", n => { AllowSampleSharing = n.GetBoolValue(); } },
                {"enableExpeditedTelemetryReporting", n => { EnableExpeditedTelemetryReporting = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("advancedThreatProtectionAutoPopulateOnboardingBlob", AdvancedThreatProtectionAutoPopulateOnboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOffboardingBlob", AdvancedThreatProtectionOffboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOffboardingFilename", AdvancedThreatProtectionOffboardingFilename);
            writer.WriteStringValue("advancedThreatProtectionOnboardingBlob", AdvancedThreatProtectionOnboardingBlob);
            writer.WriteStringValue("advancedThreatProtectionOnboardingFilename", AdvancedThreatProtectionOnboardingFilename);
            writer.WriteBoolValue("allowSampleSharing", AllowSampleSharing);
            writer.WriteBoolValue("enableExpeditedTelemetryReporting", EnableExpeditedTelemetryReporting);
        }
    }
}

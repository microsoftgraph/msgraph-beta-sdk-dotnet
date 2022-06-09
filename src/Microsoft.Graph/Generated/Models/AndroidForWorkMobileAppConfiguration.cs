using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkMobileAppConfiguration : ManagedDeviceMobileAppConfiguration, IParsable {
        /// <summary>Setting to specify whether to allow ConnectedApps experience for this app.</summary>
        public bool? ConnectedAppsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(ConnectedAppsEnabled)); }
            set { BackingStore?.Set(nameof(ConnectedAppsEnabled), value); }
        }
        /// <summary>Android For Work app configuration package id.</summary>
        public string PackageId {
            get { return BackingStore?.Get<string>(nameof(PackageId)); }
            set { BackingStore?.Set(nameof(PackageId), value); }
        }
        /// <summary>Android For Work app configuration JSON payload.</summary>
        public string PayloadJson {
            get { return BackingStore?.Get<string>(nameof(PayloadJson)); }
            set { BackingStore?.Set(nameof(PayloadJson), value); }
        }
        /// <summary>List of Android app permissions and corresponding permission actions.</summary>
        public List<AndroidPermissionAction> PermissionActions {
            get { return BackingStore?.Get<List<AndroidPermissionAction>>(nameof(PermissionActions)); }
            set { BackingStore?.Set(nameof(PermissionActions), value); }
        }
        /// <summary>Android Enterprise profile applicability (AndroidWorkProfile, DeviceOwner, or default (applies to both)). Possible values are: default, androidWorkProfile, androidDeviceOwner.</summary>
        public AndroidProfileApplicability? ProfileApplicability {
            get { return BackingStore?.Get<AndroidProfileApplicability?>(nameof(ProfileApplicability)); }
            set { BackingStore?.Set(nameof(ProfileApplicability), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidForWorkMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkMobileAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectedAppsEnabled", n => { ConnectedAppsEnabled = n.GetBoolValue(); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
                {"payloadJson", n => { PayloadJson = n.GetStringValue(); } },
                {"permissionActions", n => { PermissionActions = n.GetCollectionOfObjectValues<AndroidPermissionAction>(AndroidPermissionAction.CreateFromDiscriminatorValue).ToList(); } },
                {"profileApplicability", n => { ProfileApplicability = n.GetEnumValue<AndroidProfileApplicability>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectedAppsEnabled", ConnectedAppsEnabled);
            writer.WriteStringValue("packageId", PackageId);
            writer.WriteStringValue("payloadJson", PayloadJson);
            writer.WriteCollectionOfObjectValues<AndroidPermissionAction>("permissionActions", PermissionActions);
            writer.WriteEnumValue<AndroidProfileApplicability>("profileApplicability", ProfileApplicability);
        }
    }
}

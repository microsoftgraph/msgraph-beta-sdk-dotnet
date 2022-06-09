using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentNotificationConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Branding Options for the Enrollment Notification. Possible values are: none, includeCompanyLogo, includeCompanyName, includeContactInformation, includeCompanyPortalLink, includeDeviceDetails.</summary>
        public EnrollmentNotificationBrandingOptions? BrandingOptions {
            get { return BackingStore?.Get<EnrollmentNotificationBrandingOptions?>(nameof(BrandingOptions)); }
            set { BackingStore?.Set(nameof(BrandingOptions), value); }
        }
        /// <summary>DefaultLocale for the Enrollment Notification</summary>
        public string DefaultLocale {
            get { return BackingStore?.Get<string>(nameof(DefaultLocale)); }
            set { BackingStore?.Set(nameof(DefaultLocale), value); }
        }
        /// <summary>Notification Message Template Id</summary>
        public string NotificationMessageTemplateId {
            get { return BackingStore?.Get<string>(nameof(NotificationMessageTemplateId)); }
            set { BackingStore?.Set(nameof(NotificationMessageTemplateId), value); }
        }
        /// <summary>Platform type of the Enrollment Notification. Possible values are: allPlatforms, ios, windows, windowsPhone, android, androidForWork, mac.</summary>
        public EnrollmentRestrictionPlatformType? PlatformType {
            get { return BackingStore?.Get<EnrollmentRestrictionPlatformType?>(nameof(PlatformType)); }
            set { BackingStore?.Set(nameof(PlatformType), value); }
        }
        /// <summary>Template type of the Enrollment Notification. Possible values are: email, push, unknownFutureValue.</summary>
        public EnrollmentNotificationTemplateType? TemplateType {
            get { return BackingStore?.Get<EnrollmentNotificationTemplateType?>(nameof(TemplateType)); }
            set { BackingStore?.Set(nameof(TemplateType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentNotificationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentNotificationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"brandingOptions", n => { BrandingOptions = n.GetEnumValue<EnrollmentNotificationBrandingOptions>(); } },
                {"defaultLocale", n => { DefaultLocale = n.GetStringValue(); } },
                {"notificationMessageTemplateId", n => { NotificationMessageTemplateId = n.GetStringValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<EnrollmentRestrictionPlatformType>(); } },
                {"templateType", n => { TemplateType = n.GetEnumValue<EnrollmentNotificationTemplateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EnrollmentNotificationBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("notificationMessageTemplateId", NotificationMessageTemplateId);
            writer.WriteEnumValue<EnrollmentRestrictionPlatformType>("platformType", PlatformType);
            writer.WriteEnumValue<EnrollmentNotificationTemplateType>("templateType", TemplateType);
        }
    }
}

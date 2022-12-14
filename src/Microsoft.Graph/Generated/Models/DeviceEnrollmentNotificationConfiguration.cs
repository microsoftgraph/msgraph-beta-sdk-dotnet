using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentNotificationConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
        public EnrollmentNotificationBrandingOptions? BrandingOptions {
            get { return BackingStore?.Get<EnrollmentNotificationBrandingOptions?>("brandingOptions"); }
            set { BackingStore?.Set("brandingOptions", value); }
        }
        /// <summary>DefaultLocale for the Enrollment Notification</summary>
        public string DefaultLocale {
            get { return BackingStore?.Get<string>("defaultLocale"); }
            set { BackingStore?.Set("defaultLocale", value); }
        }
        /// <summary>Notification Message Template Id</summary>
        public Guid? NotificationMessageTemplateId {
            get { return BackingStore?.Get<Guid?>("notificationMessageTemplateId"); }
            set { BackingStore?.Set("notificationMessageTemplateId", value); }
        }
        /// <summary>The list of notification data -</summary>
        public List<string> NotificationTemplates {
            get { return BackingStore?.Get<List<string>>("notificationTemplates"); }
            set { BackingStore?.Set("notificationTemplates", value); }
        }
        /// <summary>This enum indicates the platform type for which the enrollment restriction applies.</summary>
        public EnrollmentRestrictionPlatformType? PlatformType {
            get { return BackingStore?.Get<EnrollmentRestrictionPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>This enum indicates the Template type for which the enrollment notification applies.</summary>
        public EnrollmentNotificationTemplateType? TemplateType {
            get { return BackingStore?.Get<EnrollmentNotificationTemplateType?>("templateType"); }
            set { BackingStore?.Set("templateType", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceEnrollmentNotificationConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentNotificationConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentNotificationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"notificationMessageTemplateId", n => { NotificationMessageTemplateId = n.GetGuidValue(); } },
                {"notificationTemplates", n => { NotificationTemplates = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<EnrollmentRestrictionPlatformType>(); } },
                {"templateType", n => { TemplateType = n.GetEnumValue<EnrollmentNotificationTemplateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EnrollmentNotificationBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteGuidValue("notificationMessageTemplateId", NotificationMessageTemplateId);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationTemplates", NotificationTemplates);
            writer.WriteEnumValue<EnrollmentRestrictionPlatformType>("platformType", PlatformType);
            writer.WriteEnumValue<EnrollmentNotificationTemplateType>("templateType", TemplateType);
        }
    }
}

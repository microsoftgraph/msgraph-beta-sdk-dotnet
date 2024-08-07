// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The listing service profile entity contains the meta data of an Intune configuration profile 
    /// </summary>
    public class DeviceConfigurationProfile : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Account Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId
        {
            get { return BackingStore?.Get<string?>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#nullable restore
#else
        public string AccountId
        {
            get { return BackingStore?.Get<string>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#endif
        /// <summary>Configuration Technologies for Settins Catalog Policies</summary>
        public int? ConfigurationTechnologies
        {
            get { return BackingStore?.Get<int?>("configurationTechnologies"); }
            set { BackingStore?.Set("configurationTechnologies", value); }
        }
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Platform Type</summary>
        public Microsoft.Graph.Beta.Models.PlatformType? PlatformType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>Profile name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileName
        {
            get { return BackingStore?.Get<string?>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#nullable restore
#else
        public string ProfileName
        {
            get { return BackingStore?.Get<string>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#endif
        /// <summary>Profile Type</summary>
        public Microsoft.Graph.Beta.Models.ProfileType? ProfileType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ProfileType?>("profileType"); }
            set { BackingStore?.Set("profileType", value); }
        }
        /// <summary>The list of scope tags for the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>TemplateId for Settings Catalog Policies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId
        {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#nullable restore
#else
        public string TemplateId
        {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceConfigurationProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceConfigurationProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceConfigurationProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountId", n => { AccountId = n.GetStringValue(); } },
                { "configurationTechnologies", n => { ConfigurationTechnologies = n.GetIntValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "platformType", n => { PlatformType = n.GetEnumValue<Microsoft.Graph.Beta.Models.PlatformType>(); } },
                { "profileName", n => { ProfileName = n.GetStringValue(); } },
                { "profileType", n => { ProfileType = n.GetEnumValue<Microsoft.Graph.Beta.Models.ProfileType>(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteIntValue("configurationTechnologies", ConfigurationTechnologies);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PlatformType>("platformType", PlatformType);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ProfileType>("profileType", ProfileType);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}

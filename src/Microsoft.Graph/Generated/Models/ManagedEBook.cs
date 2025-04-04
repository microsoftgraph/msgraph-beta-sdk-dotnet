// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// An abstract class containing the base properties for Managed eBook.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedEBook : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The list of assignments for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The list of categories for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory>? Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory> Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The date and time when the eBook file was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The list of installation states for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceInstallState>? DeviceStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceInstallState>?>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceInstallState> DeviceStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceInstallState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#endif
        /// <summary>Name of the eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The more information Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InformationUrl
        {
            get { return BackingStore?.Get<string?>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#nullable restore
#else
        public string InformationUrl
        {
            get { return BackingStore?.Get<string>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#endif
        /// <summary>Mobile App Install Summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EBookInstallSummary? InstallSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EBookInstallSummary?>("installSummary"); }
            set { BackingStore?.Set("installSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EBookInstallSummary InstallSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EBookInstallSummary>("installSummary"); }
            set { BackingStore?.Set("installSummary", value); }
        }
#endif
        /// <summary>Book cover.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MimeContent? LargeCover
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MimeContent?>("largeCover"); }
            set { BackingStore?.Set("largeCover", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MimeContent LargeCover
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MimeContent>("largeCover"); }
            set { BackingStore?.Set("largeCover", value); }
        }
#endif
        /// <summary>The date and time when the eBook was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The privacy statement Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyInformationUrl
        {
            get { return BackingStore?.Get<string?>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#nullable restore
#else
        public string PrivacyInformationUrl
        {
            get { return BackingStore?.Get<string>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#endif
        /// <summary>The date and time when the eBook was published.</summary>
        public DateTimeOffset? PublishedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("publishedDateTime"); }
            set { BackingStore?.Set("publishedDateTime", value); }
        }
        /// <summary>Publisher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher
        {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher
        {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>The list of installation states for this eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary>? UserStateSummary
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary>?>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary> UserStateSummary
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary>>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedEBook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedEBook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosVppEBook" => new global::Microsoft.Graph.Beta.Models.IosVppEBook(),
                _ => new global::Microsoft.Graph.Beta.Models.ManagedEBook(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment>(global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory>(global::Microsoft.Graph.Beta.Models.ManagedEBookCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceInstallState>(global::Microsoft.Graph.Beta.Models.DeviceInstallState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                { "installSummary", n => { InstallSummary = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EBookInstallSummary>(global::Microsoft.Graph.Beta.Models.EBookInstallSummary.CreateFromDiscriminatorValue); } },
                { "largeCover", n => { LargeCover = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MimeContent>(global::Microsoft.Graph.Beta.Models.MimeContent.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                { "publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
                { "userStateSummary", n => { UserStateSummary = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary>(global::Microsoft.Graph.Beta.Models.UserInstallStateSummary.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedEBookAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedEBookCategory>("categories", Categories);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceInstallState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EBookInstallSummary>("installSummary", InstallSummary);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MimeContent>("largeCover", LargeCover);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserInstallStateSummary>("userStateSummary", UserStateSummary);
        }
    }
}
#pragma warning restore CS0618

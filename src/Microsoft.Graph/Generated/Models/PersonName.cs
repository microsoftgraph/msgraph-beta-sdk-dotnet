// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PersonName : global::Microsoft.Graph.Beta.Models.ItemFacet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.</summary>
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
        /// <summary>First name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? First
        {
            get { return BackingStore?.Get<string?>("first"); }
            set { BackingStore?.Set("first", value); }
        }
#nullable restore
#else
        public string First
        {
            get { return BackingStore?.Get<string>("first"); }
            set { BackingStore?.Set("first", value); }
        }
#endif
        /// <summary>Initials of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Initials
        {
            get { return BackingStore?.Get<string?>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#nullable restore
#else
        public string Initials
        {
            get { return BackingStore?.Get<string>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#endif
        /// <summary>Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag
        {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag
        {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>Last name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Last
        {
            get { return BackingStore?.Get<string?>("last"); }
            set { BackingStore?.Set("last", value); }
        }
#nullable restore
#else
        public string Last
        {
            get { return BackingStore?.Get<string>("last"); }
            set { BackingStore?.Set("last", value); }
        }
#endif
        /// <summary>Maiden name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Maiden
        {
            get { return BackingStore?.Get<string?>("maiden"); }
            set { BackingStore?.Set("maiden", value); }
        }
#nullable restore
#else
        public string Maiden
        {
            get { return BackingStore?.Get<string>("maiden"); }
            set { BackingStore?.Set("maiden", value); }
        }
#endif
        /// <summary>Middle name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Middle
        {
            get { return BackingStore?.Get<string?>("middle"); }
            set { BackingStore?.Set("middle", value); }
        }
#nullable restore
#else
        public string Middle
        {
            get { return BackingStore?.Get<string>("middle"); }
            set { BackingStore?.Set("middle", value); }
        }
#endif
        /// <summary>Nickname of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nickname
        {
            get { return BackingStore?.Get<string?>("nickname"); }
            set { BackingStore?.Set("nickname", value); }
        }
#nullable restore
#else
        public string Nickname
        {
            get { return BackingStore?.Get<string>("nickname"); }
            set { BackingStore?.Set("nickname", value); }
        }
#endif
        /// <summary>Guidance on how to pronounce the users name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PersonNamePronounciation? Pronunciation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersonNamePronounciation?>("pronunciation"); }
            set { BackingStore?.Set("pronunciation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PersonNamePronounciation Pronunciation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersonNamePronounciation>("pronunciation"); }
            set { BackingStore?.Set("pronunciation", value); }
        }
#endif
        /// <summary>Designators used after the users name (eg: PhD.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Suffix
        {
            get { return BackingStore?.Get<string?>("suffix"); }
            set { BackingStore?.Set("suffix", value); }
        }
#nullable restore
#else
        public string Suffix
        {
            get { return BackingStore?.Get<string>("suffix"); }
            set { BackingStore?.Set("suffix", value); }
        }
#endif
        /// <summary>Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.PersonName"/> and sets the default values.
        /// </summary>
        public PersonName() : base()
        {
            OdataType = "#microsoft.graph.personName";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PersonName"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PersonName CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PersonName();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "first", n => { First = n.GetStringValue(); } },
                { "initials", n => { Initials = n.GetStringValue(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "last", n => { Last = n.GetStringValue(); } },
                { "maiden", n => { Maiden = n.GetStringValue(); } },
                { "middle", n => { Middle = n.GetStringValue(); } },
                { "nickname", n => { Nickname = n.GetStringValue(); } },
                { "pronunciation", n => { Pronunciation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PersonNamePronounciation>(global::Microsoft.Graph.Beta.Models.PersonNamePronounciation.CreateFromDiscriminatorValue); } },
                { "suffix", n => { Suffix = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("maiden", Maiden);
            writer.WriteStringValue("middle", Middle);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PersonNamePronounciation>("pronunciation", Pronunciation);
            writer.WriteStringValue("suffix", Suffix);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618

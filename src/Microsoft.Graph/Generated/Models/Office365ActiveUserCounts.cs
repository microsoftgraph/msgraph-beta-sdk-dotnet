// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Office365ActiveUserCounts : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of active users in Exchange. Any user who can read and send email is considered an active user.</summary>
        public long? Exchange
        {
            get { return BackingStore?.Get<long?>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
        /// <summary>The number of active users in Microsoft 365. This number includes all the active users in Exchange, OneDrive, SharePoint, Skype For Business, Yammer, and Microsoft Teams. You can find the definition of active user for each product in the respective property description.</summary>
        public long? Office365
        {
            get { return BackingStore?.Get<long?>("office365"); }
            set { BackingStore?.Set("office365", value); }
        }
        /// <summary>The number of active users in OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public long? OneDrive
        {
            get { return BackingStore?.Get<long?>("oneDrive"); }
            set { BackingStore?.Set("oneDrive", value); }
        }
        /// <summary>The date on which a number of users were active.</summary>
        public Date? ReportDate
        {
            get { return BackingStore?.Get<Date?>("reportDate"); }
            set { BackingStore?.Set("reportDate", value); }
        }
        /// <summary>The number of days the report covers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportPeriod
        {
            get { return BackingStore?.Get<string?>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#nullable restore
#else
        public string ReportPeriod
        {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#endif
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate
        {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The number of active users in SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public long? SharePoint
        {
            get { return BackingStore?.Get<long?>("sharePoint"); }
            set { BackingStore?.Set("sharePoint", value); }
        }
        /// <summary>The number of active users in Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public long? SkypeForBusiness
        {
            get { return BackingStore?.Get<long?>("skypeForBusiness"); }
            set { BackingStore?.Set("skypeForBusiness", value); }
        }
        /// <summary>The number of active users in Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public long? Teams
        {
            get { return BackingStore?.Get<long?>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
        /// <summary>The number of active users in Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public long? Yammer
        {
            get { return BackingStore?.Get<long?>("yammer"); }
            set { BackingStore?.Set("yammer", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Office365ActiveUserCounts"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Office365ActiveUserCounts CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Office365ActiveUserCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "exchange", n => { Exchange = n.GetLongValue(); } },
                { "office365", n => { Office365 = n.GetLongValue(); } },
                { "oneDrive", n => { OneDrive = n.GetLongValue(); } },
                { "reportDate", n => { ReportDate = n.GetDateValue(); } },
                { "reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                { "reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                { "sharePoint", n => { SharePoint = n.GetLongValue(); } },
                { "skypeForBusiness", n => { SkypeForBusiness = n.GetLongValue(); } },
                { "teams", n => { Teams = n.GetLongValue(); } },
                { "yammer", n => { Yammer = n.GetLongValue(); } },
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
            writer.WriteLongValue("exchange", Exchange);
            writer.WriteLongValue("office365", Office365);
            writer.WriteLongValue("oneDrive", OneDrive);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePoint", SharePoint);
            writer.WriteLongValue("skypeForBusiness", SkypeForBusiness);
            writer.WriteLongValue("teams", Teams);
            writer.WriteLongValue("yammer", Yammer);
        }
    }
}
#pragma warning restore CS0618

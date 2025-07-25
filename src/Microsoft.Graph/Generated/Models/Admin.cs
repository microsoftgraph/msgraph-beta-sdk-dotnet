// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.TeamsAdministration;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Admin : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The appsAndServices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminAppsAndServices? AppsAndServices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminAppsAndServices?>("appsAndServices"); }
            set { BackingStore?.Set("appsAndServices", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminAppsAndServices AppsAndServices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminAppsAndServices>("appsAndServices"); }
            set { BackingStore?.Set("appsAndServices", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The configurationManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ConfigurationManagement? ConfigurationManagement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConfigurationManagement?>("configurationManagement"); }
            set { BackingStore?.Set("configurationManagement", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ConfigurationManagement ConfigurationManagement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConfigurationManagement>("configurationManagement"); }
            set { BackingStore?.Set("configurationManagement", value); }
        }
#endif
        /// <summary>The dynamics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminDynamics? Dynamics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminDynamics?>("dynamics"); }
            set { BackingStore?.Set("dynamics", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminDynamics Dynamics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminDynamics>("dynamics"); }
            set { BackingStore?.Set("dynamics", value); }
        }
#endif
        /// <summary>A container for Microsoft Edge resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Edge? Edge
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Edge?>("edge"); }
            set { BackingStore?.Set("edge", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Edge Edge
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Edge>("edge"); }
            set { BackingStore?.Set("edge", value); }
        }
#endif
        /// <summary>A container for Microsoft Entra resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Entra? Entra
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Entra?>("entra"); }
            set { BackingStore?.Set("entra", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Entra Entra
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Entra>("entra"); }
            set { BackingStore?.Set("entra", value); }
        }
#endif
        /// <summary>A container for the Exchange admin functionality. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ExchangeAdmin? Exchange
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExchangeAdmin?>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ExchangeAdmin Exchange
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExchangeAdmin>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
#endif
        /// <summary>The forms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminForms? Forms
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminForms?>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminForms Forms
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminForms>("forms"); }
            set { BackingStore?.Set("forms", value); }
        }
#endif
        /// <summary>A container for the Microsoft 365 apps admin functionality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps? Microsoft365Apps
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps?>("microsoft365Apps"); }
            set { BackingStore?.Set("microsoft365Apps", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps Microsoft365Apps
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps>("microsoft365Apps"); }
            set { BackingStore?.Set("microsoft365Apps", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents a setting to control people-related admin settings in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PeopleAdminSettings? People
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PeopleAdminSettings?>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PeopleAdminSettings People
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PeopleAdminSettings>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#endif
        /// <summary>A container for administrative resources to manage reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminReportSettings? ReportSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminReportSettings?>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminReportSettings ReportSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminReportSettings>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#endif
        /// <summary>A container for service communications resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ServiceAnnouncement? ServiceAnnouncement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ServiceAnnouncement?>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ServiceAnnouncement ServiceAnnouncement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#endif
        /// <summary>The sharepoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Sharepoint? Sharepoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Sharepoint?>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Sharepoint Sharepoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Sharepoint>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#endif
        /// <summary>Represents a collection of user configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot? Teams
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot?>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot Teams
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
#endif
        /// <summary>The todo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminTodo? Todo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminTodo?>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminTodo Todo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminTodo>("todo"); }
            set { BackingStore?.Set("todo", value); }
        }
#endif
        /// <summary>A container for all Windows administrator functionalities. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AdminWindows? Windows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminWindows?>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AdminWindows Windows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AdminWindows>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Admin"/> and sets the default values.
        /// </summary>
        public Admin()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Admin"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Admin CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appsAndServices", n => { AppsAndServices = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminAppsAndServices>(global::Microsoft.Graph.Beta.Models.AdminAppsAndServices.CreateFromDiscriminatorValue); } },
                { "configurationManagement", n => { ConfigurationManagement = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ConfigurationManagement>(global::Microsoft.Graph.Beta.Models.ConfigurationManagement.CreateFromDiscriminatorValue); } },
                { "dynamics", n => { Dynamics = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminDynamics>(global::Microsoft.Graph.Beta.Models.AdminDynamics.CreateFromDiscriminatorValue); } },
                { "edge", n => { Edge = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Edge>(global::Microsoft.Graph.Beta.Models.Edge.CreateFromDiscriminatorValue); } },
                { "entra", n => { Entra = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Entra>(global::Microsoft.Graph.Beta.Models.Entra.CreateFromDiscriminatorValue); } },
                { "exchange", n => { Exchange = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ExchangeAdmin>(global::Microsoft.Graph.Beta.Models.ExchangeAdmin.CreateFromDiscriminatorValue); } },
                { "forms", n => { Forms = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminForms>(global::Microsoft.Graph.Beta.Models.AdminForms.CreateFromDiscriminatorValue); } },
                { "microsoft365Apps", n => { Microsoft365Apps = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps>(global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "people", n => { People = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PeopleAdminSettings>(global::Microsoft.Graph.Beta.Models.PeopleAdminSettings.CreateFromDiscriminatorValue); } },
                { "reportSettings", n => { ReportSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminReportSettings>(global::Microsoft.Graph.Beta.Models.AdminReportSettings.CreateFromDiscriminatorValue); } },
                { "serviceAnnouncement", n => { ServiceAnnouncement = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ServiceAnnouncement>(global::Microsoft.Graph.Beta.Models.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                { "sharepoint", n => { Sharepoint = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Sharepoint>(global::Microsoft.Graph.Beta.Models.Sharepoint.CreateFromDiscriminatorValue); } },
                { "teams", n => { Teams = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot>(global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot.CreateFromDiscriminatorValue); } },
                { "todo", n => { Todo = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminTodo>(global::Microsoft.Graph.Beta.Models.AdminTodo.CreateFromDiscriminatorValue); } },
                { "windows", n => { Windows = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AdminWindows>(global::Microsoft.Graph.Beta.Models.AdminWindows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminAppsAndServices>("appsAndServices", AppsAndServices);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ConfigurationManagement>("configurationManagement", ConfigurationManagement);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminDynamics>("dynamics", Dynamics);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Edge>("edge", Edge);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Entra>("entra", Entra);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ExchangeAdmin>("exchange", Exchange);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminForms>("forms", Forms);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminMicrosoft365Apps>("microsoft365Apps", Microsoft365Apps);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PeopleAdminSettings>("people", People);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminReportSettings>("reportSettings", ReportSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Sharepoint>("sharepoint", Sharepoint);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamsAdministration.TeamsAdminRoot>("teams", Teams);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminTodo>("todo", Todo);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AdminWindows>("windows", Windows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

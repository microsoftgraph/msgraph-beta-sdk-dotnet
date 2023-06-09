using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Analytics;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Children;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Content;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ListItem;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkout;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Copy;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateLink;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateUploadSession;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Follow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Invite;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Preview;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Restore;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Unfollow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ValidatePermission;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Permissions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Subscriptions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Thumbnails;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook;
using Microsoft.Graph.Beta.Drives.Item.List.Items.Item.Versions;
using Microsoft.Kiota.Abstractions;

namespace Microsoft.Graph.Beta;

public static class DriveItemRequestBuilderExtensions
{
    /// <summary>
    /// Gets drive item request builder for the specified drive item path.
    /// <returns>The drive item request builder.</returns>
    /// </summary>
    public static CustomDriveItemItemRequestBuilder ItemWithPath(this Microsoft.Graph.Beta.Drives.Item.Root.RootRequestBuilder rootRequestBuilder, string path)
    {
        if (!string.IsNullOrEmpty(path))
        {
            if (!path.StartsWith("/"))
            {
                path = string.Format("/{0}", path);
            }
        }
        
        var requestInformation = rootRequestBuilder.ToGetRequestInformation();
        // Encode the path in accordance with the one drive spec
        // https://docs.microsoft.com/en-us/onedrive/developer/rest-api/concepts/addressing-driveitems
        UriBuilder builder = new UriBuilder(requestInformation.URI.OriginalString);
        builder.Path += $":{path}:";
        var parameter = builder.Uri.OriginalString.Split(new []{':'},StringSplitOptions.RemoveEmptyEntries).Last();
        return new CustomDriveItemItemRequestBuilder(rootRequestBuilder.GetPathParameters(),rootRequestBuilder.GetRequestAdapter(), rootRequestBuilder.GetUrlTemplate().Replace("root",$"root:{parameter}:"));
    }

    /// <summary>
    /// Gets drive item request builder for the specified drive item path.
    /// <returns>The drive item request builder.</returns>
    /// </summary>
    public static CustomDriveItemItemRequestBuilder ItemWithPath(this Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder rootRequestBuilder, string path)
    {
        if (!string.IsNullOrEmpty(path))
        {
            if (!path.StartsWith("/"))
            {
                path = string.Format("/{0}", path);
            }
        }
        
        var requestInformation = rootRequestBuilder.ToGetRequestInformation();
        // Encode the path in accordance with the one drive spec
        // https://docs.microsoft.com/en-us/onedrive/developer/rest-api/concepts/addressing-driveitems
        UriBuilder builder = new UriBuilder(requestInformation.URI.OriginalString);
        builder.Path += $":{path}:";
        var parameter = builder.Uri.OriginalString.Split(new []{':'},StringSplitOptions.RemoveEmptyEntries).Last();
        return new CustomDriveItemItemRequestBuilder(rootRequestBuilder.GetPathParameters(), rootRequestBuilder.GetRequestAdapter(),rootRequestBuilder.GetUrlTemplate().Replace("{driveItem%2Did}",$"{{driveItem%2Did}}:{parameter}:"));
    }

    private static IRequestAdapter GetRequestAdapter(this object obj) {
        var field = obj.GetType()
                        .BaseType!
                        .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                        .FirstOrDefault( field => field.FieldType == typeof(IRequestAdapter));
        return (IRequestAdapter)field?.GetValue(obj);
    }
    private static Dictionary<string, object> GetPathParameters(this object obj) {
        var field = obj.GetType()
            .BaseType!
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault( field => field.FieldType == typeof(Dictionary<string, object>));
        return (Dictionary<string, object>)field?.GetValue(obj);
    }
    private static string GetUrlTemplate(this object obj) {
        var field = obj.GetType()
            .BaseType!
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault( field => field.FieldType == typeof(string));
        return (string)field?.GetValue(obj);
    }
    internal static T UpdateUrlTemplate<T>(this T obj, string baseTemplate) where T : BaseRequestBuilder{
        var field = obj.GetType()
            .BaseType!
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault( field => field.FieldType == typeof(string));
        var currentTemplate = (string)field?.GetValue(obj);
        var templateSuffix = currentTemplate.Substring(currentTemplate.LastIndexOf('/'));
        var originalPrefix = baseTemplate.Substring(0,baseTemplate.LastIndexOf(':')+1);
        var updatedTemplate = originalPrefix +templateSuffix;
        field?.SetValue(obj,updatedTemplate);
        return obj;
    }
}

public class CustomDriveItemItemRequestBuilder : Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder
{
    /// <summary>
    /// Instantiates a new DriveItemItemRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">The path parameters to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    /// <param name="urlTemplate">The UrlTemplate to use to execute the requests.</param>
    public CustomDriveItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string urlTemplate): base(pathParameters,requestAdapter)
    {
        _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
        _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
        this.PathParameters = pathParameters;
        this.RequestAdapter = requestAdapter;
        this.UrlTemplate = urlTemplate;
    }

    /// <summary>Provides operations to manage the analytics property of the microsoft.graph.driveItem entity.</summary>
    public new AnalyticsRequestBuilder Analytics
    {
        get => new AnalyticsRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the checkin method.</summary>
    public new CheckinRequestBuilder Checkin
    { 
        get => new CheckinRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the checkout method.</summary>
    public new CheckoutRequestBuilder Checkout
    { 
        get => new CheckoutRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }

    /// <summary>Provides operations to manage the children property of the microsoft.graph.driveItem entity.</summary>
    public new ChildrenRequestBuilder Children 
    {
        get => new ChildrenRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }

    /// <summary>Provides operations to manage the media for the drive entity.</summary>
    public new ContentRequestBuilder Content 
    { 
        get => new ContentRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the copy method.</summary>
    public new CopyRequestBuilder Copy
    { 
        get => new CopyRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the createLink method.</summary>
    public new CreateLinkRequestBuilder CreateLink
    { 
        get => new CreateLinkRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the createUploadSession method.</summary>
    public new CreateUploadSessionRequestBuilder CreateUploadSession
    {
        get => new CreateUploadSessionRequestBuilder(PathParameters , RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the follow method.</summary>
    public new FollowRequestBuilder Follow
    { 
        get => new FollowRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the invite method.</summary>
    public new InviteRequestBuilder Invite
    { 
        get => new InviteRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the listItem property of the microsoft.graph.driveItem entity.</summary>
    public new ListItemRequestBuilder ListItem { 
        get => new ListItemRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the permissions property of the microsoft.graph.driveItem entity.</summary>
    public new PermissionsRequestBuilder Permissions { 
        get => new PermissionsRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the preview method.</summary>
    public new PreviewRequestBuilder Preview
    { 
        get => new PreviewRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the restore method.</summary>
    public new RestoreRequestBuilder Restore
    { 
        get => new RestoreRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.driveItem entity.</summary>
    public new SubscriptionsRequestBuilder Subscriptions 
    { 
        get => new SubscriptionsRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the thumbnails property of the microsoft.graph.driveItem entity.</summary>
    public new ThumbnailsRequestBuilder Thumbnails 
    { 
        get => new ThumbnailsRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the unfollow method.</summary>
    public new UnfollowRequestBuilder Unfollow
    { 
        get => new UnfollowRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to call the validatePermission method.</summary>
    public new ValidatePermissionRequestBuilder ValidatePermission
    { 
        get => new ValidatePermissionRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the versions property of the microsoft.graph.driveItem entity.</summary>
    public new VersionsRequestBuilder Versions 
    {
        get => new VersionsRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
    /// <summary>Provides operations to manage the workbook property of the microsoft.graph.driveItem entity.</summary>
    public new WorkbookRequestBuilder Workbook 
    { 
        get => new WorkbookRequestBuilder(PathParameters, RequestAdapter).UpdateUrlTemplate(this.UrlTemplate);
    }
}

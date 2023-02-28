using System;
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
using Microsoft.Graph.Beta.Drives.Item.List.Items.Item.Versions;
using Microsoft.Kiota.Abstractions;

namespace Microsoft.Graph;

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
        var requestAdapter = rootRequestBuilder.GetRequestAdapter();
        var requestUrl = requestInformation.URI.OriginalString;
        
        // Encode the path in accordance with the one drive spec 
        // https://docs.microsoft.com/en-us/onedrive/developer/rest-api/concepts/addressing-driveitems
        UriBuilder builder = new UriBuilder(requestUrl);
        builder.Path += string.Format(":{0}:", path);
        

        return new CustomDriveItemItemRequestBuilder(builder.Uri.OriginalString, requestAdapter);
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
        var requestAdapter = rootRequestBuilder.GetRequestAdapter();
        var requestUrl = requestInformation.URI.OriginalString;
        
        // Encode the path in accordance with the one drive spec 
        // https://docs.microsoft.com/en-us/onedrive/developer/rest-api/concepts/addressing-driveitems
        UriBuilder builder = new UriBuilder(requestUrl);
        builder.Path += string.Format(":{0}:", path);
        

        return new CustomDriveItemItemRequestBuilder(builder.Uri.OriginalString, requestAdapter);
    }
    
    private static IRequestAdapter GetRequestAdapter(this object obj) {
        var field = obj.GetType()
                        .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                        .FirstOrDefault( field => field.FieldType.Equals(typeof(IRequestAdapter)));
        return (IRequestAdapter)field?.GetValue(obj);
    }
}

public class CustomDriveItemItemRequestBuilder : Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder
{
    private readonly string _rawUrl; 
    /// <summary>
    /// Instantiates a new DriveItemItemRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CustomDriveItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter): base(rawUrl,requestAdapter)
    {
        if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
        _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
        this._rawUrl = rawUrl;
        this.RequestAdapter = requestAdapter;
    }
    
    /// <summary>Provides operations to manage the analytics property of the microsoft.graph.driveItem entity.</summary>
    public new AnalyticsRequestBuilder Analytics { get =>
        new AnalyticsRequestBuilder(this._rawUrl + "/analytics", RequestAdapter);
    }
    /// <summary>Provides operations to call the checkin method.</summary>
    public new CheckinRequestBuilder Checkin { get =>
        new CheckinRequestBuilder(this._rawUrl + "/microsoft.graph.checkin", RequestAdapter);
    }
    /// <summary>Provides operations to call the checkout method.</summary>
    public new CheckoutRequestBuilder Checkout { get =>
        new CheckoutRequestBuilder(this._rawUrl + "/microsoft.graph.checkout", RequestAdapter);
    }
    /// <summary>Provides operations to manage the children property of the microsoft.graph.driveItem entity.</summary>
    public new ChildrenRequestBuilder Children { get =>
        new ChildrenRequestBuilder(this._rawUrl + "/children", RequestAdapter);
    }
    /// <summary>Provides operations to manage the media for the drive entity.</summary>
    public new ContentRequestBuilder Content { get =>
        new ContentRequestBuilder(this._rawUrl + "/content", RequestAdapter);
    }
    /// <summary>Provides operations to call the copy method.</summary>
    public new CopyRequestBuilder Copy { get =>
        new CopyRequestBuilder(this._rawUrl + "/microsoft.graph.copy", RequestAdapter);
    }
    /// <summary>Provides operations to call the createLink method.</summary>
    public new CreateLinkRequestBuilder CreateLink { get =>
        new CreateLinkRequestBuilder(this._rawUrl + "/microsoft.graph.createLink", RequestAdapter);
    }
    /// <summary>Provides operations to call the createUploadSession method.</summary>
    public new CreateUploadSessionRequestBuilder CreateUploadSession { get =>
        new CreateUploadSessionRequestBuilder(this._rawUrl+"/microsoft.graph.createUploadSession" , RequestAdapter);
    }
    /// <summary>Provides operations to call the follow method.</summary>
    public new FollowRequestBuilder Follow { get =>
        new FollowRequestBuilder(this._rawUrl + "/microsoft.graph.follow", RequestAdapter);
    }
    /// <summary>Provides operations to call the invite method.</summary>
    public new InviteRequestBuilder Invite { get =>
        new InviteRequestBuilder(this._rawUrl + "/microsoft.graph.invite", RequestAdapter);
    }
    /// <summary>Provides operations to manage the listItem property of the microsoft.graph.driveItem entity.</summary>
    public new ListItemRequestBuilder ListItem { get =>
        new ListItemRequestBuilder(this._rawUrl + "/listItem", RequestAdapter);
    }
    /// <summary>Provides operations to manage the permissions property of the microsoft.graph.driveItem entity.</summary>
    public new PermissionsRequestBuilder Permissions { get =>
        new PermissionsRequestBuilder(this._rawUrl+"/permissions", RequestAdapter);
    }
    /// <summary>Provides operations to call the preview method.</summary>
    public new PreviewRequestBuilder Preview { get =>
        new PreviewRequestBuilder(this._rawUrl+"/microsoft.graph.preview", RequestAdapter);
    }
    /// <summary>The request adapter to use to execute the requests.</summary>
    private IRequestAdapter RequestAdapter { get; set; }
    /// <summary>Provides operations to call the restore method.</summary>
    public new RestoreRequestBuilder Restore { get =>
        new RestoreRequestBuilder(this._rawUrl+"/microsoft.graph.restore", RequestAdapter);
    }
    /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.driveItem entity.</summary>
    public new SubscriptionsRequestBuilder Subscriptions { get =>
        new SubscriptionsRequestBuilder(this._rawUrl+"/subscriptions", RequestAdapter);
    }
    /// <summary>Provides operations to manage the thumbnails property of the microsoft.graph.driveItem entity.</summary>
    public new ThumbnailsRequestBuilder Thumbnails { get =>
        new ThumbnailsRequestBuilder(this._rawUrl+"/thumbnails", RequestAdapter);
    }
    /// <summary>Provides operations to call the unfollow method.</summary>
    public new UnfollowRequestBuilder Unfollow { get =>
        new UnfollowRequestBuilder(this._rawUrl+"/microsoft.graph.unfollow", RequestAdapter);
    }
    /// <summary>Provides operations to call the validatePermission method.</summary>
    public new ValidatePermissionRequestBuilder ValidatePermission { get =>
        new ValidatePermissionRequestBuilder(this._rawUrl+"/microsoft.graph.validatePermission", RequestAdapter);
    }
    /// <summary>Provides operations to manage the versions property of the microsoft.graph.driveItem entity.</summary>
    public new VersionsRequestBuilder Versions { get =>
        new VersionsRequestBuilder(this._rawUrl+"/versions", RequestAdapter);
    }
}

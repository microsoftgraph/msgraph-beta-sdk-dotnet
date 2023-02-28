---
title: "deploymentAudience: updateAudienceById"
description: "Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# deploymentAudience: updateAudienceById

Namespace: microsoft.graph.windowsUpdates

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the members and exclusions collections of a [deploymentAudience](../resources/windowsupdates-deploymentaudience.md) with [updatableAsset](../resources/windowsupdates-updatableasset.md) resources of the same type.

Adding an [azureADDevice](../resources/windowsupdates-azureaddevice.md) to the members or exclusions collections of a deployment audience automatically creates an Azure AD device object if it does not already exist.

If the same [updatableAsset](../resources/windowsupdates-updatableasset.md) gets included in the **exclusions** and **members** collections of a **deploymentAudience**, deployment will not apply to that asset.

You can also use the method [updateAudience](windowsupdates-deploymentaudience-updateaudience.md) to update the **deploymentAudience**.

> [!NOTE]
> This API has a [known issue](/Graph/known-issues#accessing-and-updating-deployment-audiences) related to deployments created via Intune.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|WindowsUpdates.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|WindowsUpdates.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /admin/windows/updates/deployments/{deploymentId}/audience/updateAudienceById
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|memberEntityType|String|The full type of the updatable assets. Possible values are: `#microsoft.graph.windowsUpdates.azureADDevice`, `#microsoft.graph.windowsUpdates.updatableAssetGroup`.|
|addMembers|String collection|List of identifiers corresponding to the updatable assets to add as members of the deployment audience.|
|removeMembers|String collection|List of identifiers corresponding to the updatable assets to remove as members of the deployment audience.|
|addExclusions|String collection|List of identifiers corresponding to the updatable assets to add as exclusions from the deployment audience.|
|removeExclusions|String collection|List of identifiers corresponding to the updatable assets to remove as exclusions from the deployment audience.|



## Response

If successful, this action returns a `202 Accepted` response code. It does not return anything in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "deploymentaudience_updateaudiencebyid"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/windows/updates/deployments/b5171742-1742-b517-4217-17b5421717b5/audience/updateAudienceById
Content-Type: application/json

{
  "memberEntityType": "String",
  "addMembers": [
    "String"
  ],
  "removeMembers": [
    "String"
  ],
  "addExclusions": [
    "String"
  ],
  "removeExclusions": [
    "String"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var memberEntityType = "String";

var addMembers = new List<String>()
{
	"String"
};

var removeMembers = new List<String>()
{
	"String"
};

var addExclusions = new List<String>()
{
	"String"
};

var removeExclusions = new List<String>()
{
	"String"
};

await graphClient.Admin.Windows.Updates.Deployments["{windowsUpdates.deployment-id}"].Audience
	.UpdateAudienceById(memberEntityType,addMembers,removeMembers,addExclusions,removeExclusions)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 202 Accepted
```


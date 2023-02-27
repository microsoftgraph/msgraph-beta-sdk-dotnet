---
title: "Add includedGroups" 
description: "Add groups to be included in a mobile app management policy."
author: "ravennMSFT"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Add includedGroups

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add groups to be included in a mobile app management policy.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.MobilityManagement|
|Delegated (personal Microsoft account) | Not supported.|
|Application | Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /policies/mobileAppManagementPolicies/{id}/includedGroups/$ref
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [group](../resources/group.md) object.

The following table shows the properties that are required when you add the [group](../resources/group.md).

|Property|Type|Description|
|:---|:---|:---|
|id|String|The unique identifier for the group.|

## Response

If successful, this method returns a `204 No Content` response code and a [group](../resources/group.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_mobileManagementPolicy_group_from_groups"
}
-->

``` http
POST https://graph.microsoft.com/beta/policies/mobileAppManagementPolicies/ab90bacf-55a3-4a3e-839a-aa4b74e4f020/includedGroups/$ref
Content-Type: application/json

{
  "@odata.id": "https://graph.microsoft.com/odata/groups('1a9db3ab-0acf-4808-99ae-e8ed581cb2e0')"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var group = new Group
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.id", "https://graph.microsoft.com/odata/groups('1a9db3ab-0acf-4808-99ae-e8ed581cb2e0')"}
	}
};

await graphClient.Policies.MobileAppManagementPolicies["{mobilityManagementPolicy-id}"].IncludedGroups.References
	.Request()
	.AddAsync(group);

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
HTTP/1.1 204 No Content
```

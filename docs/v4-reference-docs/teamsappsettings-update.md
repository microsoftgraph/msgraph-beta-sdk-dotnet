---
title: "Update teamsAppSettings"
description: "Update the properties of a teamsAppSettings object."
author: "subray2014"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Update teamsAppSettings
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [teamsAppSettings](../resources/teamsappsettings.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

>**Note:** Only global administrators and Teams administrators can call this API.

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkAppSettings.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|Not supported|

> [!NOTE]
> TeamworkAppSettings.* permissions might not be visible in the Azure portal. For details and workarounds, see [known issues](/graph/known-issues#teamworkappsettings-permissions-are-not-visible-in-the-azure-portal).

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /teamwork/teamsAppSettings
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|allowUserRequestsForAppAccess|Boolean|Indicates whether Teams users are allowed to request admins access to certain Teams apps.|
|isChatResourceSpecificConsentEnabled|Boolean|Indicates whether resource-specific consent for chats/meetings has been enabled for the tenant. If true, Teams apps that are allowed in the tenant and require resource-specific permissions can be installed inside chats and meetings. If false, the installation of any Teams app that requires resource-specific permissions in a chat or a meeting will be blocked.|


## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Enable installation of apps that require resource-specific consent in chats/meetings.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_teamsappsettings_1"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/teamwork/teamsAppSettings
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.teamsAppSettings",
  "isChatResourceSpecificConsentEnabled": "true"
}
```

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 2: Allow Teams users to request admins for access to certain Teams Apps.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_teamsappsettings_2"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/teamwork/teamsAppSettings
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.teamsAppSettings",
  "allowUserRequestsForAppAccess": "true"
}
```

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

## See also

- [Resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent)

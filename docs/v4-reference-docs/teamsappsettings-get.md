---
title: "Get teamsAppSettings"
description: "Read the properties and relationships of a teamsAppSettings object."
author: "subray2014"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Get teamsAppSettings
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [teamsAppSettings](../resources/teamsappsettings.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkAppSettings.Read.All, TeamworkAppSettings.ReadWrite.All|
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
GET /teamwork/teamsAppSettings
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [teamsAppSettings](../resources/teamsappsettings.md) object in the response body.

## Examples

### Example 1: Get the tenant-wide settings for all Teams apps in the tenant.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamsappsettings"
}
-->
``` http
GET https://graph.microsoft.com/beta/teamwork/teamsAppSettings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppSettings = await graphClient.Teamwork.TeamsAppSettings
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsAppSettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.teamsAppSettings",
    "id": "65bdf003-0c4c-4bca-b102-0821ab0d1364",
    "allowUserRequestsForAppAccess": true,
    "isChatResourceSpecificConsentEnabled": "true"
  }
}
```

## See also

- [Resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent)

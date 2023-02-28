---
title: "Add app to team"
description: "Installs an app to the specified team."
author: "akjo"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Add app to team

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Install an [app](../resources/teamsapp.md) to the specified [team](../resources/team.md).

> **Note:** Currently, this operation does not support installation of apps that require resource-specific consent permissions. For details, see [Known issues](/graph/known-issues#installation-of-apps-that-require-resource-specific-consent-permissions-is-not-supported).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | TeamsAppInstallation.ReadWriteSelfForTeam, TeamsAppInstallation.ReadWriteForTeam, Group.ReadWrite.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | TeamsAppInstallation.ReadWriteSelfForTeam.All, TeamsAppInstallation.ReadWriteForTeam.All, Group.ReadWrite.All**, Directory.ReadWrite.All** |

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /teams/{team-id}/installedApps
```

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body

| Property   | Type |Description|
|:---------------|:--------|:----------|
|teamsApp|String|The id of the app to add.|

## Response

If successful, this method returns a `200 OK` response code. It does not return anything in the response body.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "add_app_in_team",
  "sampleKeys": ["87654321-0abc-zqf0-321456789q"]
}-->
```http
POST /teams/87654321-0abc-zqf0-321456789q/installedApps
Content-type: application/json

{
   "teamsApp@odata.bind":"https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppInstallation = new TeamsAppInstallation
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"teamsApp@odata.bind", "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"}
	}
};

await graphClient.Teams["{team-id}"].InstalledApps
	.Request()
	.AddAsync(teamsAppInstallation);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 200 OK
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Add teamsApp",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->



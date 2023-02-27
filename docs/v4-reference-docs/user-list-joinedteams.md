---
title: "List joinedTeams"
description: "Get the teams in Microsoft Teams that the user is a direct member of."
author: "nkramer"
ms.localizationpriority: high
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# List joinedTeams

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the [teams](../resources/team.md) in Microsoft Teams that the user is a direct member of.
> **Note:** This API doesn't return the host team of the shared channel that the user is a direct member of. Use the [List associated teams](../api/associatedteaminfo-list.md) API, to retrieve the host teams of the shared channels that the user has access to.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Team.ReadBasic.All, TeamSettings.Read.All, TeamSettings.ReadWrite.All, User.Read.All, User.ReadWrite.All, Directory.Read.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Team.ReadBasic.All, TeamSettings.Read.All, TeamSettings.ReadWrite.All, User.Read.All, User.ReadWrite.All, Directory.Read.All**, Directory.ReadWrite.All** |

> **Note:** Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

> **Note:** Currently, with user delegated permissions, this operation only works for the `me` user. With application permissions, it works for all users by specifying the specific user ID (`me` alias is not supported with application permissions). For details, see [Known issues](/graph/known-issues#microsoft-teams-users-list-of-joined-teams-preview).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/joinedTeams
GET /users/{id | user-principal-name}/joinedTeams
```

## Optional query parameters
This method does not currently support the [OData query parameters](/graph/query-parameters) to customize the response.

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Accept  | application/json|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [team](../resources/team.md) objects in the response body.

> [!Note]
> Currently, this API call returns only the **id**, **displayName**, and **description** properties of a [team](../resources/team.md). To get all properties, use the [Get team](../api/team-get.md) operation. For details, see [known issues](/graph/known-issues#unable-to-return-all-values-for-properties-for-a-user-joined-teams).


## Example
### Request
The following example shows a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_joinedteams"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/joinedTeams
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var joinedTeams = await graphClient.Me.JoinedTeams
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following example shows the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "172b0cce-e65d-44ce-9a49-91d9f2e8493a",
      "displayName": "Contoso Team",
      "description": "This is a Contoso team, used to showcase the range of properties supported by this API"
    }
  ]
}
```

## See also
- [List all teams](/graph/teams-list-all-teams)
- [List associated teams](../api/associatedteaminfo-list.md)
- [List all teams in an organization](../api/teams-list.md)
- [Get team](../api/team-get.md)


<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List joinedTeams",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->

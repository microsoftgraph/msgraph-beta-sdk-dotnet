---
title: "Remove connected organization internal sponsor"
description: "Remove a user or group from the connected organization's internal sponsors."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Remove connected organization internal sponsor

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Remove a user or a group from the connected organization's internal sponsors. The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | EntitlementManagement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | EntitlementManagement.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganizationId}/internalSponsors/{id}/$ref
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

The following is an example of the request.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_internalsponsor_from_connectedorganization"
}
-->
``` http
DELETE https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganizationId}/internalSponsors/{id}/$ref
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.IdentityGovernance.EntitlementManagement.ConnectedOrganizations["{connectedOrganization-id}"].InternalSponsors["{directoryObject-id}"].Reference
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete connected organization internal sponsor",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->



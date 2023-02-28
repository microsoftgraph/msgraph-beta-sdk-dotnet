---
title: "List agreements"
description: "Retrieve a list of agreement objects."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "raprakasMSFT"
---

# List agreements

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [agreement](../resources/agreement.md) objects.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Agreement.Read.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

When calling on behalf of a user, the user needs to belong to one of the following directory roles. To learn more about directory roles, see [Azure AD built-in roles](/azure/active-directory/roles/permissions-reference):
+ Global Administrator
+ Conditional Access Administrator
+ Security Administrator

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /identityGovernance/termsOfUse/agreements
```


## Optional query parameters
This method supports the `$select`, `$filter`, and `$top` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and collection of [agreement](../resources/agreement.md) objects in the response body.
## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_agreements"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/identityGovernance/termsOfUse/agreements
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var agreements = await graphClient.IdentityGovernance.TermsOfUse.Agreements
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


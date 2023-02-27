---
title: "Update agreement"
description: "Update the properties of an agreement object."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "raprakasMSFT"
---

# Update agreement

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [agreement](../resources/agreement.md) object.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Agreement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

When calling on behalf of a user, the user needs to belong to one of the following directory roles. To learn more about directory roles, see [Azure AD built-in roles](/azure/active-directory/roles/permissions-reference):
+ Global Administrator
+ Conditional Access Administrator
+ Security Administrator

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /identityGovernance/termsOfUse/agreements/{id}
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|displayName|String|Display name of the agreement.|
|isViewingBeforeAcceptanceRequired|Boolean|Whether the user has to expand and view the agreement before accepting.|

## Response
If successful, this method returns a `204 No Content` response code.
## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_agreement"
}-->
```msgraph-interactive
PATCH https://graph.microsoft.com/beta/identityGovernance/termsOfUse/agreements/0ec9f6a6-159d-4dd8-a563-1f0b5935e80b
Content-type: application/json

{
    "displayName": "All Contoso volunteers - Terms of use",
    "isViewingBeforeAcceptanceRequired": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var agreement = new Agreement
{
	DisplayName = "All Contoso volunteers - Terms of use",
	IsViewingBeforeAcceptanceRequired = true
};

await graphClient.IdentityGovernance.TermsOfUse.Agreements["{agreement-id}"]
	.Request()
	.UpdateAsync(agreement);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).


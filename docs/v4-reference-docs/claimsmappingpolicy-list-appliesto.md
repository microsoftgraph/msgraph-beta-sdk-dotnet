---
title: "List appliesTo"
description: "Get a list of directoryObject objects that a claimsMappingPolicy object has been applied to."
ms.localizationpriority: medium
author: "paulgarn"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# List appliesTo

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of [directoryObject](../resources/directoryObject.md) objects that a [claimsMappingPolicy](../resources/claimsmappingpolicy.md) object has been applied to. The claimsMappingPolicy can only be applied to [application](../resources/application.md) and [servicePrincipal](../resources/serviceprincipal.md) resources.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.Read.All and Application.Read.All, Policy.ReadWrite.ApplicationConfiguration and Application.Read.All, Directory.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Policy.Read.All and Application.Read.All, Policy.ReadWrite.ApplicationConfiguration and Application.Read.All, Directory.Read.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /policies/claimsMappingPolicies/{id}/appliesTo
```

## Optional query parameters

This method supports the `$expand`, `$select` and `$top` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters). When using `$expand` make sure your app requests permissions to read the expanded objects.

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token} |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [directoryObject](../resources/directoryobject.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_appliesto_1"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/claimsMappingPolicies/{id}/appliesTo
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var appliesTo = await graphClient.Policies.ClaimsMappingPolicies["{claimsMappingPolicy-id}"].AppliesTo
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.directoryObject",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directoryObjects",
    "value": [
        {
            "@odata.type": "#microsoft.graph.servicePrincipal",
            "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/directoryObjects/335601aa-9c79-48a3-a9f7-d2a6ac9cb730/Microsoft.DirectoryServices.ServicePrincipal",
            "id": "335601aa-9c79-48a3-a9f7-d2a6ac9cb730",
            "accountEnabled": true,
            "createdDateTime": "2021-08-12T07:28:18Z",
            "appDisplayName": "My App",
            "appId": "e4d924fc-d18d-4e69-9a17-7095f311bf17",
            "appOwnerOrganizationId": "84841066-274d-4ec0-a5c1-276be684bdd3",
            "displayName": "My App",
            "publisherName": "Contoso",
            "servicePrincipalNames": [
                "e4d924fc-d18d-4e69-9a17-7095f311bf17"
            ],
            "servicePrincipalType": "Application",
            "signInAudience": "AzureADMyOrg"
        }
    ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List appliesTo",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


---
title: "Get informationProtectionLabel (deprecated)"
description: "Retrieve the properties and relationships of the specified informationProtectionLabel object. Deprecated."
ms.localizationpriority: medium
author: "tommoser"
ms.prod: "security"
doc_type: "apiPageType"
---

# Get informationProtectionLabel (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Information Protection labels API is deprecated and will stop returning data on January 1, 2023. Please use the new [informationProtection](/graph/api/resources/security-informationprotection?view=graph-rest-beta&preserve-view=true), [sensitivityLabel](/graph/api/resources/security-sensitivitylabel?view=graph-rest-beta&preserve-view=true), and associated resources.
Retrieve the properties and relationships of an [informationProtectionLabel](../resources/informationprotectionlabel.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | InformationProtectionPolicy.Read            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | InformationProtectionPolicy.Read.All        |

## HTTP request

<!-- { "blockType": "ignored" } -->
To get a label available to the signed-in user or specified user:
```http
GET /me/informationProtection/policy/labels/{id}
GET /users/{id | user-principal-name}/informationProtection/policy/labels/{id}
```

To get a label available to the organization:
```http
GET /informationProtection/policy/labels/{id}
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description                                                                                                                                                                       |
| :------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Authorization | Bearer {token}. Required.                                                                                                                                                         |
| User-Agent    | Describes the name and version of the calling application. Details will surface in Azure Information Protection Analytics. Suggested format is ApplicationName/Version. Optional. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and the requested [informationProtectionLabel](../resources/informationprotectionlabel.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_informationprotectionlabel"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/me/informationprotection/policy/labels/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var informationProtectionLabel = await graphClient.Me.InformationProtection.Policy.Labels["{informationProtectionLabel-id}"]
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
  "@odata.type": "microsoft.graph.informationProtectionLabel"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json
User-agent: ContosoLOBApp/1.0

{
  "id": "4b18e8bb-b4a5-4695-85d0-8ae23ef27892",
  "name": "Highly Confidential",
  "description": "Consult Contoso data labeling policy for more details.",
  "color": "",
  "sensitivity": 3,
  "tooltip": "Data classified as Contoso Highly Confidential.",
  "isActive": true,
  "parent": null
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get informationProtectionLabel",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



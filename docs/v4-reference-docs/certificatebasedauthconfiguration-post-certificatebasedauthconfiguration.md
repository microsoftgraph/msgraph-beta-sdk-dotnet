---
title: "Create certificateBasedAuthConfiguration"
description: "Use this API to create a new certificateBasedAuthConfiguration."
ms.localizationpriority: medium
author: "adimitui"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Create certificateBasedAuthConfiguration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [certificateBasedAuthConfiguration](../resources/certificateBasedAuthConfiguration.md) object.

> [!NOTE]
> Only a single instance of a **certificateBasedAuthConfiguration** can be created (the collection can only have one member). It always has a fixed ID with a value of '29728ade-6ae4-4ee9-9103-412912537da5'.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Organization.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application    | Organization.ReadWrite.All |

For delegated scenarios, the calling user must have the *Global Administrator* [Azure AD role](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles).

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /organization/{id}/certificateBasedAuthConfiguration
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token} |
| Content-Type | application/json |

## Request body

The following properties are required to create the [certificateBasedAuthConfiguration](../resources/certificatebasedauthconfiguration.md) object.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|certificateAuthorities| [certificateAuthority](../resources/certificateauthority.md) collection |Collection of certificate authorities that creates a trusted certificate chain.  Each member of the collection must contain **certificate** and **isRootAuthority** properties. |

## Response

If successful, this method returns `201 Created` response code and a new [certificateBasedAuthConfiguration](../resources/certificatebasedauthconfiguration.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_certificatebasedauthconfiguration_from_certificatebasedauthconfiguration"
}-->

```http
POST https://graph.microsoft.com/beta/organization/{id}/certificateBasedAuthConfiguration
Content-type: application/json

{
  "certificateAuthorities": [
    {
      "isRootAuthority": true,
      "certificate": "Binary"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var certificateBasedAuthConfiguration = new CertificateBasedAuthConfiguration
{
	CertificateAuthorities = new List<CertificateAuthority>()
	{
		new CertificateAuthority
		{
			IsRootAuthority = true,
			Certificate = Convert.FromBase64String("Binary")
		}
	}
};

await graphClient.Organization["{organization-id}"].CertificateBasedAuthConfiguration
	.Request()
	.AddAsync(certificateBasedAuthConfiguration);

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
  "@odata.type": "microsoft.graph.certificateBasedAuthConfiguration"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "id-value",
  "certificateAuthorities": [
    {
      "isRootAuthority": true,
      "certificate": "Binary",
      "issuer": "issuer-value",
      "issuerSki": "issuerSki-value"
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create certificateBasedAuthConfiguration",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



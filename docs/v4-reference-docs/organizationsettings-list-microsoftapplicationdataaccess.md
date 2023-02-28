---
title: "List microsoftApplicationDataAccessSettings"
description: "Get the settings in a microsoftApplicationDataAccessSettings object that specify access from Microsoft applications to Microsoft 365 user data in an organization."
author: "ttomi"
ms.localizationpriority: medium
ms.prod: "insights"
doc_type: apiPageType
---

# List microsoftApplicationDataAccessSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the _settings_ in a [microsoftApplicationDataAccessSettings](../resources/microsoftapplicationdataaccesssettings.md) object that specify access from Microsoft applications to Microsoft 365 user data in an organization.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) | Organization.Read.All, Organization.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /organization/{organizationId}/settings/microsoftApplicationDataAccess
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoftApplicationDataAccessSettings](../resources/microsoftapplicationdataaccesssettings.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_microsoftapplicationdataaccesssettings"
}
-->
``` http
GET https://graph.microsoft.com/beta/organization/{organizationId}/settings/microsoftApplicationDataAccess
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var microsoftApplicationDataAccessSettings = await graphClient.Organization["{organization-id}"].Settings.MicrosoftApplicationDataAccess
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.microsoftApplicationDataAccessSettings",
  "name": "list_microsoftapplicationdataaccesssettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.microsoftApplicationDataAccessSettings",
  "isEnabledForAllMicrosoftApplications": true,
  "disabledForGroup": "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}
```

## See also

[Customize item insights privacy](/graph/insights-customize-item-insights-privacy) for an organization.

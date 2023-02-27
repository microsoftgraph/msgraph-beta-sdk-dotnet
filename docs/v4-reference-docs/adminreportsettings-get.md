---
title: "Get adminReportSettings"
description: "Get the tenant-level settings for Microsoft 365 reports."
ms.localizationpriority: medium
author: "qiwhuang"
ms.prod: "reports"
doc_type: apiPageType
---

# Get adminReportSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the tenant-level settings for Microsoft 365 reports.

> **Note:** For details about different report views and names, see [Microsoft 365 Reports in the admin center - Microsoft 365 Apps usage](/microsoft-365/admin/activity-reports/microsoft365-apps-usage).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)           |
|:---------------------------------------|:------------------------------------------------------|
| Delegated (work or school account)     | ReportSettings.Read.All, ReportSettings.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                                        |
| Application                            | ReportSettings.Read.All, ReportSettings.ReadWrite.All |

> **Note:** For delegated permissions to allow apps to get report settings on behalf of a user, the tenant administrator must have assigned the user the appropriate Azure Active Directory limited administrator role. For more details, see [Authorization for APIs to read Microsoft 365 usage reports](/graph/reportroot-authorization).

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /admin/reportSettings
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [adminReportSettings](../resources/adminreportsettings.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_adminreportsettings"
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/reportSettings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var adminReportSettings = await graphClient.Admin.ReportSettings
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.adminReportSettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.adminReportSettings",
    "displayConcealedNames": true
  }
}
```

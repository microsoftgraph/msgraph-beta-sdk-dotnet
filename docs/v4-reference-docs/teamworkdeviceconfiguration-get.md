---
title: "Get teamworkDeviceConfiguration"
description: "Get the configuration details of a Microsoft Teams-enabled device."
author: "adsrivastava2"
ms.localizationpriority: medium
ms.prod: "teamwork"
doc_type: apiPageType
---

# Get teamworkDeviceConfiguration
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the [configuration](../resources/teamworkdeviceconfiguration.md) details of a Microsoft Teams-enabled [device](../resources/teamworkdevice.md), including software versions, peripheral device configuration (for example, camera, display, microphone, and speaker), hardware configuration, and Microsoft Teams client configuration.

>**Note**:
> Microsoft is temporarily offering usage of the APIs for managing Microsoft Teams-enabled devices at no charge.
> Microsoft expects to charge for the use of some or all of these APIs in the future. Microsoft will provide advanced notice of pricing changes.
> For details about the current licensing model, see [Licensing and payment requirements](/graph/teams-licenses).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkDevice.Read.All, TeamworkDevice.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|TeamworkDevice.Read.All, TeamworkDevice.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /teamwork/devices/{teamworkDeviceId}/configuration
```

## Optional query parameters
This operation supports the `$select` and `$expand` [OData query parameters](/graph/query-parameters) to customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [teamworkDeviceConfiguration](../resources/teamworkdeviceconfiguration.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamworkdeviceconfiguration"
}
-->
``` http
GET https://graph.microsoft.com/beta/teamwork/devices/e19229ed-29ed-e192-ed29-92e1ed2992e1/configuration
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamworkDeviceConfiguration = await graphClient.Teamwork.Devices["{teamworkDevice-id}"].Configuration
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
  "@odata.type": "microsoft.graph.teamworkDeviceConfiguration"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.teamworkDeviceConfiguration",
    "id": "e19229ed-29ed-e192-ed29-92e1ed2992e1",
    "softwareVersions": {
      "adminAgentSoftwareVersion": "2020.7.10.1",
      "operatingSystemSoftwareVersion": "10.8.9.10",
      "teamsClientSoftwareVersion": "4.5.6.7",
      "firmwareSoftwareVersion": null,
      "partnerAgentSoftwareVersion": null
    },
    "displayConfiguration": {
      "displayCount": 1,
      "isDualDisplayModeEnabled": true,
      "isContentDuplicationAllowed": false,
      "configuredDisplays": [
        {
          "isOptional": false
        },
        {
          "isOptional": true
        }
      ],
      "inBuiltDisplayScreenConfiguration": null
    },
    "cameraConfiguration": {
      "contentCameraConfiguration": {
        "isContentCameraOptional": true,
        "isContentEnhancementEnabled": false,
        "isContentCameraInverted": false
      }
    },
    "speakerConfiguration": {
      "isSpeakerOptional": false,
      "isCommunicationSpeakerOptional": false
    },
    "microphoneConfiguration": {
      "isMicrophoneOptional": false
    },
    "teamsClientConfiguration": {
      "accountConfiguration": {
        "supportedClient": "teamsOnly",
        "onPremisesCalendarSyncConfiguration": {
          "smtpAddress": "john@contoso.com",
          "domainUserName": null,
          "domain": "contoso.com"
        }
      },
      "featuresConfiguration": {
        "isAutoScreenShareEnabled": false,
        "isHideMeetingNamesEnabled": false,
        "isBluetoothBeaconingEnabled": true,
        "isSendLogsAndFeedbackEnabled": true,
        "emailToSendLogsAndFeedback": "john@contoso.com"
      }
    },
    "hardwareConfiguration": {
      "processorModel": "Intel(R) Core(TM) i5-7300U CPU @ 2.60GHz"
    },
    "systemConfiguration": null,
    "createdDateTime": "2021-03-19T19:00:04.000Z",
    "lastModifiedDateTime": "2021-06-19T19:01:04.185Z",
    "createdBy": null,
    "lastModifiedBy": null
  }
}
```


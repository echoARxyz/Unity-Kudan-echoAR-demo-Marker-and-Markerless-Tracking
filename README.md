# Unity-Kudan-echoAR-demo-Marker-and-Markerless-Tracking
Example demo that uses marker and markerless tracking with Unity, Kudan, and echoAR.

## Register
Don't have an API key? Make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
* Download and install the Kudan SDK in a new Unity project (note: Kudan only works on Unity 2018 and earlier).
* Enter your Kudan API Key into the Kudan Camera object on the Unity Editor.
* Create a new scene and add the Angel Bundle from KudanAR/Prefabs.
* On the MarkerTracking object nested below Kudan Camera, press "Add KARMarker Asset" and select ImageMarkers.KARMarker from the [Assets folder](/Assets).
* Click the Markers dropdown arrow within MarkerTracking to show the list of Kudan Markers. Replace the existing marker with the NewKudanTrackable object that was created.
* Install the echoAR SDK into the project.
* Follow the instructions on our [doumention page](https://docs.echoar.xyz/unity/adding-ar-capabilities) to [set your API key](https://docs.echoar.xyz/unity/adding-ar-capabilities#3-set-you-api-key).
* Overwrite the existing _echoAR/CustomBehavior.cs script with the new [CustomBehavior](https://github.com/echoARxyz/Unity-ARFoundation-echoAR-demo-Living-Room-TV/blob/master/CustomBehavior.cs) file.
* Replace the angelStatue in Drivers/Marker and the Capsule in Drivers/Markerless with two echoAR prefabs.
* Add an apartment model into the echoAR console and use the metadata from Metadata.csv.


## Run
* [Build and run the AR application](https://docs.echoar.xyz/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).
* To change which image is being tracked at runtime for marker tracking, replace the "imageKey" attribute in the console with either "clouds", "lego", or "leaves" for the corresponding image in the [Images folder](/Images).


## Learn more
Refer to our [documentation](https://docs.echoar.xyz/unity/) to learn more about how to use Unity and echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE). 

## Screenshots
![console](/Screenshots/echoAR_Console.png)
![marker](/Screenshots/Marker.gif)
![merkerless](/Screenshots/Markerless.gif)

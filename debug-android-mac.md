JeffDUnity3D, Unity Technologies. (2017). "For troubleshooting and debugging, it is often very helpful to capture the device logs. The device logs contain information about the status of a running application on the device and any errors encountered. The IAP Engineering team requires logs for open issues. It is assumed here that you have an Android device configured with Developer options and attached to a PC with a USB cable." Source: https://forum.unity.com/threads/how-to-capturing-device-logs-on-android.528680/

The steps below show the process on a Mac, if you are interested on the Windows system process, check the link quoted previously.

### Mac
  1. Find the location of the Android SDK in Unity by going to Unity > Preferences (Shortcut: , + Cmd) > External Tools.
  2. Copy the location of the Android SDK.
  3. Open the Terminal (Cmd + Space, then type Terminal).
  4. Go to the Android SDK directory by typing: cd (Cmd + V to paste Android SDK location).
  5. With the device connected via USB, run the following command: ./adb devices
  6. If everything is correct you will see your device's serial number followed by the word "device".
  7. Run: ./adb logcat | grep -i unity
  
After completing all previous steps, if you run your project on your android device you will see the contents of your device log that are associated with the running Unity application.


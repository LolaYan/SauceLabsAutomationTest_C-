# SauceLabsAutomationTest_CSharp

Pre-Setting:

1. Sauce Labs account registered.

2. Appium installed.

3. AVD - Android Virtual Device is connected.

4. (Optional) Genymotion Simulator installed.

5. Real mobile device is connected, using command 'adb devices' to detect the device. Make sure the device can be detected by adb.


How to configure the running mode?

This project support diferent running mode in different platform - local appium running, cloud sauce labs running, remote appium running.

<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/setting.JPG"/>
</p>

For configuration, 

if localAppiumRunMode is equal to "ON", localAppiumURI = "http://127.0.0.1:4723/wd/hub";

if localAppiumRunMode is not equal to "ON", localAppiumURI = "http://SauceUsername:SauceUserkey@seleniumURI/wd/hub";

seleniumURI can be configured to @ondemand.saucelabs.com:80, @remoteip:4445, @localhost:4445 based on requirements.

After everything is configured as you want, you can go to the tests, right click 'Run Test.' and give it a go.

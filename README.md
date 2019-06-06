
# react-native-ios-wifi

## Getting started

`$ npm install react-native-ios-wifi --save`

### Mostly automatic installation

`$ react-native link react-native-ios-wifi`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ios-wifi` and add `RNReactNativeIosWifi.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeIosWifi.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeIosWifiPackage;` to the imports at the top of the file
  - Add `new RNReactNativeIosWifiPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ios-wifi'
  	project(':react-native-ios-wifi').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ios-wifi/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ios-wifi')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeIosWifi.sln` in `node_modules/react-native-ios-wifi/windows/RNReactNativeIosWifi.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Ios.Wifi.RNReactNativeIosWifi;` to the usings at the top of the file
  - Add `new RNReactNativeIosWifiPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeIosWifi from 'react-native-ios-wifi';

// TODO: What to do with the module?
RNReactNativeIosWifi;
```


# react-native-net-helper

## Getting started

`$ npm install react-native-net-helper --save`

### Mostly automatic installation

`$ react-native link react-native-net-helper`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-net-helper` and add `RNNetHelper.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNetHelper.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNetHelperPackage;` to the imports at the top of the file
  - Add `new RNNetHelperPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-net-helper'
  	project(':react-native-net-helper').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-net-helper/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-net-helper')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNetHelper.sln` in `node_modules/react-native-net-helper/windows/RNNetHelper.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Net.Helper.RNNetHelper;` to the usings at the top of the file
  - Add `new RNNetHelperPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNetHelper from 'react-native-net-helper';

// TODO: What to do with the module?
RNNetHelper;
```
  
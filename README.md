
# react-native-welcome-screen

![Alt Text](https://github.com/deboajagbe/react-native-welcome-screen/raw/master/s1.png =250x50)
![Alt Text](https://github.com/deboajagbe/react-native-welcome-screen/raw/master/s2.png =250x)
![Alt Text](https://github.com/deboajagbe/react-native-welcome-screen/raw/master/s3.png =250x)
![Alt Text](https://github.com/deboajagbe/react-native-welcome-screen/raw/master/s4.png =250x)
![Alt Text](https://github.com/deboajagbe/react-native-welcome-screen/raw/master/s5.png =250x)

## Getting started

`$ npm install react-native-welcome-screen --save`

### Mostly automatic installation

`$ react-native link react-native-welcome-screen`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-welcome-screen` and add `RNWelcomeScreen.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNWelcomeScreen.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNWelcomeScreenPackage;` to the imports at the top of the file
  - Add `new RNWelcomeScreenPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-welcome-screen'
  	project(':react-native-welcome-screen').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-welcome-screen/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-welcome-screen')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNWelcomeScreen.sln` in `node_modules/react-native-welcome-screen/windows/RNWelcomeScreen.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Com.Reactlibrary.RNWelcomeScreen;` to the usings at the top of the file
  - Add `new RNWelcomeScreenPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNWelcomeScreen from 'react-native-welcome-screen';

// TODO: What to do with the module?
RNWelcomeScreen;
```
  

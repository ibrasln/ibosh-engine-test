# ibosh-engine

# Custom Debugger
## Overview
 This toolset provides you with a range of features to simplify and improve your debugging process, making your Unity projects more efficient and maintainable.

## Features
**- Colorful Debug Messages:** Make your debug messages stand out by adding vibrant colors to them. Ibosh Custom Debugger offers a variety of colors to choose from, allowing you to visually differentiate your logs.

**- Custom Headers:** Organize your debug output effectively by using custom headers for your log messages. Clearly label and categorize your debug information to maintain clarity in your project.

**- Debug Validation:** Ensure your code runs smoothly with the built-in validation methods. Use these tools during Unity's OnValidate() phase to identify and fix common issues early in development.

**- Streamlined Debugging:** Simplify your debugging workflow with easy-to-use methods for logging messages, errors, and warnings. It helps you debug efficiently and effectively, speeding up your development process.

**- Conditional Debugging:** Control when your debug messages appear by leveraging Unity's isDebugBuild option. Messages are displayed only when needed, reducing clutter and distractions during development.


# Singleton
## Overview
 This is a versatile Unity component that simplifies the creation of singleton objects. Singletons are often used to manage resources or services that should have only one instance throughout the lifetime of your game. With this component, you can easily create singletons for various purposes in your Unity project.

## Features
**- Easy Singleton Creation:** It provides a straightforward way to create singletons for your MonoBehaviours. Simply inherit from IboshSingleton<T> and let the component handle the rest.

**- Singleton Enforcement:** It ensures that only one instance of the specified MonoBehaviour type exists at any given time. If multiple instances are detected, it logs an error message and destroys the extra instances, keeping your project clean and efficient.

## Example
![singleton](https://github.com/ibrasln/ibosh-engine/assets/75907428/8898311c-90bd-417f-bfe4-ca6bf847e184)


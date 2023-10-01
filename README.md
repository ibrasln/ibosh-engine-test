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
<img src="https://github.com/ibrasln/ibosh-engine/assets/75907428/8898311c-90bd-417f-bfe4-ca6bf847e184" alt="image" width="75%" height="450">

# Object Pool
## Overview
 It is a utility class that simplifies the management and reuse of GameObjects, providing an efficient way to handle frequently created and destroyed objects. Object pooling helps reduce the performance overhead associated with instantiating and destroying objects, making it a valuable tool for optimizing your Unity projects.

## Features
**- Efficient Object Reuse:** It allows you to create a pool of GameObjects and efficiently reuse them as needed, eliminating the performance cost of frequent object instantiation and destruction.

**- Customizable Pool Size:** You can define the initial pool size and dynamically adjust it based on your project's requirements.

**- Automatic Pool Filling:** It automatically fills the pool with objects up to the specified initial size, ensuring that you always have a ready supply of objects to use.

**- Integration Flexibility:** It is designed to work with any GameObject-based components, offering flexibility in integrating it with various parts of your Unity project.

## Example

<img src="https://github.com/ibrasln/ibosh-engine/assets/75907428/fd2118d5-7884-47fa-9940-3b6c40a7300c" alt="image" width="75%" height="auto">
<img src="https://github.com/ibrasln/ibosh-engine/assets/75907428/ff3e40d0-34f6-41ab-af17-65067daffd51" alt="image" width="75%" height="auto">


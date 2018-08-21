# Common Structures #
This repository is for creating fast access data structures for C# in Unity and other general applications.

*So, why create this?*

Well, typically the standard .NET or Mono data structures are fine, but in the context of game development, I 
want to aim for fast data structures which do not typically generate garbage on runtime and can be value based 
instead of reference based.

Use of **unsafe** keyword may be used for manual memory management.

This is ***highly*** experimental and ***really*** considered me reinventing the wheel - which may not be considered a good 
thing for most devs.

Updates may not be regular and is highly dependent/influenced by a private project I'm working on.

## Project Structure ##
The project includes two assembly definition files,
* `CommonStructures`
  * Holds all recreated data structures.
* `CommonStructures.Tests`
  * Holds all tests related to the data structures. As the data structures tend to get more complex, these tests 
  will be necessary.

## Quickstart ##
To use this in your project, clone this is as git submodule into a directory in your project. If your project 
uses an assembly file, simply add it as a dependency in your `.asm` file. Otherwise, you can use this in your 
Unity projects as a standalone without an assembly file.

## Structures ##
* Tuples
* Matrix (coming soon)


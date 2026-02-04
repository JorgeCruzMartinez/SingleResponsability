# SingleResponsability
Example 4 first SOLID principle

## Description
Many design patterns were developed with SOLID principles in mind and therefore it will be hard to learn about them unless we know SOLID principles, so precisely the purpose of it is to show the evolution of code for the first principle in the book titled "The easiest way to learn design patterns With C#" and learn about what is needed to be done in order to avoid setting all the functionality ONLY in one place.

The original code is supossed to work (but in fact it has errors), but it will be relatively difficult to modify and because everything is in one place it will take longer to read than it could have been. This is just a simple example, but how difficult is in a real-life console app with way more complicated functionality?

It is crucially important that we understand the code before making any changes to it, otherwise we would inadvertently introduce bugs and so we will have to read the entire class, even if only a tiny subset of it is responsible for a particular functionality that we are interested in. Otherwise, how would we know if there is nothing else in the class that will be affected by our changes?

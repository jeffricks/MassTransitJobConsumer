# MassTransit Job Consumer Deserialization Issue

This project is a clone of the original MassTransit Job Consumer example with the following changes:

- Updated dependencies (e.g. projects to .NET 6, MassTransit to v8.0.3, etc)
- Added MassTransit.Newtonsoft package
- Modified to use SQLServer instead of Pgsql
- Ran migrations outside of the project because, as coded, the sample doesn't seem to run the migrations?
- Added a field to ConvertVideo that is a List\<T\> to trigger the deserialization issue

In the logs folder, there is a log showing the exception thrown when submitting the modified ConvertVideo job message.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var logger = new Logger() { EnabledLevel = LogLevel.Warning };
var time = DateTime.Now;

logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. This is an error. It will be printed.");
logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time}. This won't be printed.");
logger.LogMessage(LogLevel.Warning, "Warning Level. This warning is a string, not an interpolated string expression.");
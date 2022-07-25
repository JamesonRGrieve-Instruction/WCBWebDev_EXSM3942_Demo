// Windows UserName.
using Microsoft.Win32;

Console.WriteLine(Environment.UserName);

// Windows Version.
Console.WriteLine(Environment.OSVersion.ToString());

// Getting Paths of Windows User / System Folders.
Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

// Number of CPU Ticks of Uptime.
Console.WriteLine(Environment.TickCount64);

// List of logical drives attached to Windows.
foreach (string drive in Environment.GetLogicalDrives()) Console.WriteLine(drive);

// Environment varaibles. Probably don't use Set unless you know what you're doing.
Environment.GetEnvironmentVariable("TEMP");
//Environment.SetEnvironmentVariable("TEMP", "Something");

// DO NOT USE THIS IF YOU DON'T KNOW WHAT YOU'RE DOING!
// Allows you to change registry values, which are persistent variables critical to the functions of the operating system and programs.
// For native applications, configurations and install directories are often stored here.
//Registry.SetValue()

// Supposedly writes a message to the Windows event viewer, although I couldn't find it.
//Environment.FailFast("Something went wrong, Jim!");


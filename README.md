<h1 align="center">DiacriticalMarks</h1>

<p align="center">
	<img src="https://raw.githubusercontent.com/giosali/DiacriticalMarks/main/ext/DiacriticalMarks-logo.png" width="150">
</p>

<p align="center">
	A small, basic library for creating and getting diacritical letters in WPF
</p>

<p align="center">
    <a href="https://www.nuget.org/packages/DiacriticalMarks">
        <img src="https://img.shields.io/nuget/v/DiacriticalMarks?logo=nuget" alt="NuGet Version">
    </a>
    <a href="https://github.com/giosali/DiacriticalMarks/blob/main/DiacriticalMarks/DiacriticalMarks.csproj">
        <img src="https://img.shields.io/badge/dynamic/xml?color=%23512bd4&label=target&logo=.net&query=%2F%2FTargetFramework[1]&url=https%3A%2F%2Fraw.githubusercontent.com%2Fgiosali%2FDiacriticalMarks%2Fmain%2FDiacriticalMarks%2FDiacriticalMarks.csproj" alt="Target Framework">
    </a>
</p>

<p align="center">
    <a href="https://github.com/giosali/DiacriticalMarks/actions/workflows/ci.yml">
        <img src="https://github.com/giosali/DiacriticalMarks/actions/workflows/ci.yml/badge.svg" alt="CI Workflow">
    </a>
    <a href="https://github.com/giosali/DiacriticalMarks/blob/main/LICENSE">
        <img src="https://img.shields.io/github/license/giosali/DiacriticalMarks" alt="License">
    </a>
</p>

## Requirements

**DiacriticalMarks** is compatible with **.NET 5.0** (*net5.0-windows*) and **.NET 6.0** (*net6.0-windows*).

## Installation

You can find the package on [NuGet](https://www.nuget.org/packages/DiacriticalMarks) or install it through PackageManagement:

```ps
Install-Package DiacriticalMarks
```

## Usage

The purpose of this library is to do basic things like:

```
a + ´ = á
```

or even:

```
a + ^ + ` = ầ
```

### Using Basic Accents

You're most likely interested in using some of the following basic accents:

| Accent     | Mark |
|------------|:----:|
| Circumflex |   ^  |
| Grave      |   `  |
| Tilde      |   ~  |
| Diaeresis  |   ¨  |
| Macron     |   ¯  |
| Acute      |   ´  |
| Cedilla    |   ¸  |

If that's the case, you can simply use the `AttachAccent` method to *attach* an accent to a provided base character:

```csharp
using DiacriticalMarks;


public static void Main()
{
    string result = DiacriticalMarks.AttachAccent('a', Accent.Acute);
    char diacriticalLetter = char.Parse(result);
    Console.WriteLine(diacriticalLetter);  // Prints á
}
```

The `DiacriticalMarks` namespace contains an [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) called `Accent` that contains:

* the circumflex accent (^)
* the grave accent (`)
* the tilde (~)
* the diaeresis (¨)
* the macron (¯)
* the acute accent (´)
* and the cedilla (¸)

### Using Combining Diacritical Marks

If you need access to more, you can also use the `CombiningDiacriticalMark` enum which is also found in the `DiacriticalMarks` namespace. To use [combining diacritical marks](https://en.wikipedia.org/wiki/Combining_Diacritical_Marks), you have access to two methods:

* `AttachDiacritic`
* `AttachDiacritics`

The `CombiningDiacriticalMark` enum contains 112 values, per the [official document on combining diacritical marks by the Unicode Consortium](https://www.unicode.org/charts/PDF/U0300.pdf).

#### AttachDiacritic method

The `AttachDiacritic` method is similar to the `AttachAccent` method except instead of providing an `Accent`, you need to provide a `CombiningDiacriticalMark`:

```csharp
using DiacriticalMarks;


public static void Main()
{
    string result = DiacriticalMarks.AttachDiacritic('a', CombiningDiacriticalMark.CombiningGraveAccent);
    char diacriticalCharacter = char.Parse(result);
    Console.WriteLine(diacriticalCharacter);  // Prints 'à'
}
```

#### AttachDiacritics method

If you need to attach multiple diacritical marks to a base character, you can use the `AttachDiacritics` method. This method accepts a an array of `CombiningDiacriticalMark`:

```csharp
using DiacriticalMarks;


public static void Main()
{
    CombiningDiacriticalMark[] marks = new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningDotBelow };
    string result = DiacriticalMarks.AttachDiacritic('A', marks);
    char diacriticalCharacter = char.Parse(result);
    Console.WriteLine(diacriticalCharacter);  // Prints 'Ặ'
}
```

```
📝 NOTE: The order of `CombiningDiacriticalMark`s matters! For example, if the order of the `marks` variable was instead: { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningBreve }, you may end up with a string consisting of a 'Ạ' that has a breve ('˘') accent attached to it, which means the string will have a length of 2 instead of 1.

In other words:

'A' + new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningBreve, CombiningDiacriticalMark.CombiningDotBelow } = 'Ặ'

    Length = 1
    Official Unicode name = Latin Capital Letter a with Breve and Dot Below

'A' + new CombiningDiacriticalMark[] { CombiningDiacriticalMark.CombiningDotBelow, CombiningDiacriticalMark.CombiningBreve } = 'Ặ'

    Length = 2
    Official Unicode name = ?
```

If you need to find the correct order for certain characters, follow the order listed in their official Unicode names. A site that I recommend for viewing names is [Unicode-Table](https://unicode-table.com/).
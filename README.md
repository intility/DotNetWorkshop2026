# DotNet Workshop 2026

Last ned repoet ved å kjøre `git clone git@github.com:intility/DotNetWorkshop2026.git`.

## Forhåndskrav

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- [C# Dev Kit extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

## Nyttige kommandoer

- `dotnet restore` - Gjenopprett avhengigheter
- `dotnet run` - Kjør applikasjonen
- `dotnet build` - Bygg prosjektet

## Pensum

### Kodestil

- PascalCase
- `{}` på newline

### Variabler og typer

- `int`, `string`, `bool`
- Array og List
- Set/Dictionary
- `var`

### Kontrollflyt

- `if`/`else`
- `switch`
- `for`/`foreach`/`while`
- `try`/`catch`

### LINQ

- `Where`
- `Select`
- `OrderBy`
- `Take`
- `Skip`

### Objektorientert programmering

- Klasser
- Metodekall

### Mål for workshopen

- Lage en evigkjørende console-applikasjon
- Implementere forskjellige kommandoer (del opp i klasser/metoder)

## Oppgaver

### Oppgave 1: Grunnleggende kommandoer

- Implementer forskjellige kommandoer:
  - `greeter` - Hilse på bruker
  - `agecheck` - Sjekke alder
  - `shapes` - Tegne former
  - Lag en Person fra brukerinput
  - `exit` - Avslutt program
- Få programmet til å kjøre "evig" (til bruker velger exit)

### Oppgave 2: Dataprosessering med LINQ

- Prosessere data om personer:
  - Hvor mange personer er over 150 cm høye?
  - Hent alle personer som starter på M

### Oppgave 3: Avanserte konsepter

- **Trains**:
  - Bruk Train klassen til å vise et tog i console
  - Få toget til å kjøre gjennom consolen
- **Grids**:
  - Lag et 2D array
  - La bruker skrive inn koordinater
  - Bruk `grid.render` til å vise hva bruker valgte
- **Algoritmer**:
  - Lag følgende mønster med for-løkker:
    ```
       *
      ***
     *****
    *******
    ```

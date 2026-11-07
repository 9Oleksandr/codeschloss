# Codeschloss in C#

Das ist ein Projekt aus meinem Studium (Fach: Objektorientierte Programmierung, Universität Saporischschja, 2025).

Das Programm zeigt ein Codeschloss für eine Tür. Es hat ein Tastenfeld mit den Zahlen 0 bis 9, ein Display und eine Klingel. Ich habe das Programm mit C# und Windows Forms gemacht.

## Was kann das Programm?

- Man gibt einen Code mit vier Ziffern ein. Die Ziffern sieht man auf dem Display.
- Wenn der Code richtig ist, öffnet sich die Tür. Nach 20 Sekunden schließt sie sich wieder.
- Wenn die Tür offen ist, kann man den Zugangscode ändern.
- Man kann auch den Kontrollcode ändern.
- Mit der Taste „Call" kann man klingeln.

## So benutzt man das Programm

Am Anfang gilt: Zugangscode **1234**, Kontrollcode **0000**.

- **Tür öffnen:** Code eingeben und auf „Enter" drücken.
- **Zugangscode ändern:** Tür öffnen, den Kontrollcode eingeben, auf „Control" drücken. Dann hat man 5 Sekunden Zeit für den neuen Code.
- **Kontrollcode ändern:** Tür öffnen, auf „Call" drücken, den Kontrollcode eingeben und auf „Change control code" drücken. Dann hat man 5 Sekunden Zeit für den neuen Kontrollcode.

Die Texte auf dem Display sind auf Ukrainisch.

## Die Klassen

- `Keypad`: speichert den Code, den man eingibt
- `Display`: zeigt Text an
- `Lockk`: das Schloss, es prüft den Zugangscode
- `Control`: speichert den Kontrollcode
- `SecuritySystem`: verbindet alle Teile und steuert den Ablauf
- `Form1`: das Fenster mit den Tasten

Den Code der Klassen findet man in `K18/Program.cs`.

## Starten

Das Programm läuft nur auf Windows. Man öffnet `K18.sln` mit Visual Studio und startet es. Man braucht .NET 8.

## Was ich besser machen könnte

- Die feste Wartezeit von 5 Sekunden ersetzen. Besser wäre ein Ablauf mit Ereignissen.
- Die Codes nicht fest im Programm speichern.

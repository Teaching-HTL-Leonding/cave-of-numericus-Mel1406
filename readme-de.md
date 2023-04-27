# Die geheimnisvolle Höhle von Numericus

![Höhle von Numericus (erstellt mit DALL-E)](./title.phg)

## Einführung

Vor langer Zeit im Land Algozia gab es eine geheimnisvolle Höhle namens die Höhle von Numericus. Diese Höhle sollte die Geheimnisse der alten Algozianischen Zivilisation bergen. Im Laufe der Jahrhunderte versuchten viele Abenteurer, die Höhle zu durchqueren, doch keiner hatte Erfolg. Der Legende nach war die Höhle mit magischen Zahlsteinen gefüllt, die den Weg zur geheimen Kammer offenbaren würden, wenn der Auserwählte die in ihnen eingebetteten Rätsel lösen könnte.

Als angehender Abenteurer möchtest du der Erste sein, der die in der Höhle von Numericus verborgenen Geheimnisse aufdeckt. Um dies zu tun, musst du den alten Algozianischen Code mit deinen Programmierkenntnissen entschlüsseln. Die Zahlsteine in der Höhle sind in ihren Kammern verstreut, und du musst einen Weg finden, ihre Botschaft zu entschlüsseln.

## Grundanforderungen

Beginne deine Suche mit diesen Schritten:

1. Generiere 20 zufällige Zahlsteine: Schreibe ein C#-Programm, das 20 zufällige Zahlen (>= 1 und <= 100) generiert und sie in einem Array oder einer Liste speichert.

2. Sortiere die Zahlsteine: Um den geheimen Pfad zu enthüllen, müssen die Zahlsteine in **aufsteigender Reihenfolge** angeordnet werden. Schreibe Code, um die Zahlen aus Schritt 1 zu sortieren. Kannst du dich an die [Volkstanzgruppe](https://youtu.be/Iv3vgjM8Pv4) erinnern, die *Bubble Sort* getanzt hat?

3. Berechne den durchschnittlichen Abstand zwischen jedem Wertepaar: Während du die Höhle durchquerst, stellst du fest, dass die alten Algozianer einen Hinweis auf den Standort der geheimen Kammer im durchschnittlichen Abstand zwischen jedem aufeinanderfolgenden Wertepaar von Zahlsteinen (erster zu zweiter, zweiter zu dritter usw.) hinterlassen haben. Berechne den durchschnittlichen Abstand zwischen jedem Wertepaar in deiner sortierten Liste.

Nachdem du diese Aufgaben erfolgreich abgeschlossen hast, wirst du den numerischen Code entschlüsselt und die Geheimnisse der Höhle von Numericus freigeschaltet haben. Möge deine Suche nach Wissen voller Abenteuer und Aufregung sein, während du tiefer in die Welt der Informatik vordringst!

⚠️ Du darfst eine vorhandene Sortierfunktion von .NET verwenden, wenn du herausfinden kannst, wie sie aufgerufen wird und wie du sie verwendest. Nutze eine Suchmaschine oder eine KI, um das herauszufinden. Du musst jedoch auch selbst einen Sortieralgorithmus implementieren (z.B. Bubble Sort oder einen anderen Sortieralgorithmus, den du herausfinden kannst).

## Testdaten

Wenn du die Korrektheit deines Programms testen möchtest, erzeuge einen *gesetzten* Zufallszahlengenerator am Anfang deines Programms:

```cs
var rand = new Random(4711);
```

Generiere die Zufallswerte mit var `randomValue = rand.Next(1, 101);`. Wenn du das tust, sollte das Ergebnis deines Programms (d.h. der durchschnittliche Abstand der Wertepaare) etwa 4.47368 betragen.

## Level 2

Ist dein Algorithmus schnell genug? Versuche, 75000 Werte zwischen 1 und 1 Milliarde (10^9) zu generieren. Das korrekte Ergebnis dafür ist etwa 13333.4243.

## Level 3 (⚠️ Schwierig)

Du musst deine gesamte Lösung überdenken, weil du jetzt 1 Million Werte zwischen 1 und 1 Milliarde (10^9) generieren musst. Das korrekte Ergebnis dafür ist etwa 999.99969.

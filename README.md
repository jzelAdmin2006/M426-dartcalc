# Dart Calc

Im Projekt _Dart Calc_ geht es um Berechnungen rund um das Spiel _Darts_.

## Spielvariante 501: Regeln

Bei der Spielvariante _501_ geht es darum, mit möglichst wenig Würfen von 501
auf null Punkte zu kommen. Das Spiel funktioniert (vereinfacht für einen
Spieler) folgendermassen:

1. Der Spieler wirft dreimal mit je einem Pfeil auf das Brett.
2. Die Anzahl Punkte für die Runde wird berchnet und vom Zwischenstand (zu
   Beginn: 501) abgezogen.
    1. Bei einem Treffer in einen bestimmten Sektor erhält der Spieler die
       einfache Punktzahl (z.B. _Single 18_: 18).
    2. Wird der _Double Ring_ getroffen, erhält der Spieler die doppelte
       Punktzahl des Sektors (z.B. _Double 17_: 34).
    3. Wird der _Triple Ring_ getroffen, erhält der Spieler die dreifache
       Punktzahl des Sektors (z.B. _Tripe 20_: 60).
3. Die Runde ist zu Ende, wenn der Spieler auf null Punkten ist.
    1. Die Punktzahl 0 muss _exakt_ erreicht werden. Wird die Punktzahl 0
       unterschritten, gibt es keine Punkte.
    2. Die Punktzahl 0 muss über einen _Double Checkout_ erreicht werden, d.h.
       mit dem letzten Wurf muss man den _Double Ring_ treffen. (D.h. man kann
       die Runde nur beenden, wenn beim letzten Wurf eine gerade Punktzahl
       verbleibt.)

![Ein Dartsbrett](dartboard.png)

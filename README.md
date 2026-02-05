# ImageMagick

Niveau 1: Opvarmning (API-forståelse)
1.	"Auto-Thumbnailer": Lav en funktion, der tager en hel mappe med billeder og genererer thumbnails. Programmet skal bruge MagickImageInfo til at læse dimensioner uden at loade hele billedet først for at optimere hastigheden.

2.	"The Meme Machine": Lav en console-app, der tager en tekst som input og placerer den med hvid "Impact"-skrifttype og sort outline i bunden af et billede ved hjælp af image.Annotate().

Niveau 2: Mellemsvære Cases (Programmerings Logik)
1.	"Intelligent Vandmærke": Brug C# til at analysere billedets gennemsnitlige lysstyrke (Luminance). Hvis billedet er lyst, skal vandmærket være sort; hvis det er mørkt, skal det være hvidt.
      ○	Hint: Brug image.Histogram() eller GetPixels() til at analysere farverne.
2.	"Symmetri-generatoren": Skriv et program, der tager venstre halvdel af et billede, spejlvender det (Flop) og sætter det sammen med originalen for at skabe perfekte, symmetriske ansigter eller landskaber.
○	Hint: Brug MagickImageCollection og Append().


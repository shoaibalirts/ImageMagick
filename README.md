# ImageMagick

Niveau 1: Opvarmning (API-forståelse)
1.	"Auto-Thumbnailer": Lav en funktion, der tager en hel mappe med billeder og genererer thumbnails. Programmet skal bruge MagickImageInfo til at læse dimensioner uden at loade hele billedet først for at optimere hastigheden.

Write a program that:
1.	Takes a folder full of images.
2.	Reads each image’s dimensions quickly using MagickImageInfo (without loading the full image into memory).
3.	Generates a thumbnail version (small image, e.g. 150px wide).
4.	Saves all thumbnails into a new folder.



2.	"The Meme Machine": Lav en console-app, der tager en tekst som input og placerer den med hvid "Impact"-skrifttype og sort outline i bunden af et billede ved hjælp af image.Annotate().

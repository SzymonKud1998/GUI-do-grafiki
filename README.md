# GUI-do-grafiki
Aktualny program z interfejsem graficznym, po lewej stronie znajduja sie buttony ktore odpowiadaja w wiekszosci na dzialaniach na obu zdjeciach. Zdjecia sa zalaczone na sztywno
z mozliwoscia zmiany, poniewaz metoda:

public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
Musi zwracac jakies wartosci dlatego bez wypelnienia pola pierwszego zdjecia oraz drugiego nie zaleca sie uruchamiania programu.
Aby dostosowac jasnosc zdjecia musimy przedtem wykonac jakies czynnosci w programie aby picturebox_wynik zostal wypelniony.
Jasnosc jest dostosowywana przez aktywny suwak z wartosciami -100 do 100. Wszystkie pierwsze 16 buttonow dziala na obu zdjeciach.
Przycisk czyszczenia umozliwia rozpoczecie pracy nad mieszaniem zdjec na nowo bez koniecznosci wylaczania programu.
Negatyw dziala jak jasnosc wiec aby otrzymac jakiekolwiek wyniki nalezy uprzednio uzyskac jakis wynik.

# LINQCore

## ZADANIE 1 – GENEROWANIE KWADRATÓW NIEKTÓRYCH LICZB:
W zadaniu nie można używać pętli. Proszę wczytać ze standardowego wejścia liczbę N. Za pomocą
połączenia metod Range, Where, Select, OrderBy stworzyć kolekcję kwadratów liczb od 1..N. Liczba,
która będzie podnoszona do kwadratu musi spełniać założenia(koniunkcja): <br />
● Różna od 5, <br />
● Różna od 9 <br />
● Nieparzysta lub wielokrotność 7, <br />
Czyli np. 14 spełnia(różna od 5 i różna od 9 i wielokrotność 7), ale 10 nie spełnia. <br />
Następnie proszę wypisać na standardowe wyjście: <br />
● Sumę wszystkich elementów kolekcji <br />
● Liczbę wszystkich elementów w kolekcji <br />
● Pierwszy element kolekcji <br />
● Ostatni element kolekcji <br />
● Liczbę elementów kolekcji <br />
● Trzeci element kolekcji 

## ZADANIE 2 – SUMA ELEMENTÓW LOSOWEJ MACIERZY
W zadaniu nie można używać pętli. Proszę wczytać liczby N i M. Proszę wygenerować listę list
rozmiaru NxM i zainicjalizować ją losowymi liczbami całkowitymi. Następnie proszę użyć metody
SelectMany w celu zsumowania wszystkich elementów i wypisania ich na standardowe wyjście.

## ZADANIE 3 – GRUPOWANIE NAZW MIAST
Proszę napisać program, który wczytuje ze standardowego wejścia listę miast(oddzielonych nową
linią). Proszę użyć metody GroupBy oraz OrderBy, aby pogrupować miasta po pierwszej literze
oraz posortować wewnątrz tej grupy w porządku leksykograficznym. Do przechowywania
zgrupowanych danych należy użyć słownika. Miasta wczytujemy aż do napotkania symbolu „X”.
Następnie program oczekuje podania kolejnych liter. Po podaniu litery program wypisuje
posortowaną listę miast zaczynającą się na daną literę lub „PUSTE”. 
### Wejście 
Paryż <br />
Praga <br />
Kraków <br />
Pcim <br />
Płock <br />
X <br />
P <br />
B 

### Wyjście
Paryż, Pcim, Płock, Praga <br />
PUSTE


## ZADANIE 4 – PRZEMIESZCZANIE SIĘ POMIĘDZY LOKACJAMI
Proszę zmodyfikować naszą grę, aby posiadała kolekcję możliwych lokacji. Na raz możemy być tylko
w jednej lokacji. Zmodyfikujmy menu w ten sposób, aby umożliwić przemieszczanie się. Wybór opcji
[T](od travel) spowoduje zmianę lokacji: <br />
Znajdujesz się w : {NazwaLokalizacji}. Co chcesz zrobić? <br />
[1] Porozmawiaj z {NazwaNPC1} <br />
[2] Porozmawiaj z {NazwaNPC2} <br />
[T] Podróżuj <br />
[X] Zamknij program <br />
Po wybraniu opcji T proszę wyczyścić ekran konsoli i pokazać menu z dostępnymi lokacjami:
Znajdujesz się w : {NazwaLokalizacji}. Gdzie chcesz wyruszyć? <br />
[1] Nazwa 1 <br />
[2] Nazwa 2 <br />
[X] Powrót <br />
Wybranie jakiejś lokalizacji ma powodować wyświetlenie jej menu za pomocą już napisanej metody
z poprzednich zadań. <br />
Wybranie opcji powrót ma powodować powrót do aktualnej lokalizacji. <br />
Oczywiście na liście lokalizacji nie ma być tej, w której znajdujemy się aktualnie. Ponadto dodajmy
do klasy lokalizacji właściwość IsUnlocked. Proszę stworzyć 6 przykładowych lokalizacji, niech
dwie z nich będą miały ustawione IsUnlocked na false – bohater odblokuje je dopiero wraz z
postępem w grze. <br />
Podczas wyświetlania menu proszę użyć metody LINQ Where do odfiltrowania listy dostępnych
lokalizacji tak, aby wyświetlać tylko te odblokowane różne od aktualnej. Ponadto proszę użyć
metody LINQ OrderBy do posortowania lokalizacji leksykograficznie. <br />
Proszę połączyć filtrowanie i sortowanie w łańcuch metod. 

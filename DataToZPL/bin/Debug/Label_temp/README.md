# **DataToZPL - console code**

Aplikacja konsolowa stworzona w .NET 4.8 ktora pobiera dane z pliku CSV i podstawia je do szablonu kodu ZPL znajdujacego sie w pliku txt.

Przykladowe dane z pliku CSV.

Pierwsza linia w pliku to naglowek w ktorym zdefiniowane sa elementy ktore zostana zamienione przez program na wartosci ponizej.

Dla przykladu dla wartosci

**^FH\^FD ITEM_NUMBER_CUSTOMER ^FS **

w pliku txt z kodem ZPL zostanie podstawiona wartosc

**^FH\^FD 51005038 ^FS**

| ^FH\^FD ITEM_NUMBER_CUSTOMER ^FS | ^FH\^FD ITEM_DESCRIPTION ^FS              | ^FH\^FD PIECES_PER_PACKAGE ^FS | ^FH\^FD BATCH ^FS | ^FH\^FD (01)0GTIN(10)BATCH ^FS          | ^FH\^FD ITEM_NUMBER_CETES ^FS | ^FH\^FD BOX ^FS | ^FH\^FD (01)0GTIN>8(10)BATCH ^FS          | ^FH\^FD_19201^MO_LINE_KEY^_111^MANUFACTURING_yyMMdd^17^EXPIRY_yyMMdd^10^BATCH^^FS |
| -------------------------------- | ----------------------------------------- | ------------------------------ | ----------------- | --------------------------------------- | ----------------------------- | --------------- | ----------------------------------------- | --------------------------------------------------------------------------------- |
| ^FH\^FD 51005038 ^FS             | ^FH\^FD L300 PRO-RETINOL DAY CR SPF15 ^FS | ^FH\^FD 6x50ML ^FS             | ^FH\^FD BA1W1 ^FS | ^FH\^FD (01)07310800029181(10)BA1W1 ^FS | ^FH\^FD 922003 ^FS            | ^FH\^FD 1 ^FS   | ^FH\^FD (01)07310800029181>8(10)BA1W1 ^FS | ^FH\^FD_19202^123_111^210922^17^210922^10BA1W1^^FS                                |

Stworzone foldery i pliki:

**Label_csv_data**

BOX_dataBox - CSV

<<<<<<< HEAD
=======
```
>>>>>>> 3c02fdb6ddd9a45ca7640ac5966f093587d41890
PALLET_data - CSV

<<<<<<< HEAD
TEST_data - CSV

**Label_script**
=======
Label_script
>>>>>>> 3c02fdb6ddd9a45ca7640ac5966f093587d41890

BOX_0 - TXT
<<<<<<< HEAD
=======
```
>>>>>>> 3c02fdb6ddd9a45ca7640ac5966f093587d41890

BOX_1 - TXT

...

BOX_X - TXT
<<<<<<< HEAD

**Label_temp**
=======
```

Label_temp
>>>>>>> 3c02fdb6ddd9a45ca7640ac5966f093587d41890

BOX_label - TXT

<<<<<<< HEAD
PALLET_label - TXT
=======
```
PALLET_label - TXT
```
>>>>>>> 3c02fdb6ddd9a45ca7640ac5966f093587d41890

Pliki i foldery powinny znajdowac w katalogu razem z plikiem exe nazwy plikow nie powinny ulegac zmianom.

![](image/README/1634669942107.png)

Struktura projektu:

Projekt zostal podzielony na 3 rozwiazania.

CSV-ZPLGenerator - w rozwiazaniu znajdujaznjduja sie klasy odpowiedzialne za odczytanie oraz odpowiednie przygotowanie plikow z CSV

DataToZPL - w rozwiazaniu znajduja sie klasy odpowiedzialne za skopiowanie szablonu a nastepnie podmiane danych w plikach txt

Helper - w rozwiazaniu znajduja sie klasy odpowiedzialne za odczytanie z wyzej wymionionych katalogow plikow CSV , TXT

![](image/README/1634669976582.png)

Po uruchomieniu aplikacji uzytkownik wybiera rodzaj etykiety do wygenerowania na podstawie szablonu z folderu Label_temp

aplikacja kopiuje do katalogu Label_script wybrany rodzaj etykiet a nastepnie podmienia w nich dane na te z pliku CSV.

![](image/README/1634670504635.png)

Rezultat

![](image/README/1634670587088.png)

![](image/README/1634670618121.png)



![img](image/README/1634670659522.png)

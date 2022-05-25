# Struktura projektu
Ważniejsze elementy
&#124;
&#124;\
&#124; README.md
&#124;\
  manager_artefaktow
  <code>&#124;</code>\
  &#124; Program.cs
  &#124;\
  &#124; AppProperties.txt - plik konfiguracyjny
  &#124;\
  &#124; Forms - katalog zawierający warstwę wizualną
  &#124;\
  &#124; BusinessLogic - katalog zawierający klasy dostępu i operacji na danych
  &#124;\
  &#124; Migrations - katalog wygenerowany przez Entity Framework
  &#124;\
  &#124; Data
    &#124;\
    &#124; Models - katalog z klasami reprezentującymi tabele w bazie danych
    &#124;\
    &#124; ManagerContext.cs - klasa dziedzicząca po DbContext (zawiera parametry połączenia z bazą danych)

# Utworzenie lokalnej bazy danych
Przed pierwszym uruchomieniem nalezy stworzyc lokalna baze danych poprzez polecenia:
```
add-migration ArtifactManagerDatabase
```
```
update-database
```
# Pierwsze uruchomienie
Podczas pierwszego uruchomienia, baza jest pusta, więc należy się zarejestrować.
Podczas rejestracji użytkownikowi nadawana jest domyślna rola `DefaultRole` określona w pliku konfiguracyjnym `AppProperties.txt`
Aby móc korzystać z systemu zarządzania użytkownikami, rola ta powinna być ustawiona na wartość `Admin`, a cały wpis w pliku powinien wyglądać następująco:
```
DefaultRole:Admin
```
Właściwość tą można później modyfikować w aplikacji, ale wyłącznie posiadając rolę `Admin`.

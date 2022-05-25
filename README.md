# Struktura projektu
Ważniejsze elementy
<code>&#124;</code>
<code>&#124;</code>\
<code>&#124;</code> README.md
<code>&#124;</code>\
  manager_artefaktow
  <code>&#124;</code>\
  <code>&#124;</code> Program.cs
  <code>&#124;</code>\
  <code>&#124;</code> AppProperties.txt - plik konfiguracyjny
  <code>&#124;</code>\
  <code>&#124;</code> Forms - katalog zawierający warstwę wizualną
  <code>&#124;</code>\
  <code>&#124;</code> BusinessLogic - katalog zawierający klasy dostępu i operacji na danych
  <code>&#124;</code>\
  <code>&#124;</code> Migrations - katalog wygenerowany przez Entity Framework
  <code>&#124;</code>\
  <code>&#124;</code> Data
    <code>&#124;</code>\
    <code>&#124;</code> Models - katalog z klasami reprezentującymi tabele w bazie danych
    <code>&#124;</code>\
    <code>&#124;</code> ManagerContext.cs - klasa dziedzicząca po DbContext (zawiera parametry połączenia z bazą danych)

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

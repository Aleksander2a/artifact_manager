# Struktura projektu
Ważniejsze elementy
\|
\|\
\| README.md
\|\
  manager_artefaktow
  \|\
  \| Program.cs
  \|\
  \| AppProperties.txt - plik konfiguracyjny
  \|\
  \| Forms - katalog zawierający warstwę wizualną
  \|\
  \| BusinessLogic - katalog zawierający klasy dostępu i operacji na danych
  \|\
  \| Migrations - katalog wygenerowany przez Entity Framework
  \|\
  \| Data
    \|\
    \| Models - katalog z klasami reprezentującymi tabele w bazie danych
    \|\
    \| ManagerContext.cs - klasa dziedzicząca po DbContext (zawiera parametry połączenia z bazą danych)

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

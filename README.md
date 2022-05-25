# Struktura projektu
Ważniejsze elementy
&vert;
&vert;\
&vert; README.md
&vert;\
  manager_artefaktow
  &vert;\
  &vert; Program.cs
  &vert;\
  &vert; AppProperties.txt - plik konfiguracyjny
  &vert;\
  &vert; Forms - katalog zawierający warstwę wizualną
  &vert;\
  &vert; BusinessLogic - katalog zawierający klasy dostępu i operacji na danych
  &vert;\
  &vert; Migrations - katalog wygenerowany przez Entity Framework
  &vert;\
  &vert; Data
    &vert;\
    &vert; Models - katalog z klasami reprezentującymi tabele w bazie danych
    &vert;\
    &vert; ManagerContext.cs - klasa dziedzicząca po DbContext (zawiera parametry połączenia z bazą danych)

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

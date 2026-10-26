
# 📝 Formularz użytkownika — C# WPF

Aplikacja desktopowa napisana w **C# i WPF**, umożliwiająca wypełnienie formularza użytkownika, wybór preferencji oraz walidację wprowadzonych danych.

## 📸 Podgląd aplikacji

<!-- Dodaj screenshot do folderu screenshots i odkomentuj poniższą linię -->
<!-- ![Podgląd aplikacji](screenshots/formularz.png) -->

## ✨ Funkcjonalności

- 👤 **Wybór płci** — mężczyzna, kobieta lub inne.
- 🎂 **Wprowadzanie wieku** — walidacja poprawności wieku.
- 🎨 **Wybór koloru** — czerwony, zielony, niebieski lub żółty.
- ✅ **Wymagana zgoda** — użytkownik musi zaakceptować zgodę.
- 🔍 **Walidacja formularza** — sprawdzanie poprawności wszystkich wymaganych danych.
- 💬 **Komunikaty błędów** — informowanie użytkownika o nieprawidłowych danych.
- 📋 **Podsumowanie danych** — wyświetlenie wprowadzonych informacji po poprawnym wypełnieniu formularza.
- 🖥️ **Interfejs graficzny** — prosty i intuicyjny układ okna aplikacji.

## 🛠️ Technologie

- **C#** — logika aplikacji.
- **WPF** — tworzenie interfejsu graficznego.
- **XAML** — definiowanie wyglądu i układu kontrolek.
- **.NET** — platforma uruchomieniowa.
- **Visual Studio** — środowisko programistyczne.

## 🚀 Uruchomienie projektu

### Wymagania

- System Windows.
- Visual Studio z zainstalowanym pakietem **.NET desktop development**.
- Wersja .NET zgodna z konfiguracją projektu.

### Instrukcja


1. Otwórz plik `WpfApp1.sln` w Visual Studio. Jeśli plik `.sln` nie istnieje, otwórz `WpfApp1.csproj`.

2. Poczekaj na przywrócenie wymaganych pakietów.

3. Uruchom aplikację za pomocą przycisku **Start** lub klawisza `F5`.

## ⚙️ Jak działa aplikacja?

Po kliknięciu przycisku **Zapisz** aplikacja sprawdza poprawność wprowadzonych danych.

1. **Płeć** — należy wybrać jedną z dostępnych opcji.
2. **Wiek** — musi być liczbą całkowitą z zakresu od 1 do 120.
3. **Kolor** — musi być wybrany z listy.
4. **Zgoda** — pole „Wyrażam zgodę” musi być zaznaczone.
5. **Podsumowanie** — po poprawnej walidacji wyświetlane jest okno z wprowadzonymi danymi.

Jeśli którykolwiek warunek nie zostanie spełniony, aplikacja wyświetli odpowiedni komunikat i przerwie dalsze przetwarzanie formularza.

## 🧪 Przykładowe scenariusze

| Sytuacja | Rezultat |
|---|---|
| Nie wybrano płci | Komunikat o konieczności wyboru płci |
| Pole wieku jest puste | Komunikat o nieprawidłowym wieku |
| Wiek zawiera litery | Komunikat o nieprawidłowym wieku |
| Wiek jest mniejszy niż 1 | Komunikat o nieprawidłowym wieku |
| Wiek jest większy niż 120 | Komunikat o nieprawidłowym wieku |
| Nie zaznaczono zgody | Komunikat o konieczności wyrażenia zgody |
| Wszystkie dane są poprawne | Wyświetlenie podsumowania formularza |

## 📂 Struktura projektu

```text
WpfApp1/
├── MainWindow.xaml       # Interfejs użytkownika
├── MainWindow.xaml.cs    # Logika i walidacja formularza
├── App.xaml              # Konfiguracja aplikacji WPF
├── App.xaml.cs           # Kod startowy aplikacji
├── WpfApp1.csproj        # Plik projektu
├── WpfApp1.sln           # Rozwiązanie Visual Studio (opcjonalnie)
└── README.md             # Dokumentacja projektu
```

*Rzeczywista struktura plików może się różnić w zależności od konfiguracji projektu.*

## 🎯 Cel projektu

Celem projektu jest nauka podstaw tworzenia aplikacji desktopowych w C# i WPF, w tym:

- budowania interfejsów za pomocą XAML,
- korzystania z kontrolek `RadioButton`, `TextBox`, `ComboBox` i `CheckBox`,
- obsługi zdarzeń w C#,
- walidacji danych wejściowych,
- wyświetlania komunikatów za pomocą `MessageBox`.

## 🔮 Możliwe rozszerzenia

- [ ] Zapisywanie danych do pliku JSON lub CSV.
- [ ] Dodanie przycisku czyszczącego formularz.
- [ ] Nowoczesny wygląd i ciemny motyw.
- [ ] Walidacja wieku podczas wpisywania.
- [ ] Dodanie kolejnych pól formularza.
- [ ] Integracja z bazą danych.

---

<p align="center">
  Made with ❤️ using C# and WPF
</p>

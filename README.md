# Arkitektur MVVM

**MVVM (Model-View-ViewModel)** utvecklades för att lösa problemen med tät koppling (tight coupling) mellan UI och kodlogiken, vilket ofta uppstår i traditionella mönster som Code-Behind. Mönstret skapades av **Ken Cooper** och **Ted Peters** på Microsoft, och gjordes känt av **John Gossman** år 2005 för att användas med WPF(Windows Presentation Foundation).

## Vilket problem försöker arkitekturen lösa?

(Spaghetti code)
(Unit testing)
Dåligt samarbete mellan designers och utvecklare
Manuell synkronisering av data

## Vilka är de huvudsakliga komponenterna i den här arkitekturen?

- **View:** Hur datan uppvisas för användaren
- **ViewModel:** Kopplingen mellan View och Model, hanterar datan mellan dem
- **Model:** lagring av data

## Vilket ansvar har varje komponent?

### View:   
Visa gränsnittet(ui) för användaren   
använder XAML   
Tar emot användarinput och visar data   
Ska innehålla så lite logik kod som den kan

### ViewModel:   
ViewModel ska fungera som en bro mellan View och Model   
Hämtar data från Model och omvandlar den så att View kan visa den.

### Model:   
Håller i Datan   
Hämtar och sparar datan från databaser?   
Har ingen koppling till gränsnittet(ui)

## Samspelar denna arkitektur extra bra med ett eller flera designmönster?

Dependancy injection?
MVVM skapar beroenden mellan View, ViewModel och model. DI fixa detta genom att skicka in beroenden utifrån??


## Hur flödar data genom systemet? Från ett klick eller en HTTP-request till dataförändring och att det syns igen på skärmen, vilka steg tar koden?

bla bla

## Vilka saker blir svårare med denna arkitektur?

bla bla

## Tänk tillbaka på något eller några av de största projekten ni arbetat med. Hur hade det blivit om denna arkitektur hade använts där?

bla bla

Utöver dessa frågor ska en demonstration av appen och dess kod såklart göras, liksom ett snabbt demo av hur ett nytt projekt med denna arkitektur skapas från grunden. Utöver det får gruppen gärna avsluta med personliga åsikter kring hur det var att arbeta med denna arkitektur, oavsett om det så var superbra eller hemskt!

# Arkitektur MVVM

**MVVM (Model-View-ViewModel)** utvecklades för att lösa problemen med tät koppling (tight coupling) mellan UI och kodlogiken, vilket ofta uppstår i traditionella mönster som Code-Behind. Mönstret skapades av **Ken Cooper** och **Ted Peters** på Microsoft, och gjordes känt av **John Gossman** år 2005 för att användas med WPF(Windows Presentation Foundation).

## Vilket problem försöker arkitekturen lösa?

De problemen MVVM försöker lösa är:
- **Spagettikod**   
  Om logiken, databaser och design blandas i samma fil blir koden helt knasig. Ändrar du en liten sak i designen går appens funktioner sönder. Med MVVM separeras detta så att logiken ligger i ViewModel, designen i View och datan i Models, vilket gör koden ren och strukturerad.

- **Svårtestat kod**   
  Webbapplikationer kräver ett grafiskt gränssnitt för att köras och genom att flytta logiken till en ViewModel (som inte har någon UI-kod) kan man enkelt skriva tester för metoderna.

- **Manuell datahantering**   
  Utan MVVM måste du skriva manuell kod för att hämta text från en textruta, skicka den till databasen, och manuellt uppdatera skärmen igen. MVVM löser detta helt genom automatisk bindning och i vårat fall ObservableCollection.
```
  <TextBox Text="{Binding input}" />
```

## Vilka är de huvudsakliga komponenterna i den här arkitekturen?

- **View:** Hur datan uppvisas för användaren   
- **Model:** lagring av data
- **ViewModel:** kopplingen mellan View och Model, hanterar logiken och datan mellan View & Modal

## Vilket ansvar har varje komponent?

### View:   
- Visa gränsnittet(ui) för användaren   
- använder XAML   
- Tar emot användarinput och visar data   
- Ska innehålla så lite logik-kod som den kan

### ViewModel:   
- Ska fungera som en bro mellan View och Model   
- Hämtar data från Model och omvandlar den så att View kan visa den.

### Model:   
- Håller i Datan   
- Hämtar och sparar datan från databaser?   

## Samspelar denna arkitektur extra bra med ett eller flera designmönster?

Dependancy injection?
MVVM skapar beroenden mellan View, ViewModel och model. DI fixa detta genom att skicka in beroenden utifrån??

## Hur flödar data genom systemet? Från ett klick eller en HTTP-request till dataförändring och att det syns igen på skärmen, vilka steg tar koden?

1. Användaren klickar
2. Button kör AddTodoCommand
3. AddTodo() körs
4. En ny Todo skapas
5. Todo läggs i Todos
6. ObservableCollection meddelar WPF
7. Binding uppdaterar ListBox
8. "Köp mjölk" syns på skärmen

## Vilka saker blir svårare med denna arkitektur?

- **Svår felsökning**   
  Fel i XAML eller HTML-bindningar syns ofta inte vid kompilering, utan kraschar eller tyst misslyckas vid körning.
  
- **Mer kod**   
  Som vanligt så blir det mer kod då man använder ramverk/arkitekturer, med MVVM så måste det skapas View, ViewModel och Model.

  
## Tänk tillbaka på något eller några av de största projekten ni arbetat med. Hur hade det blivit om denna arkitektur hade använts där?

bla bla

Utöver dessa frågor ska en demonstration av appen och dess kod såklart göras, liksom ett snabbt demo av hur ett nytt projekt med denna arkitektur skapas från grunden. Utöver det får gruppen gärna avsluta med personliga åsikter kring hur det var att arbeta med denna arkitektur, oavsett om det så var superbra eller hemskt!

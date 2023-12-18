//Ambrogiani Filippo 4i 18/12/2023s
Slotmachine2 slotmachine = new Slotmachine2();
void Main(){
    bool esci = false;
    System.Console.WriteLine("Ciao! Benvenuto nel programma Slotmachine di Filippo.");
    while (esci == false){
        System.Console.WriteLine("Cosa vuoi fare?\n   1.Gioca 1 moneta\n   2.Controlla Monete\n   3.Aggiungi monete\n   4.Esci");
        int risposta = Convert.ToInt32(Console.ReadLine());
        switch (risposta)
        {
            case 1:
                slotmachine.GiraRuota();
                Thread.Sleep(3000);
                break;
            case 2:
                System.Console.WriteLine($"Sei a disposizione di {slotmachine.monete} monete");
                Thread.Sleep(1500);
                break;
            case 3:
                System.Console.WriteLine("Quante monete vuoi aggiungere?");
                risposta = Convert.ToInt32(Console.ReadLine());
                slotmachine.monete += risposta;
                System.Console.WriteLine($"Hai aggiunto {risposta} monete!");
                Thread.Sleep(1500);
                break;
            case 4:
                System.Console.WriteLine("Alla prossima!");
                esci = true;
                break;
            default:
                System.Console.WriteLine("Errore");
            break;
        }
    }
}
Main();


public class Slotmachine2{
    public int monete = 10;
    int slot1; int slot2; int slot3;
    char lettera;
    
    public void GiraRuota(){
        monete-=1;
        System.Console.WriteLine($"Hai deciso di giocare! monete rimanenti {monete}...");
        this.slot1 = numeroRandom();
        this.slot2 = numeroRandom();
        this.slot3 = numeroRandom();
        if (slot1 == slot2 && slot2 == slot3)
        {
            this.monete+=slot1;
            System.Console.WriteLine($"     TRIS!!! + {slot1} MONETE (monete attuali: {monete})");
            
        }
        else if (slot1 == slot2 || slot1 == slot3 || slot2 == slot3)
        {
            this.monete+=1;
            System.Console.WriteLine($"     DOUBLE! + 1 MONETA (monete attuali: {monete})");
        }
        else if (slot2 == slot1+1 && slot3 == slot2+1)
        {
            this.monete +=50;
            System.Console.WriteLine($"     CONSECUTIVE!! +50 MONETE (monete attuali: {monete})");     
        }
        else if (slot1 == 26 && slot2 == 26 && slot3 == 26)
        {
            this.monete +=100;
            System.Console.WriteLine($"     JACKPOT!!! +100 MONETE (monete attuali: {monete})"); 
        }
        mostraSlot();
    }
    public void mostraSlot(){
        System.Console.WriteLine($"slot1: {TrasformaLettera(slot1)}\nslot2: {TrasformaLettera(slot2)}\nslot3: {TrasformaLettera(slot3)}");
    }

    public char TrasformaLettera(int slot){
        
        int valoreAscii = slot + (int)'A' - 1;
        lettera = (char)valoreAscii;
        return lettera;
    }
    
    public int numeroRandom(){
        Random random = new Random();
        return random.Next(1,27);
    }
}
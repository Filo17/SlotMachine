namespace Ambrogiani.Filippo._4i.LibSlotMachine
{
    public class SlotMachine
    {
        public int Credito { get; set; }

        public SlotMachine() 
        {
            Credito = 0;
        }
        public SlotMachine(int credito) 
        {
            Credito = credito;
        }
    }
}
namespace change_gui
{
    public class Coin : Money {
        public Coin(int type) : base(type) {
        }

        public Coin(int type, int amount) : base(type, amount) {
        }

        public override string GetPhysicalForm() {
            return "Coin";
        }
    }
}
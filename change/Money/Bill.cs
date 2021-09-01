namespace change {
    public class Bill : Money {
        
        public override string GetPhysicalForm() {
            return "Bill";
        }

        public Bill(int type) : base(type) {
        }

        public Bill(int type, int amount) : base(type, amount) {
        }
    }
}
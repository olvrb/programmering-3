namespace change {
    public class Money {
        public int Type { get; set; }
        public int Amount { get; set; }

        public Money(int type) {
            this.Type = type;
        }

        public string GetHumanName() {
            switch (this.Type) {
                case 1000:
                    return this.Amount > 1 ? "tusenlappar" : "tusenlapp";
                case 500:
                    return this.Amount > 1 ? "femhundralappar" : "femhundralapp";
                case 200:
                    return this.Amount > 1 ? "tvåhundralappar" : "tvåhundralapp";
                case 100:
                    return this.Amount > 1 ? "hundralappar" : "hundralapp";
                case 50:
                    return this.Amount > 1 ? "femtiolappar" : "femtiolapp";
                case 20:
                    return this.Amount > 1 ? "tjugiolappar" : "tjugiolapp";
                case 10:
                    return this.Amount > 1 ? "tiokronor" : "tiokrona";
                case 5:
                    return this.Amount > 1 ? "femkronor" : "femkrona";
                case 2:
                    return this.Amount > 1 ? "tvåkronor" : "tvåkrona";
                case 1:
                    return "enkrona";
                default:
                    return "";
            }
        }

        public Money(int type, int amount) {
            this.Type = type;
            this.Amount = amount;
        }

        public virtual string GetPhysicalForm() {
            return null;
        }

        public int GetWorth() {
            return Type * Amount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace personkoll {
    public class Person {
        public string FirstName { get; }
        public string LastName { get; }
        public string PersNr { get; }

        public Person(string firstName, string lastName, string persNr) {
            this.FirstName = firstName;
            this.LastName = lastName;
            if (ValidatePersNr(StringToIntList(persNr))) {
                this.PersNr = persNr;
            }
            else {
                throw new Exception("Invalid persnr");
            }
        }

        public static bool ValidatePersNr(List<int> pnr) {
            int control = pnr[pnr.Count - 1];
            pnr.RemoveAt(pnr.Count - 1);

            int i = 0;
            while (i < pnr.Count) {
                if (i % 2 == 0) {
                    pnr[i] = (char) (pnr[i] * 2);
                }

                i++;
            }

            int sum = 0;
            foreach (int j in pnr) {
                char[] nums = j.ToString().ToCharArray();
                foreach (char c in nums) {
                    sum += int.Parse(c.ToString());
                }
            }


            return (sum + control) % 10 == 0;
        }

        public char Gender => PersNr[PersNr.Length - 2] % 2 == 0 ? 'F' : 'M';

        public override string ToString() {
            return $"First name: {this.FirstName}\nLast name: {this.LastName}\nPersnr: {PersNr}\nGender: {this.Gender}";
        }

        public static List<int> StringToIntList(string str) {
            return str.ToCharArray()
                      .Select(char.ToString)
                      .Select(int.Parse)
                      .ToList();
        }
    }
}
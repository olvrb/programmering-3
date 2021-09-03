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
            // Extract control digit then remove it.
            int control = pnr[pnr.Count - 1];
            pnr.RemoveAt(pnr.Count - 1);

            // Multiply by 2 every other time.
            int i = 0;
            while (i < pnr.Count) {
                if (i % 2 == 0) {
                    pnr[i] = (char) (pnr[i] * 2);
                }

                i++;
            }

            // Split numbers with 2 or more digits, get sum of all digits.
            int sum = 0;
            foreach (int j in pnr) {
                // Convert to char array to get all individual digits, then convert back to int and add to sum.
                char[] nums = j.ToString().ToCharArray();
                foreach (char c in nums) {
                    sum += int.Parse(c.ToString());
                }
            }


            // sum + control should be evenly dividable by 10.
            return (sum + control) % 10 == 0;
        }

        // Get second to last digit. If even female, else male.
        public char Gender => PersNr[PersNr.Length - 2] % 2 == 0 ? 'F' : 'M';

        public override string ToString() {
            return $"First name: {this.FirstName}\nLast name: {this.LastName}\nPersnr: {PersNr}\nGender: {this.Gender}";
        }

        // Util method to convert persnr in string format to List<int>
        public static List<int> StringToIntList(string str) {
            return str.ToCharArray()
                      .Select(char.ToString)
                      .Select(int.Parse)
                      .ToList();
        }
    }
}
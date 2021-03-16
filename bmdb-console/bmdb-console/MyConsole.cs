using System;
using System.Collections.Generic;
using System.Text;

namespace bmdb_console {
    class MyConsole {
        public static String getString(String prompt) {
            Console.Write(prompt);
            String s = Console.ReadLine();  // read user entry
            // discard any other data entered on the line
            return s;
        }

        public static String getRequiredString(String prompt) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                s = Console.ReadLine();
                if (s == "") {
                    Console.WriteLine("Error! This entry is required. Try again.");
                } else {
                    isValid = true;
                }
            }
            return s;
        }

        public static String getChoiceString(String prompt,
                String s1, String s2) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                s = getRequiredString(prompt);
                if (!(s == s1) && !(s == s2)) {
                    Console.WriteLine("Error! Entry must be '" + s1 + "' or '" + s2 + "'. Try again.");
                } else {
                    isValid = true;
                }
            }
            return s;
        }
        public static String getChoiceString(String prompt,
            String[] validEntries) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                s = getRequiredString(prompt);
                // loop through all valid entries to see if user entry is valid
                foreach (String str in validEntries) {
                    if (s == str) {
                        isValid = true;
                    }
                }
                // if user did not match then display an error
                if (!isValid)
                    Console.WriteLine("Invalid entry, '" + s + "'. Try again.");
            }
            return s;
        }
        public static int getInt(String prompt) {
            int i = 0;
            Boolean isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                try {
                    i = Int32.Parse(Console.ReadLine());
                    isValid = true;

                } catch (Exception) {
                    Console.WriteLine("Error! Invalid integer. Try again.");
                }
            }
            return i;
        }

        public static int getInt(String prompt, int min, int max) {
            int i = 0;
            Boolean isValid = false;
            while (!isValid) {
                i = getInt(prompt);
                if (i <= min) {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                } else if (i >= max) {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                } else {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(String prompt) {
            double d = 0;
            Boolean isValid = false;
            while (!isValid) {
                Console.WriteLine(prompt);
                try {
                    d = Convert.ToDouble(Console.ReadLine());
                    isValid = true;

                } catch (Exception) {
                    Console.WriteLine("Error! Invalid double. Try again.");
                }
            }
                return d;
        }
        public static double getDouble(String prompt, double min, double max) {
            double d = 0;
            Boolean isValid = false;
            while (!isValid) {
                d = getInt(prompt);
                if (d <= min) {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                } else if (d >= max) {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                } else {
                    isValid = true;
                }
            }
            return d;
        }
        public static Boolean getBoolean(String prompt, String valTrue, String valFalse) {
            Boolean retBoolean = false;
            Boolean isValid = false;
            String s = "";
            while (!isValid) {
                s = getRequiredString(prompt);
                if (!(s == (valTrue)) && !(s == (valFalse))) {
                    Console.WriteLine("Error! Entry must be '" + valTrue + "' or '" + valFalse + "'. Try again.");
                } else {
                    isValid = true;
                    // entry is valid... now return true or false (default)
                    if (s == (valTrue)) {
                        retBoolean = true;
                    }
                }
            }
            return retBoolean;

        }
        // This method will print the prompt then follow with "Enter month... day... year" prompts
        // Note:  will need enhancement to manage leap year
        /*
        public static DateTime getLocalDate(String prompt) {
            DateTime ld;
            Boolean isValid = false;
            while (!isValid) {
                Console.WriteLine(prompt);
                int month = getInt("Enter month (1-12): ", 0, 13);
                int day = getInt("Enter day of month (1-31): ", 0, 32);
                int year = getInt("Enter year (> 0): ", 0, Integer.MAX_VALUE);
                try {
                    ld = DateTime.of(year, month, day);
                    isValid = true;
                } catch (Exception e) {
                    Console.WriteLine("Error constructing date from entries.  Try again.");
                }
            }
            return ld;
        }
        */

    }
}

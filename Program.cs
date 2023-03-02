class Program {
    static void Main (string[]args) {
        Console.WriteLine("Please select menu 'Type the small latter.'");
        Console.WriteLine("------------");
        Console.WriteLine("1. CIA");
        Console.WriteLine("2. FBI");
        Console.WriteLine("3. NSA");

            Console.Write("Input menu: ");  //input 1,2 or 3 to choose
            string input = Console.ReadLine();

                switch(input) { // process for CIA
                    case "cia":
                    Console.Clear();
                    Console.WriteLine("You choose 'CIA'");
                    Console.Write("Please input password: ");
                    int cia = int.Parse(Console.ReadLine());

                        if (cia > 100000 && cia < 999999 ) {       
                            bool pass1 = (int)cia % 10 == 3 || cia % 10 == 6 || cia % 10 == 9;
                            Console.WriteLine("The unit digit is divisible by 3: {0}", pass1);

                            int pass002 = cia % 100;
                            int pass02 = pass002 / 10;
                            bool pass2 = pass02 != 1 && pass02 !=3 && pass02 != 5;
                            Console.WriteLine("The tens digits of your password cannot be 1, 3, and 5: {0}", pass2);

                            int pass003 = cia % 10000;
                            int pass03 = pass003 / 1000;
                            bool pass3 = pass03 > 6 && pass03 < 8 && pass03 !=8;
                            Console.WriteLine("The thousands digits of the password cannot be less than 6 and not equal to 8: {0}", pass3);

                            bool resultPass = pass1 && pass2 && pass3;

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Your 'CIA' password {0} is {1}",cia, resultPass);
                            Console.WriteLine("------------------------");
                        }
                        else {
                        Console.WriteLine("Please enter a 6-digit password.");
                        }
                

                    break;
                
                
                    case "fbi":
                    Console.Clear();
                    Console.WriteLine("You choose 'FBI'");
                    Console.Write("Please input password: ");
                    int fbi = int.Parse(Console.ReadLine());

                        if (fbi > 100000 && fbi < 999999 ) {   
                            int pass01 = fbi / 100000;    
                            bool pass10 = pass01 != 1 && pass01 != 2 && pass01 != 3 && pass01 != 8 && pass01 != 9;
                            Console.WriteLine("The number of hundred thousand of the password must be between 4-7 only: {0}", pass10);

                            int pass002 = fbi % 1000;
                            int pass02 = pass002 / 100;
                            bool pass20 = pass02 != 1 && pass02 !=3 && pass02 != 5 && pass02 != 6 && pass02 != 7 && pass02 != 9;
                            Console.WriteLine("The hundreds digit of the password must be divisible by 2 and not equal to 6: {0}", pass20);

                            int pass003 = fbi % 100000;
                            int pass03 = pass003 / 10000;
                            bool pass30 = pass03 != 2 && pass03 != 4 && pass03 != 6 && pass03 != 8;
                            Console.WriteLine("The tens of thousands of the password must be an odd number: {0}", pass30);

                            bool resultPass = pass10 && pass20 && pass30;

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Your 'FBI' password {0} is {1}",fbi, resultPass);
                            Console.WriteLine("------------------------");
                        }
                        else {
                        Console.WriteLine("Please enter a 6-digit password.");
                        }

                    break;
                
                    case "nsa":
                    Console.Clear();
                    Console.WriteLine("You choose 'NSA'");
                    Console.Write("Please input password: ");
                    int nsa = int.Parse(Console.ReadLine()); 

                    if (nsa > 100000 && nsa < 999999 ) { 
                            int pass001 = nsa % 10;     
                            bool pass100 = pass001 != 4 && pass001 != 7 && pass001 != 8 && pass001 != 9;
                            Console.WriteLine("The required digit of the payment must contain 30: {0}", pass100);
                            
                            int pass002 = nsa % 100;
                            int pass02 = pass002 / 10; 
                            bool pass200 = pass002 != 2 && pass002 != 4 && pass002 != 6 && pass002 != 8;
                            Console.WriteLine("The hundreds digit of the password must be divisible by 3: {0}", pass200);

                            int pass003n1 = nsa / 100000;

                            int pass003n2 = nsa % 100000;
                            int pass003n02 = pass003n2 / 10000;

                            int pass003n3 = nsa % 10000;
                            int pass003n03 = pass003n3 / 1000;

                            int pass003n4 = nsa % 1000;
                            int pass003n04 = pass003n4 / 100;
                            
                            int pass003n5 = nsa % 100;
                            int pass003n05 = pass003n5 / 10;

                            int pass003n6 = pass003n1 % 10;

                            bool pass300 = pass003n1 == 7 || pass003n02 == 7 || pass003n03 == 7 || pass003n04 == 7 || pass003n05 == 7 || pass003n6 == 7;
                            Console.WriteLine("There must be at least one number 7 in the password: {0}", pass300);


                            bool resultPass = pass100 && pass200 && pass300;

                            Console.WriteLine("------------------------");
                            Console.WriteLine("Your 'NSA' password {0} is {1}",nsa, resultPass);
                            Console.WriteLine("------------------------");
                        }
                        else {
                        Console.WriteLine("Please enter a 6-digit password.");
                        }
                    break;
        }   
    }
}

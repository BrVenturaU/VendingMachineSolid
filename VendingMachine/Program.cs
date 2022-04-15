var vendingMachine = new VendingMachine(new CsvMenuLoader(@"./Resources/menu.csv"));
vendingMachine.Start();
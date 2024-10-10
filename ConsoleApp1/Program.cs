// See https://aka.ms/new-console-template for more information
Random dice = new Random();



int daysUntilExiration = dice.Next(12);
int discountPercentage = 0;

if (daysUntilExiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if ( daysUntilExiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    Console.WriteLine("Renew now and save "+discountPercentage+ "%!");
} else if (daysUntilExiration >= 0 && daysUntilExiration <=5) {
    Console.WriteLine("Your subscription expires in " +daysUntilExiration+ "days.");
    discountPercentage = 10;
    Console.WriteLine("Renew now and save "+discountPercentage+"%!");
} else if (daysUntilExiration >= 5 && daysUntilExiration <= 10) {
    Console.WriteLine("Your subscription expiresn soon. Renew now!");
}
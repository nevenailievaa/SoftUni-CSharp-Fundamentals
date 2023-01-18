//INPUT
int numberPeopleOnVacation = int.Parse(Console.ReadLine());
string typeGroup = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();

//CHANGEABLE
double oneTicketPrice = 0;
double ticketsSum = 0;

//ACTION
//Friday
if (dayOfTheWeek == "Friday")
{
	if (typeGroup == "Students")
	{
		oneTicketPrice = 8.45;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 30)
        {
            ticketsSum -= (ticketsSum * 0.15);
        }
	}
    else if (typeGroup == "Business")
    {
        oneTicketPrice = 10.90;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 100)
        {
            ticketsSum -= (oneTicketPrice * 10);
        }
    }
    else if (typeGroup == "Regular")
    {
        oneTicketPrice = 15.00;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 10 && numberPeopleOnVacation <= 20)
        {
            ticketsSum -= (ticketsSum * 0.05);
        }
    }
}
//Saturday
if (dayOfTheWeek == "Saturday")
{
    if (typeGroup == "Students")
    {
        oneTicketPrice = 9.80;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 30)
        {
            ticketsSum -= (ticketsSum * 0.15);
        }
    }
    else if (typeGroup == "Business")
    {
        oneTicketPrice = 15.60;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 100)
        {
            ticketsSum -= (oneTicketPrice * 10);
        }
    }
    else if (typeGroup == "Regular")
    {
        oneTicketPrice = 20.00;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 10 && numberPeopleOnVacation <= 20)
        {
            ticketsSum -= (ticketsSum * 0.05);
        }
    }
}
//Sunday
if (dayOfTheWeek == "Sunday")
{
    if (typeGroup == "Students")
    {
        oneTicketPrice = 10.46;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 30)
        {
            ticketsSum -= (ticketsSum * 0.15);
        }
    }
    else if (typeGroup == "Business")
    {
        oneTicketPrice = 16.00;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 100)
        {
            ticketsSum -= (oneTicketPrice * 10);
        }
    }
    else if (typeGroup == "Regular")
    {
        oneTicketPrice = 22.50;
        ticketsSum = oneTicketPrice * numberPeopleOnVacation;

        if (numberPeopleOnVacation >= 10 && numberPeopleOnVacation <= 20)
        {
            ticketsSum -= (ticketsSum * 0.05);
        }
    }
}

//OUTPUT
Console.WriteLine($"Total price: {ticketsSum:f2}");

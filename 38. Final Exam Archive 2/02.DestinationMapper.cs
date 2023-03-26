using System.Text.RegularExpressions;

//INPUT
string inputPlaces = Console.ReadLine();

//ACTION
Regex placeRegex = new Regex(@"(?<separator>=|\/)(?<destination>[A-Z][A-Za-z]{2,})\k<separator>");
MatchCollection placesMatch = placeRegex.Matches(inputPlaces);
List<string> placesList = new List<string>();

int points = 0;
foreach (Match place in placesMatch)
{
    points += place.Groups["destination"].Value.Length;
    placesList.Add(place.Groups["destination"].Value);
}

//OUTPUT
Console.WriteLine($"Destinations: {String.Join(", ", placesList)}");
Console.WriteLine($"Travel Points: {points}");

//Now that you have planned out your tour, you are ready to go! Your next task is to
//mark all the points on the map that you are going to visit.

//You will be given a string representing some places on the map. You have to filter
//only the valid ones. A valid location is:

//Surrounded by "=" or "/" on both sides (the first and the last symbols must match)
//After the first "=" or "/" there should be only letters (the first must be upper-case,
//other letters could be upper or lower-case)
//The letters must be at least 3
//Example: In the string "=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=" only the
//first two locations are valid.

//After you have matched all the valid locations, you have to calculate travel points.
//They are calculated by summing the lengths of all the valid destinations that you have
//found on the map. 

//In the end, on the first line, print: "Destinations: {destinations joined by ', '}". 
//On the second line, print "Travel Points: {travel_points}".

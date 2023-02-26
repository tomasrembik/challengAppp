// zadanko domowe dzien 4

var name = "EWA";
bool woman = true;
var age = 33;

if ( woman == false && age < 18 )
{
    Console.WriteLine(" Niepełnoletni mężczyzna");
}
else if ( woman == true && age < 30)
{
    Console.WriteLine(" Kobieta poniżej 30 lat");
}
else if ( name == "EWA" && age == 33)
{
    Console.WriteLine("EWA, lat 33");
}

public class Menu
{
    static public int menuOptions(){
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Save \n 4. Load \n 5. Quit");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    
}

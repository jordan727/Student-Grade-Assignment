// Student Grades Assignment by Jordan A
#nullable disable
Console.Clear();

// Random Object
Random rnd = new Random();

bool loop = true;

// Student Grades Array
int[] studentGrades = new int[35];

for (int n = 0; n < studentGrades.Length; n++) {
    studentGrades[n] = rnd.Next(0, 101);
}

// Welcome
while (loop) {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("1. Display All Grades");
    Console.WriteLine("2. Display Honours");
    Console.WriteLine("3. Stats");
    Console.WriteLine("4. Randomize Grades");
    Console.WriteLine("5. Exit\n");
    string option = Console.ReadLine();

    if (option == "1") {
        Console.WriteLine("ALL GRADES");
    for (int n = 0; n < studentGrades.Length; n++) {
        Console.WriteLine($"{studentGrades[n]}%");
    }
    } else if (option == "2") {
        int honoursCount = 0;
    for (int n = 0; n < studentGrades.Length - 1; n++) {
        if (studentGrades[n] > 80) {
            honoursCount++;
            Console.WriteLine($"{studentGrades[n]}%");
        }
    }
        Console.WriteLine($"Number of Honours: {honoursCount}\n");
    } else if (option == "3") {
        Console.WriteLine("STATS");
        double avg = Queryable.Average(studentGrades.AsQueryable());
        int average = Convert.ToInt32(avg);
        int highest = studentGrades.Max();
        int lowest = studentGrades.Min();
        Console.WriteLine($"Highest Grade:{highest}%");
        Console.WriteLine($"Lowest Grade:{lowest}%");
        Console.WriteLine($"Average Grade:{average}%\n");
    } else if (option == "4") {
        for (int n = 0; n < studentGrades.Length; n++) {
            studentGrades[n] = rnd.Next(0, 101);
    }
        Console.WriteLine("GRADES HAVE BEEN RANDOMIZED\n");
    } else if (option == "5") {
        loop = false;
    } else {
        Console.WriteLine("INVALID ANSWER\n");
    }
}
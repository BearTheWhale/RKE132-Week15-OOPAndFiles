using System.Reflection;
List<Movie> myMovie = new List<Movie>();
string[] data = GetDataFromFile();

//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMoie = new Movie(tempArray[0], tempArray[2]);
    myMovie.Add(newMoie);
}

foreach (Movie movie in myMovie)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromFile()
{
    string filePath = @"C:\Users\Makrus\Desktop\Data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);  //Seda saab kasutada ga pole vaja
    //return dataFromFile;
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;    //fields
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }

}
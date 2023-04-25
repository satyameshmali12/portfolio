namespace Portfolio;

public class GithubRepo
{
    public string? Name{get;set;}
    public string? Description{get;set;}

    public string? Url{get;set;}

    public string? LanguagesUsed {get;set;}

    public GithubRepo(string Name,string Description,string Url,string LanguagesUsed)
    {
        this.Name = Name;
        this.Description = Description;
        this.Url = Url;
        this.LanguagesUsed = LanguagesUsed;
    }
    public static List<GithubRepo> GetGithubRepos()
    {
        return new List<GithubRepo>()
        {
            new GithubRepo("Alphabetical_Arranger","A simple algorithm to arrange the letter(words) in the Alphabetical order","https://github.com/satya…12/alphabetical_arranger","C#"),
            new GithubRepo("Alpha_Chess","A 2d chess game","https://github.com/satyameshmali12/alpha_chess","Python"),
            new GithubRepo("Block_2048","A simple 2d  game made with c#","https://github.com/satyameshmali12/block_2048","C#"),
            new GithubRepo("Calculator","Algorithm for Calculator","https://github.com/satyameshmali12/Calculator","C#"),
            new GithubRepo("Block_2048","A simple 2d  game made with c#","https://github.com/satyameshmali12/block_2048","C#"),
            new GithubRepo("flappy_bird","A 2D bird Game","https://github.com/satyameshmali12/flappy_bird","C#"),
            new GithubRepo("Ludo","A 2D Multiplayer Game","https://github.com/satyameshmali12/ludo","C#")

        };
    }
    
}
namespace Portfolio;

public class Skill
{
    public Skill(string Name, string ImageUrl, string Description)
    {
        this.Name = Name;
        this.ImageUrl = ImageUrl;
        this.Description = Description;
    }

    public string? Name { get; init; }
    public string? ImageUrl { get; init; }
    public string? Description { get; init; }

    public static List<Skill> GetSkills()
    {

        return new List<Skill>()
        {
            new Skill("C# (.Net)",
            "https://www.syncfusion.com/blogs/wp-content/uploads/2019/11/csharp-using-declaration.png"
            ,"Can develop both Web And App"),

            new Skill("Python",
            "https://img2.wallspic.com/previews/0/0/3/3/6/163300/163300-python-programming_language-standing-icon-java-x750.jpg"
            ,"Can Create modern GUI"),

            new Skill("HTML",
            "https://thumbs.dreamstime.com/b/html-coding-19596661.jpg"
            ,"Can Create Modern Website Body"),

            new Skill("CSS",
            "https://www.shutterstock.com/image-illustration/css-code-on-dark-background-260nw-1893752428.jpg"
            ,"Can create website with Awesome Design"),

            new Skill("JavaScript",
            "https://oracle-devrel.github.io/devo-image-repository/seo-thumbnails/JavaScript---Thumbnail-1200-x-630.jpg"
            ,"Can write modern Code using Vanilla JavaScript and other frameworks"),

            new Skill("Java",
            "https://contentstatic.techgig.com/photo/93158297/Oracle-to-discontinue-extended-support-for-Java-7.jpg"
            ,"Knows the basic of the Java")
        };


    }
    public static List<Skill> GetFrameworks()
    {
        return new List<Skill>()
        {
            new Skill("Blazor","https://www.howtogeek.com/wp-content/uploads/csit/2021/08/bca5f5f6-1.png?height=200p&trim=2,2,2,2","Single Page Application.This portfolio is being Created in Blazor"),
            new Skill("Asp Net Web Api","https://nullablereference.files.wordpress.com/2019/12/13_aspnetcorewebapi.png","Application API."),
            new Skill("Godot","https://i.pcmag.com/imagery/reviews/04rQ7uhK3XVvRCnUs39JGrh-1.fit_lim.size_1050x591.v1611784715.png","Mine Deskstop Application"),
            new Skill("React.js","https://miro.medium.com/v2/resize:fit:1200/1*y6C4nSvy2Woe0m7bWEn4BA.png","To create single page application in JavaScript"),
            new Skill("Next.js","https://mobisoftinfotech.com/resources/wp-content/uploads/2022/04/next-JS-framework.png","Single page application with some other concepts such as server side rendering in JavaScript"),
            new Skill("Strapi","https://mms.businesswire.com/media/20220209005201/en/792790/23/Logo.WhiteBackground.jpg","For Dealing with the api by just using a GUI interface"),
            new Skill("Kaboom.js","https://replit.com/cdn-cgi/image/quality=80,metadata=copyright,format=auto/https://storage.googleapis.com/replit/images/1608678252894_b96a26f00b956e1fb61d3432644ffbfc.png","Javascript 2D Game"),
            new Skill("PyGame","https://i.ytimg.com/vi/AY9MnQ4x3zk/maxresdefault.jpg","For 2D games in python"),
            new Skill("MongoDB","https://webimages.mongodb.com/_com_assets/cms/kuzt9r42or1fxvlq2-Meta_Generic.png","I use it for storing my data (No sql database)")
        };
    }
}















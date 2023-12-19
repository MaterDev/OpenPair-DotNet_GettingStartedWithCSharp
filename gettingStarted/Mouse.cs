namespace GettingStarted;
class Mouse {
    public string? Name { get; set; }

    // This value only will get when manually when Mouse is used.
    public static int? SecretCode = null;

    public void Introduce(){
        Console.WriteLine($"Mouse Name: {Name} {Emoji()}");
    }
    
    public void GetSecretCode() {
        Console.WriteLine($"Secret Code for {Name}: {SecretCode}");
    }

    // Emoji() is a private method, so it cannot be used outside of the class.
    private String Emoji() {
        return "🐁";
    }
}


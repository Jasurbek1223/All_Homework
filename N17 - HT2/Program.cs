namespace N17___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        ChatServise chatServise = new ChatServise();

        int id1 = chatServise.Add("Salom Hammaga!");
        int id2 = chatServise.Add("Darsni boshlaymizmi?");
        int id3 = chatServise.Add("15 daqiqada boshlaymiz");
      
        chatServise.Update(id2, "Bugun dars bo'lmaydi!");
        chatServise.Update(id3, "Ertaga Juma!");

        chatServise.Display();
    }
}   
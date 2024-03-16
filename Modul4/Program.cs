public class KodeBuah
{
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika,
        Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian
        , Anggur, Melon, Semangka
    }
    public static string GetKodeBuah(NamaBuah buah)
    {
        string[] FruitCode = {"A00", "B00", "C00", "D00", "E00", "F00",
        "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        return FruitCode[(int)buah];
    }
}

public class PosisiKarakterGame {
    enum State { Berdiri, Terbang, Jongkok, Tengkurap };
    public static void gas()
    {
        State state = State.Berdiri;
        string[] screenName = { "Berdiri", "Terbang", "Jongkok", "Tengkurap" };
        while (true)
        {
            Console.WriteLine("Sekarang sedang " + screenName[(int)state]);
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();
            switch (state)
            {
                case State.Berdiri:
                    if (command == "W")
                    {
                        state = State.Terbang;
                    } else if (command == "S")
                    {
                        state = State.Jongkok;
                    } else
                    {
                        state = State.Berdiri;
                        Console.WriteLine("Posisi StandBy");
                    }
                    break;
                case State.Terbang:
                    if (command == "X")
                    {
                        state = State.Jongkok;
                    } else if (command == "S")
                    {
                        state = State.Berdiri;
                        Console.WriteLine("Posisi Standby");
                    } else
                    {
                        state = State.Jongkok;
                    }
                    break;
                case State.Jongkok:
                    if (command == "W")
                    {
                        state = State.Berdiri;
                        Console.WriteLine("Posisi StandBy");
                    } else if (command == "S")
                    {
                        state = State.Tengkurap;
                        Console.WriteLine("Posisi Istirahat");
                    } else
                    {
                        state = State.Jongkok;
                    }
                    break;
                case State.Tengkurap:
                    if(command == "W")
                    {
                        state = State.Jongkok;
                    } else
                    {
                        state = State.Tengkurap;
                        Console.WriteLine("Posisi Istirahat");
                    }
                    break; 
            }
        }
    }
}



public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukan nama buah: ");
        string inputbuah = Console.ReadLine();

        KodeBuah.NamaBuah buah;
        if (Enum.TryParse(inputbuah, true, out buah))
        {
            string FruitCode = KodeBuah.GetKodeBuah(buah);
            Console.WriteLine("Kode Buah untuk buah " + inputbuah
                + " adalah " + FruitCode);
        }
        else
        {
            Console.WriteLine("buah tidak valid");
        }
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        PosisiKarakterGame.gas();
    }
}



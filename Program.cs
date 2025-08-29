
internal class Program
{
    private static void Main(string[] args)
    {
        Ex01();
        Ex02();
    }
    private static void Ex01()
    {
        Console.WriteLine("CHAO MUNG BAN DEN VOI TRO CHOI DOAN SO\n");
        int money = 100;
        Console.WriteLine("Ban dang co 100$\n");
        int so_van_choi = 0;
        int so_van_thang = 0;
        int so_van_thua = 0;
        do
        {
            so_van_choi++;
            Console.WriteLine(@"Chon cap do choi 

1-De (10 lan doan)
2-Trung binh (7 lan doan)
3-Kho (4 lan doan)");
            Console.Write("Cap ban chon la (1,2,3): ");
            string Cap_do = Console.ReadLine();
            int level;
            int so_lan_choi = 0;
            if (int.TryParse(Cap_do, out level))
            {
                if (level == 1)
                    so_lan_choi = 10;
                else if (level == 2)
                {
                    so_lan_choi = 7;
                }
                else if (level == 3)
                {
                    so_lan_choi = 4;
                }
                else
                {
                    Console.WriteLine("Ban vui long nhap dung CAP DO CHOI (1, 2, 3): "); //Loi nhap so khong phai so 1,2,3
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ban vui long nhap dung CAP DO CHOI (1, 2, 3): "); // Loi nhap khong phai so
                return;
            }
            Random rdm = new Random();
            int number = rdm.Next(0, 101);
            bool win = false;
            for (int i = 0; i < so_lan_choi; i++)
            {
                Console.Write("So ban doan (0-100) la: ");
                string input = Console.ReadLine();
                int guess;
                if (int.TryParse(input, out guess))
                {
                    if (number == guess)
                    {
                        win = true;
                        Console.WriteLine("You Win");
                        so_van_thang++;
                        break;
                    }
                    else if (number > guess && guess > 0)
                    {
                        Console.WriteLine("So ban doan nho hon so may doan");
                    }
                    else if (number < guess && guess < 100 && guess > 0)
                    {
                        Console.WriteLine("So ban doan lon hon so may doan");
                    }
                    else
                    {
                        Console.WriteLine("Ban vui long nhap so trong khoang 0-100"); //Loi nhap so lon hon 100
                    }
                }
                else
                {
                    Console.WriteLine("Ban vui long nhap so trong khoang 0-100"); //Loi nhap khong phai so
                }
            }
            if (!win)
            {
                Console.WriteLine($"You Lose! So may doan la: {number}");
                so_van_thua++;
            }
            if (win)
            {
                if (level == 1)
                {
                    money += 4;
                    Console.WriteLine($"Ban dang co {money}$");
                }
                else if (level == 2)
                {
                    money += 7;
                    Console.WriteLine($"Ban dang co {money}$");
                }
                else if (level == 3)
                {
                    money += 10;
                    Console.WriteLine($"Ban dang co {money}$");
                }
            }
            else if (money > 0)
            {
                if (level == 1)
                {
                    money -= 4;
                    Console.WriteLine($"Ban dang co {money}$");
                }
                else if (level == 2)
                {
                    money -= 7;
                    Console.WriteLine($"Ban dang co {money}$");
                }
                else if (level == 3)
                {
                    money -= 10;
                    Console.WriteLine($"Ban dang co {money}$");
                }
            }
            else
            {                 
                Console.WriteLine("Ban da het tien! Tro choi ket thuc");
                so_van_thua++;
                break;
            }
            Console.Write("Ban co muon tiep tuc choi nua khong (c/k): ");
            string restart = Console.ReadLine();
            if (restart == "k")
            {
                break;
            }
        }
        while (true); 
        Console.WriteLine($"Ban da choi {so_van_choi} lan");
        Console.WriteLine($"So van ban thang: {so_van_thang}");
        Console.WriteLine($"So van ban thua: {so_van_thua}");
        Console.WriteLine($"So tien con lai cua ban: {money}$");
        Console.WriteLine("\nHen gap lai lan sau!");
    }
    private static void Ex02()
    {
        Console.WriteLine("Ban dang co 100$");
        int money = 100;
        int so_lan_lap = 0;
        int so_van_thang = 0;
        int so_van_thua = 0;
        do
        {
            so_lan_lap ++;
            Random xuc_xac_1 = new Random();
            int xx_1 = xuc_xac_1.Next(1, 6);
            Random xuc_xac_2 = new Random();
            int xx_2 = xuc_xac_2.Next(1, 6);
            int tong = xx_1 + xx_2;
            string ket_qua;
            if (tong>5)
            {
                ket_qua = "Tai" ;
            }
            else if (tong<5)
            {
                ket_qua ="Xiu" ;
            }
            else
            {
                ket_qua = "5" ;
            }
            Console.Write("Ban doan Tai hay Xiu hay truong hop Dat biet (5): ");
            string tl = Console.ReadLine();
            if (tong > 5)
            {
                if (tl.ToLower() == "tai")
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine($"Ban dang co {money += 5}$ ");
                    so_van_thang++;
                }
                else if (tl.ToLower() == "xiu")
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine($"Ban dang co {money -= 5}$ ");
                    so_van_thua++;
                }
                else if (tl == "5" || tl.ToLower() == "dat biet")
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine($"Ban dang co {money -= 15}$ ");
                    so_van_thua++;
                }
            }
            else if (tong < 5)
            {

                if (tl.ToLower() == "tai")
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine($"Ban dang co {money -= 5}$ ");
                    so_van_thua++;
                }
                else if (tl.ToLower() == "xiu")
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine($"Ban dang co {money += 5}$ ");
                    so_van_thang++;
                }
                else if (tl == "5" || tl.ToLower() == "dat biet")
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine($"Ban dang co {money -= 15}$ ");
                    so_van_thua++;
                }
            }
            else if (tong == 5)
            {
                if (tl == "5" || tl.ToLower() == "dat biet")
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine($"Ban dang co {money += 15}$ ");
                    so_van_thang++;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine($"Ban dang co {money -= 15}$ ");
                    so_van_thua++;
                }
            }
            Console.WriteLine($"May doan {ket_qua}");
            Console.Write("Ban co muon tiep tuc choi nua khong (c/k): ");
            string restart = Console.ReadLine();
            if (restart == "k")
            {
                break;
            }
            if (money <= 0)
            {
                Console.WriteLine("Ban da het tien! Tro choi ket thuc");
                break;
            }
        } while (true);
        Console.WriteLine($"Ban da choi {so_lan_lap} lan");
        Console.WriteLine($"So van ban thang: {so_van_thang}");
        Console.WriteLine($"So van ban thua: {so_van_thua}");
        Console.WriteLine($"So tien con lai cua ban: {money}$");
        Console.WriteLine("\nHen gap lai lan sau!");
    }
}
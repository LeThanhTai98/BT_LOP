
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

  namespace Btlop
{ 
    class nhapfile { 
        private String _fileName;
        int column = 0;
        int height = 0;
        int containers = 0;
        int heightyard = 0;
        List<int> same = new List<int>();
        List<Stack<double>> stacks = new List<Stack<double>>();
        
        public void im()
        {
            for (int i = 0; i < column; i++)
            {
                Stack<double> k = new Stack<double>();
                Stacks.Add(k);
            }
        }
        public String FileName
        {
            set
            {
                _fileName = value;
            }
            get
            {
                return _fileName;
            }
        }

        
        public int Column { get => column; set => column = value; }
        public int Height { get => height; set => height = value; }
        public int Containers { get => containers; set => containers = value; }
        public int Heightyard { get => heightyard; set => heightyard = value; }
        public List<Stack<double>> Stacks { get => stacks; set => stacks = value; }

        

        private String pathProject ;
        
        public nhapfile()
        {
            String path = Environment.CurrentDirectory;
            String[] pathProjects = Regex.Split(path, @"bin");
            pathProject = pathProjects[0];
        }

        public void ReadData()
        {
            
                String str = null;
                try
                {
                using (StreamReader sr = new StreamReader(pathProject + FileName))
                {
                    while ((str = sr.ReadLine()) != ("//yard"))
                    {
                        String[] word = Regex.Split(str, "//");
                        for (int i = 0; i < word.Length; i++)
                        {
                            int number = 0;

                            if (word[i] == ("height"))
                            {
                                number = Convert.ToInt32(word[0]);
                                Height = number + 1;
                            }
                            if (word[i] == ("columns"))
                            {
                                number = Convert.ToInt32(word[0]);
                                Column = number + 1;
                            }
                            if (word[i] == ("containers"))
                            {
                                number = Convert.ToInt32(word[0]);
                                Containers = number;
                            }
                            if (word[i] == ("yard"))
                            {
                                break;
                            }
                        }
                    }

                    Console.WriteLine(Height);
                    Console.WriteLine(Column);
                    Console.WriteLine(Containers);
                    if (str == ("//yard"))
                    {
                        while ((str = sr.ReadLine()) != ("//containers"))
                        {
                            String[] word = Regex.Split(str, "//");
                            for (int i = 0; i < word.Length; i++)
                            {
                                int number = 0;

                                if (word[i] == ("height"))
                                {
                                    number = Convert.ToInt32(word[0]);
                                    Heightyard = number;
                                }
                                if (word[i] == ("containers"))
                                {
                                    break;
                                }
                            }

                        }
                        Console.WriteLine(Heightyard);
                        int temp = 0;
                        String[,] tempString = new String[Height, Column];
                        while (((str = sr.ReadLine()) != null))
                        {
                            if (temp >= Height) break;
                            String[] word = str.Split('	');
                            foreach (string a in word)
                                Console.Write(a);
                            Console.WriteLine(word.Length);
                            for (int i = 0; i < word.Length; i++)
                            {
                                tempString[temp, i] = word[i];


                            }

                            temp++;
                            Console.WriteLine("temp la " + temp);
                        }


                        int numbers = 0;
                        bool success;
                        this.im();
                        for (int i = 0; i < Column; i++)
                        {


                            for (int j = Height - 1; j >= 0; j--)
                            {

                                success = Int32.TryParse(tempString[j, i], out numbers);
                                if (success)
                                {
                                    int tempNum = numbers;
                                    double tempNum2 = 0;
                                    if (same.Count == 0) same.Add(tempNum);
                                    else
                                    {
                                        foreach (int a in same)
                                        {
                                            if (tempNum == a)
                                            {
                                                if (tempNum2 == 0)
                                                {
                                                    tempNum2 = Convert.ToDouble(tempNum);
                                                    tempNum2 += 0.1;
                                                }
                                                else tempNum2 += 0.1;
                                            }
                                            
                                        }
                                        if (tempNum2 == 0) same.Add(tempNum);
                                    }
                                    if (tempNum2 == 0) Stacks[i].Push(numbers);
                                    else stacks[i].Push(tempNum2);
                                }
                            }

                        }
                        sr.Close();
                    }
                }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Unable to open file '" + FileName + "'");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading file '" + FileName + "'");
                }
                
            
                
               
        }

        
        
        public void saveFile(storage y, String fileName, double ti)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathProject + fileName, true))
                {
                    file.Write("\r\n" + "//OUTPUT" + "\r\n");
                    file.Write(y.Num + "//Total Cost of moving" + "\r\n");
                    file.Write("0//Cost of moving to Temporary Yard" + "\r\n");
                    file.Write(ti + "s//Total Cost of moving" + "\r\n");
                    file.Write("//Containers Position in Main Yard" + "\r\n");
                    file.Write(y.showstorage());
                    file.Write("\r\n" + "//Containers Temporary Yard" + "\r\n");
                    file.Write("\r\n" + "//Schedule of Moving" + "\r\n");
                    file.Write(y.Str1);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Success...");
        }
        public void xuat()
        {
            for (int i = 0; i < Column; i++)
            {
                foreach (int a in Stacks[i])
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
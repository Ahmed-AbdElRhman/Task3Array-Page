using System;

namespace task2_ArrPage
{
    class Program
    {
        static void Main(string[] args)
        {   
              String chose="";
              int NumOfPage,flage=0;
            Console.WriteLine("plz Ent Size");
            int size =int.Parse(Console.ReadLine());
            string[] item=new string[size];
            //___________________________________________
            for (int i = 0; i < size; i++)
            {
             // item[i]=Convert.ToString(i+1);
                item[i]=""+(i+1);
            }
            //___________________________________________
            Console.WriteLine("plz Ent NumPerPage");
            int NumPerPage=int.Parse(Console.ReadLine());
             
             if(size%NumPerPage==0)
             {
                 NumOfPage=size/NumPerPage;
                 Console.WriteLine("Number of Page is: "+NumOfPage);
                 
             }
             else
             {
                 NumOfPage=(size/NumPerPage)+1;
                 Console.WriteLine("Number of Page is: "+NumOfPage);
             }
             //________________________________________chose N P out____________________
             int end=NumPerPage;
             int start=0;
             int page=1;
             do
             {   
                 
                 for ( int i = start; i < end&&flage==0; i++)
                 {
                     Console.WriteLine("            "+item[i]);
                 }
                 Console.WriteLine("Plz Chose P or N Or Out");
                 chose=Console.ReadLine();
                if(chose=="N"||chose=="n")
                {  
                    if(end==size){Console.WriteLine("Sorry no More Page this is the last page");flage=1;} 
                    else 
                    {    
                        if(end<size)
                         {start=end;
                         page++;
                         end+=NumPerPage;
                         flage=0;
                         }
                        if(end>size){end=size;flage=0;}
                    }
                }
                else if(chose=="P"||chose=="p")
                {   
                    if(start==0){Console.WriteLine("Sorry this is the first page");flage=1;} 
                    else 
                    {    
                        if(start>0)
                         {end=start;
                         page--;
                         start-=NumPerPage;
                         flage=0;
                         }
                        if(start<0){start=0;flage=0;}
                    }
                }
                else
                
                
                {
                    Console.Write("Sorry::");
                    flage=1;
                    
                }
                 
             } while (chose!="Out"||chose!="out");            
        }
    }
}

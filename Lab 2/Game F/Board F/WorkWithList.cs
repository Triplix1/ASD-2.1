using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_F
{
    internal static class WorkWithList//Клас для роботи з списками
    {
        public static bool Contain(List<Node> arr, Node K)//Перевірка чи містить список передане гральне поле
        {
            int start = 0;//Ліва границя
            int end = arr.Count - 1;// Права границя

            while (start <= end)
            {
                int mid = (start + end) / 2;// Середина

                if (arr[mid].H == K.H)
                {
                    var tmp = mid;
                    while (mid != 0 && arr[mid - 1].H == K.H)
                    {
                        mid--;
                    }
                    return true;
                }

                else if (arr[mid].F < K.F)
                    start = mid + 1; 

                else
                    end = mid - 1;
            }
            return false;
        }
        public static void Add(List<Node> arr, Node K)//Додавання грального поля в відсортований список
        {
            int start = 0;//Ліва границя
            int end = arr.Count - 1;// Права границя

            while (start <= end)
            {
                int mid = (start + end) / 2;// Середина

                if (arr[mid].F == K.F)
                {
                    while (mid != 0 && arr[mid - 1].F == K.F)
                    {
                        mid--;
                    }
                    arr.Insert(mid, K);
                    return;
                }

                else if (arr[mid].F < K.F)
                    start = mid + 1;

                else
                    end = mid - 1;
            }
            arr.Insert(end + 1, K);
        }
    }
}

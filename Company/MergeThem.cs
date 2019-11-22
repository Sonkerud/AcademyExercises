using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public static class MergeThem
    {

        public static string HaveSameProperty<T1, T2>(List<T1> list1, List<T2> list2)
        {
          
            var list1Properties = list1[0].GetType().GetProperties();
            var list2Properties = list2[0].GetType().GetProperties();
            
            string output = "";

            for (int i = 0; i < list1Properties.Length; i++)
            {
                for (int y = 0; y < list2Properties.Length; y++)
                {
                    if (list1Properties[i].Name == list2Properties[y].Name)
                    {
                        output = ExtractPropertyName(list1Properties[i].ToString());
                    }
                }
            }

            return output;
        }

        public static string ExtractPropertyName(string str)
        {
           return str.Replace("System.String ", "");
        }


        public static  List<T1> ObjectMerger<T1,T2> (List<T1> list1, List<T2> list2, List<T1> list3)
        {
            var propertyName = HaveSameProperty(list1, list2);
                       
            for (int i = 0; i < list1.Count; i++)
            {
                for (int y = 0; y < list2.Count; y++)
                {
                    if (list1[i].GetType().GetProperty(propertyName).GetValue(list1[i]) == list2[y].GetType().GetProperty(propertyName).GetValue(list2[y]))
                    {
                        if (!list3.Contains(list1[i]))
                        {
                            list3.Add(list1[i]);

                        }

                    }
                }
            }

          return list3;
        }
    }
}

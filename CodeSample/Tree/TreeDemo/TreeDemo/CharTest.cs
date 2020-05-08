using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class CharTest
    {
        public  List<int> balancedOrNot(List<string> expressions, List<int> maxReplacements)
        {

            List<int> response = new List<int>();
            if (!maxReplacements.Any())
            {
                return response;
            }

            for (int i = 0; i < maxReplacements.Count; i++)
            {

                var expression = expressions[i];
                if (maxReplacements[i] > Math.Pow(10, 2))
                {
                    response.Add(0);
                    continue;
                }
                if (expression.EndsWith("<"))
                {
                    response.Add(0);
                    continue;
                }

                if ( expression.Length > Math.Pow(10, 5) || expression.Length < 1)
                {
                    response.Add(0);
                    continue;
                }

                if (maxReplacements[i] > Math.Pow(10, 5) || maxReplacements[i] < 0)
                {
                    response.Add(0);
                    continue;
                } 

                int greaterThanCount = expression.Count(x => x == '>');
                int lesserThanCount = expression.Count(x => x == '<');


                if (greaterThanCount == lesserThanCount)
                {
                    response.Add(1);
                }
                else
                {
                    if (lesserThanCount > greaterThanCount)
                    {
                        response.Add(0);
                    }
                   
                    else
                    {

                        //var doubleReplacements = expression.Contains(">>");
                        //int doubleReplacementCount = 0;
                     
                        //var charArray = expression.ToCharArray();

                        //for (int j = 0; j < charArray.Length; j++)
                        //{
                        //    if (charArray[j] == '>')
                        //    {
                        //        if (j < charArray.Length - 1)
                        //        {
                        //            if (charArray[j + 1] == '>')
                        //            {
                        //                doubleReplacementCount++;
                        //                j++;
                        //            }
                                   
                        //        }
                        //    }
                        //}

                        //if (doubleReplacementCount > 0)
                        //{
                        //    response.Add(maxReplacements[i] >= doubleReplacementCount ? 1 : 0);
                        //}
                       

                        var diff = greaterThanCount - lesserThanCount;
                        if (diff < 0)
                        {
                            response.Add(0);
                        }
                        else
                        {
                            response.Add(maxReplacements[i] >= diff ? 1 : 0);
                        }

                    }

                }


            }

            return response;
        }
    }
}

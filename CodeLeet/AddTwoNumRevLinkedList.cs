using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

    public class AddTwoNumRevLinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string str1 = "";
            do
            {
                str1 = str1.Insert(0, l1.val.ToString());                
                l1 = l1.next;
            }
            while (l1 != null);
            string str2 = "";
            do
            {
                str2 = str2.Insert(0, l2.val.ToString());
                l2 = l2.next;
            }
            while (l2 != null);
            ListNode returnList = null;

            var longStr = "";
            var shortStr = "";
            if (str1.Length > str2.Length)
            {
                longStr = str1;
                shortStr = str2;
            }
            else
            {
                shortStr = str1;
                longStr = str2;
            }
            int extra = 0;
            for (int index1 = longStr.Length-1, index2 = shortStr.Length -1, sum = 0;
                index1 >= 0 ;
                index1--, index2-- )
            {
                if (index2 >= 0)
                {
                    sum = Convert.ToInt16(longStr.Substring(index1, 1))
                        + Convert.ToInt16(shortStr.Substring(index2, 1))
                        + extra;
                }
                else
                {
                    sum = Convert.ToInt16(longStr.Substring(index1, 1))                       
                        + extra;
                }
                if (sum >= 10)
                {
                    sum = sum % 10;
                    extra = 1;
                }
                else
                    extra = 0;
                UpdateList(ref returnList, sum);
            }
            if(extra != 0)
                UpdateList(ref returnList, extra);
            return returnList;
        }

        public void UpdateList(ref ListNode resultList, int val)
        {
            if (resultList == null)
                resultList = new ListNode(val);
            else
                UpdateList(ref resultList.next, val);
        }

        public void ReverseListList(ref ListNode resultList, int val)
        {
            if (resultList == null)
                resultList = new ListNode(val);
            else
                resultList = new ListNode(val, resultList);
        }



        public void CreateList(List<int> ints, ref ListNode resultList)
        {
            if(ints.Any())
            {
                if (resultList == null)
                {
                    resultList = new ListNode(ints[0]);
                    ints.RemoveRange(0, 1);
                    CreateList(ints, ref resultList.next);
                }
            }            
        }
    }
}

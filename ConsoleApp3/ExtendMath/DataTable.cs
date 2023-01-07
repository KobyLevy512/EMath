using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ExtendMath
{
    internal class DataTable
    {
        private class DynNode
        {
            public dynamic Value;
            public DynNode Next;

            public DynNode(dynamic value) 
            {
                Value = value;
            }
        }
        private class DynList
        {
            DynNode head,tail;

            public DynList()
            {
                head = new DynNode(null);
                tail = head;
            }

            public void Add(dynamic v)
            {
                DynNode d = new DynNode(v);
                tail.Next = d;
                tail = d;
            }

            public void Remove(dynamic v)
            {
                DynNode prev = head;
                DynNode cur = head.Next;

                while(cur != null)
                {
                    if(cur.Value == v)
                    {
                        prev.Next = cur.Next;
                        cur.Value = null;
                        cur.Next = null;
                        return;
                    }
                }
            }

            public DynNode Head
            {
                get
                {
                    return head.Next;
                }
            }

            public uint Size
            {
                get
                {
                    DynNode cur = head.Next;
                    uint ret = 0;
                    while(cur != null)
                    {
                        ret++;
                        cur = cur.Next;
                    }
                    return ret;
                }
            }
        }
        List<string> attributes = new List<string>();
        List<DynList> data = new List<DynList>();

        /// <summary>
        /// Add attrubute header to this data
        /// </summary>
        /// <param name="name"></param>
        public void AddAttribute(string name)
        {
            attributes.Add(name);
            data.Add(new DynList());
        }

        /// <summary>
        /// Add data to this table
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public void AddData(params dynamic[] data)
        {
            if(data.Length != attributes.Count)
            {
                throw new Exception("Inserted data doesnt fit to the amount of attributes on this Data Table");
            }
            for(int i = 0; i<attributes.Count; i++)
            {
                this.data[i].Add(data[i]);
            }
        }

        /// <summary>
        /// Remove data from a specific value of attribute
        /// <para>this function remove the first one only</para>
        /// </summary>
        /// <param name="index"></param>
        public void Remove(string attribute, dynamic value)
        {
            if(!attributes.Contains(attribute))
            {
                throw new Exception(attribute + " Not such attribute on this data table");
            }
            int index = attribute.IndexOf(attribute);
            for(int i = 0; i<data.Count; i++)
            {
                DynNode h = data[i].Head;
                for(int j = 0; j< index;j++)
                {
                    h = h.Next;
                }
                if(h.Value == value)
                {
                    data.RemoveAt(i);
                    return;
                }
            }
        }

        public override string ToString()
        {
            string ret = "";
            for(int i = 0; i<attributes.Count; i++)
            {
                ret += attributes[i].ToUpper() + "\t";
            }
            ret += "\n";
            string line = "";
            for(int i = 0; i<ret.Length; i++)
            {
                if (ret[i] == '\t')
                    line += "-----";
                else line += "-";
            }
            ret += line + "\n";
            if (data.Count == 0) return ret;
            uint len = data[0].Size;
            for(int j = 0; j < len; j++)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    DynNode h = data[i].Head;
                    for (int k = 0; k < j; k++)
                        h = h.Next;
                    ret += h.Value + "\t";
                }
                ret += "\n";
            }
      
            return ret + line;
        }
    }
}

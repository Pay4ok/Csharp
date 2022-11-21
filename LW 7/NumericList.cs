using System;
using System.Collections.Generic;

namespace LW_7
{
    class NumericList : List<int>, IExecuteble<object, int>
    {
        public void WriteToXML(string path)
        {
            System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(path);
            writer.WriteStartDocument();

            writer.WriteComment($"This file saved elements from {this}");

            writer.WriteStartElement(this.ToString());
            for (int i = 0; i < this.Count; i++)
            {
                writer.WriteStartElement($"element");
                    writer.WriteAttributeString("index", i.ToString());
                    writer.WriteElementString("value", this[i].ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        public void ReadFromXML(string path)
        {
            System.Xml.XmlReader reader = System.Xml.XmlReader.Create(path);
            while (reader.Read())
            {
                int result;
                bool flag = Int32.TryParse(reader.Value, out result);

                if (flag) this.Add(result);
            }
        }

        public void AddFrom<T>(params T[] _params) where T : System.Collections.ArrayList
        {
            foreach (T param in _params)
            {
                try
                {
                    foreach (int elem in param)
                    {
                        this.Add(elem);
                    }
                }
                catch (InvalidCastException e) { Console.WriteLine(e); }
                finally { System.Diagnostics.Debug.WriteLine($"{this} <-- {param}"); }
            }
        }

        public void AddNumeric(params int[] _params)
        {
            foreach (int elem in _params) { this.Add(elem); }
        }

        public void LookUpNumeric(params int[] _params)
        {
            foreach (int elem in _params) { this.BinarySearch(elem); }
        }

        public void RemoveNumeric(params int[] _params)
        {
            foreach (int elem in _params) { this.Remove(elem); }
        }
    }
}

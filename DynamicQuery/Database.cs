using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuery
{
    class Database
    {
        public string Insert(string table, string[] fields, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                string value = values[i];
                values[i] = (!double.TryParse(value, out double _)) ? $"'{value}'" : value;
            }
            return $"INSERT INTO {table}({string.Join(", ", fields)}) VALUES ({string.Join(", ", values)});";
        }
    }
}

using System.Data;

namespace TEsting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DataTable dt = new DataTable("GameTable");
            Random random = new Random();
            /*for (int i = 0; i < 10; i++)
            {
                dt.Columns.Add(i.ToString());
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1[i, j].Value = random.Next(0, 2);
                }
            }*/

            for (int i = 0; i < 10; i++)
            {
                dt.Columns.Add(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < 10; j++)
                {
                    row[j] = random.Next(0, 2); // Atsitiktinis skaičius nuo 1 iki 3
                }
                dt.Rows.Add(row);
            }

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
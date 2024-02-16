using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_maybe_
{

    public class ClassControl
    {
        public List<People> member = new List<People>();

        public void AddMember(People newMember)
        {
            // เพิ่มสมาชิกใหม่
            member.Add(newMember);
        }

        public void AddMember(string name, string id, int birthYear)
        {
            People newMember = new People()
            {
                name = name,
                id = id,
                birthYear = birthYear
            };
            this.member.Add(newMember);
        }

        /*public bool buttonSave()
        {
            // บันทึกข้อมูล
            bool result = true;
            if (member.Count == 0)
                return result;

            //save to csv file
            string content = string.Empty;
            foreach (People pe in member)
            {
                content += pe.name + "," + pe.id + "," + pe.birthYear + "\n\r";
            }

            
                //แปลงเป็นFile
                string path = @"D:\Output\outputfile.csv";
                File.WriteAllText(path, content);
                result = true;
            

            return result;
        }
        */
        public bool SaveToFile()
        {
            bool result = false;
            if (member.Count == 0)
                return result;
            //save to csv file
            string content = string.Empty;
            foreach (People pe in member)
            {
                content += pe.name + "," +
                    pe.id + "," +
                    pe.birthYear + "\r\n";
            }
            try
            {
                //write to file
                string path = @"D:\outputfile.csv";
                File.WriteAllText(path, content);
                result = true;
                //0824237045
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }

        public bool ReadFromFile()
        {
            // อ่านข้อมูลจากไฟล์
            bool result = false;
            try
            {
                //read file
                string path = @"D:\outputfile.csv";
                string content = File.ReadAllText(path);
                string[] row = content.Split("\r\n");
                if (row.Length > 0)
                {
                    this.member.Clear();
                    foreach (string line in row)
                    {
                        string[] data = line.Split(",");
                        if (data.Length > 0)
                        {
                            People newPeople = new People()
                            {
                                name = data[0],
                                id = data[1],
                                birthYear = Int32.Parse(data[2]),
                            };
                            this.member.Add(newPeople);
                        }
                    }
                    result = true;
                }
            }
            catch { }
            return result;
        }
    }
}

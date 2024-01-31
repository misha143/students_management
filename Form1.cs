using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        static List<Student> students = new List<Student>();
        static List<int> search_list = new List<int>();
        int current_pos = -1;

        public Form1()
        {
            InitializeComponent();
        }

        public void vstavka_studenta()
        {
            pole_name.Text = students[search_list[current_pos]].Name;
            pole_surname.Text = students[search_list[current_pos]].Surname;
            pole_faculty.Text = students[search_list[current_pos]].Faculty;

            pole_name.Enabled = true;
            pole_surname.Enabled = true;
            pole_faculty.Enabled = true;

            btn_next.Enabled = true;
            btn_prev.Enabled = true;
            menu_prev.Enabled = true;
            menu_next.Enabled = true;

            menu_del_student.Enabled = true;
            menu_add_student.Enabled = true;

            btn_magistr.Visible = false;
            bakalavr_data.Visible = false;
            bakalavr_label.Visible = false;

            if (current_pos == 0)
            {
                btn_prev.Enabled = false;
                menu_prev.Enabled = false;
            }
            if (current_pos == search_list.Count - 1)
            {
                btn_next.Enabled = false;
                menu_next.Enabled = false;
            }

            if (!students[search_list[current_pos]].IsMagistr)
            {
                btn_magistr.Visible = true;
            }
            else
            {
                bakalavr_data.Visible = true;
                bakalavr_label.Visible = true;
                bakalavr_data.Text = students[search_list[current_pos]].BachelorDegree;
            }
        }
        public void redraw_form()
        {
            if (students.Count == 0)
            {
                pole_name.Text = "";
                pole_surname.Text = "";
                pole_faculty.Text = "";

                pole_name.Enabled = false;
                pole_surname.Enabled = false;
                pole_faculty.Enabled = false;

                btn_next.Enabled = false;
                btn_prev.Enabled = false;
                menu_prev.Enabled = false;
                menu_next.Enabled = false;

                menu_del_student.Enabled = false;

                menu_add_student.Enabled = true;
                menu_file_save.Enabled = true;

                search_combobox.Enabled = false;
                search_textbox.Enabled = false;

                btn_magistr.Visible = false;
                bakalavr_data.Visible = false;
                bakalavr_label.Visible = false;

            }
            else
            {
                search_list.Clear();

                // проверка если поиск есть
                if (search_textbox.Text != "")
                {
                    // поиск по имени
                    if (search_combobox.SelectedItem.ToString() == "Имя")
                    {

                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Name.ToLower() == search_textbox.Text.ToLower())
                            {
                                search_list.Add(i);
                            }
                        }
                    }

                    // поиск по фамилии
                    else if (search_combobox.SelectedItem.ToString() == "Фамилия")
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Surname.ToLower() == search_textbox.Text.ToLower())
                            {
                                search_list.Add(i);
                            }
                        }
                    }

                    // поиск по факультету
                    else
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Faculty.ToLower() == search_textbox.Text.ToLower())
                            {
                                search_list.Add(i);
                            }
                        }
                    }


                    if (search_list.Count > 0) // если нашли по поиску что-то
                    {
                        vstavka_studenta();
                    }
                    else  // если не нашли по поиску
                    {
                        pole_name.Text = "";
                        pole_surname.Text = "";
                        pole_faculty.Text = "";

                        pole_name.Enabled = false;
                        pole_surname.Enabled = false;
                        pole_faculty.Enabled = false;

                        btn_next.Enabled = false;
                        btn_prev.Enabled = false;
                        menu_prev.Enabled = false;
                        menu_next.Enabled = false;

                        menu_del_student.Enabled = false;

                        menu_add_student.Enabled = true;

                        btn_magistr.Visible = false;
                        bakalavr_data.Visible = false;
                        bakalavr_label.Visible = false;
                    }


                }
                else // если нет поиска
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        search_list.Add(i);
                    }

                    vstavka_studenta();

                }

                search_combobox.Enabled = true;
                search_textbox.Enabled = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pole_name.Enabled = false;
            pole_surname.Enabled = false;
            pole_faculty.Enabled = false;

            btn_next.Enabled = false;
            btn_prev.Enabled = false;
            menu_prev.Enabled = false;
            menu_next.Enabled = false;

            menu_add_student.Enabled = false;
            menu_del_student.Enabled = false;
            menu_file_save.Enabled = false;

            search_combobox.SelectedIndex = 0;

            search_combobox.Enabled = false;
            search_textbox.Enabled = false;
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(*.json)|*.json";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Выберите файл со студентами";
            string filePath = "", fileContent = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }

            students = JsonConvert.DeserializeObject<List<Student>>(fileContent);
            if (students.Count != 0)
            {
                current_pos = 0;
            }

            redraw_form();

        }

        private void menu_file_save_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json files(*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Сохраните файл со студентами";

            string json = JsonConvert.SerializeObject(students);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(json);
                }
            }
        }

        private void menu_file_create_Click(object sender, EventArgs e)
        {
            students.Clear();

            menu_file_save.Enabled = true;
            menu_add_student.Enabled = true;

            pole_name.Enabled = false;
            pole_surname.Enabled = false;
            pole_faculty.Enabled = false;

            btn_next.Enabled = false;
            btn_prev.Enabled = false;
            menu_prev.Enabled = false;
            menu_next.Enabled = false;

            menu_del_student.Enabled = false;

            search_combobox.Enabled = false;
            search_textbox.Enabled = false;

            search_textbox.Text = "";
            pole_name.Text = "";
            pole_surname.Text = "";
            pole_faculty.Text = "";
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            current_pos -= 1;
            redraw_form();
        }

        private void menu_prev_Click(object sender, EventArgs e)
        {
            current_pos -= 1;
            redraw_form();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            current_pos += 1;
            redraw_form();
        }

        private void menu_next_Click(object sender, EventArgs e)
        {
            current_pos += 1;
            redraw_form();
        }

        private void menu_add_student_Click(object sender, EventArgs e)
        {
            current_pos = students.Count;
            students.Add(new Student());
            search_textbox.Text = "";
            redraw_form();
        }

        private void menu_del_student_Click(object sender, EventArgs e)
        {

            students.RemoveAt(search_list[current_pos]);
            current_pos = 0;
            redraw_form();
        }

        private void search_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            current_pos = 0;
            redraw_form();
        }



        private void pole_name_KeyUp(object sender, KeyEventArgs e)
        {
            students[search_list[current_pos]].Name = pole_name.Text;
        }

        private void pole_surname_KeyUp(object sender, KeyEventArgs e)
        {
            students[search_list[current_pos]].Surname = pole_surname.Text;
        }

        private void pole_faculty_KeyUp(object sender, KeyEventArgs e)
        {
            students[search_list[current_pos]].Faculty = pole_faculty.Text;
        }





        private void search_combobox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            redraw_form();
        }

        private void btn_magistr_Click(object sender, EventArgs e)
        {
            students[search_list[current_pos]].IsMagistr = true;
            redraw_form();
        }

        private void bakalavr_data_KeyUp(object sender, KeyEventArgs e)
        {
            students[search_list[current_pos]].BachelorDegree = bakalavr_data.Text;
        }
    }
}

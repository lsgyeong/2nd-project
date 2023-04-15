using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cnn_project
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=10.10.21.102;Database=medical_details;Uid=manager;Pwd=0000");

        public Form1()
        {
            InitializeComponent();
            cmb_patient.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (cmb_patient.SelectedItem == null)
                MessageBox.Show("환자 리스트를 선택해주세요");

            else if (tbx_medi.Text.Length == 0)
            {
                MessageBox.Show("투여 마취제 용량을 작성해주세요");
            }

            else
            {
                try
                {
                    // 프로시저 
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("pro_patientrecord", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    // 마취제 투여랑
                    string temp = tbx_medi.Text;
                    int d_num = Int32.Parse(temp);

                    // 환자이름
                    object temp1 = cmb_patient.SelectedItem;
                    string p_name = Convert.ToString(temp1);

                    // 타이머 (초로변환)
                    string temp2 = tbx_timer.Text;
                    Form2.Code = temp2;
                    int timer = Int32.Parse(temp2);
                    int seconds, hours, minute, second = 0;
                    seconds = timer * 60;

                    //시간공식(시, 분, 초로 변환)
                    hours = seconds / 3600;//시 공식
                    minute = seconds % 3600 / 60;//분을 구하기위해서 입력되고 남은값에서 또 60을 나눈다.
                    second = seconds % 3600 % 60;//마지막 남은 시간에서 분을 뺀 나머지 시간을 초로 계산함

                    // 현재시각
                    string now_time = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");

                    // 프로시저 매개변수
                    cmd.Parameters.AddWithValue("@dose", d_num);
                    cmd.Parameters.AddWithValue("@patient_name", $"{p_name}");
                    cmd.Parameters.AddWithValue("@timertime", $"{hours}:{minute}:{second}");
                    cmd.Parameters.AddWithValue("@nowtime", $"{now_time}");

                    // 프로시저 실행
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }

                // form2로 이동
                this.Hide();
                Form2 timer_form = new Form2();
                timer_form.ShowDialog();
                this.Close();
            }
        }

        private void tbx_medi_TextChanged(object sender, EventArgs e)
        {        
            // 마취제 양에 따라서 타이머 권장 시간을 작성
            if (tbx_medi.Text.Length != 0)
            {
                string recommendedTime = Convert.ToString(int.Parse(tbx_medi.Text) * 10);
                lbl_recommendedTime.Text = recommendedTime;
            } 
        }

        private void tbx_medi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스를 제외한 나머지를 바로 처리
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // form을 열었을 때 실행(콤보박스에 환자 리스트 추가)
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM medical_details.patient_info";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    Console.WriteLine("환자번호: {0}, 이름: {1}, 성별: {2}", table["patient_id"], table["name"], table["gender"]);
                    cmb_patient.Items.Add(table["name"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbx_timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스를 제외한 나머지를 바로 처리
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
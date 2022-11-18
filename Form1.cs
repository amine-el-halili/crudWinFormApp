using System.Data;
using System.Data.SqlClient;

namespace crudWinFormApp
{
    public partial class Form1 : Form
    {
        // database connection set-up
        static string str = @"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=Csharp;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(str);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        // index of the selected item => help to return from modify(save or cancel) or delete(only cancel ) state to select state
        private int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadDbToCombox()
        {
            cnx.Open();
            cmd.CommandText = "select * from PERSONS;";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboxBox.DataSource = dt;
            comboxBox.ValueMember = "id_person";
            comboxBox.DisplayMember = "name";
            cnx.Close();
        }

        private void initialState()
        {
            this.Text = "Initial";

            loadDbToCombox();

            // pre-select item in initial state
            comboxBox.SelectedItem = null;
            comboxBox.SelectedText = "--select--";

            // disable buttons that user does not in this state => user guide technique
            modify_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
        }

        private void selectedState()
        {
            if (comboxBox.Text.Equals(string.Empty))
            {
                this.Text = "Initial";
            } else
            {
                this.Text = "Select";
            }
            // save the selected index;
            this.index = comboxBox.SelectedIndex;
            // buttons state => user guide technique
            comboxBox.Enabled = true;
            input_textBox.Enabled = false;
            add_btn.Enabled = true;
            modify_btn.Enabled = true;
            delete_btn.Enabled = true;
            save_btn.Enabled = false;
            cancel_btn.Enabled = false;
        }
        private void addState()
        {
            this.Text = "Add";
            input_textBox.Text = string.Empty;
            // dbuttons state => user guide technique
            comboxBox.Enabled = false;
            input_textBox.Enabled = true;
            add_btn.Enabled = false;
            modify_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
        }
        private void modifyState()
        {
            this.Text = "Modify";
            // save the selected index;
            this.index = comboxBox.SelectedIndex;
            // buttons state => user guide technique
            comboxBox.Enabled = false;
            input_textBox.Enabled = true;
            add_btn.Enabled = false;
            modify_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
        }
        private void deleteState()
        {
            this.Text = "Delete";

            // buttons state => user guide technique
            comboxBox.Enabled = false;
            input_textBox.Enabled = false;
            add_btn.Enabled = false;
            modify_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = true;
            cancel_btn.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initialState();
        }

        private void comboxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState();
            input_textBox.Text = comboxBox.Text;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addState();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add"))
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into persons(name) values('" + input_textBox.Text + "') ";
                cmd.ExecuteNonQuery();
                cnx.Close();

                loadDbToCombox();
                selectedState();
                input_textBox.Text = comboxBox.Text;
                // select the item which has been added
                comboxBox.SelectedIndex = comboxBox.Items.Count - 1;
            }
            else if (this.Text.Equals("Modify"))
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "update persons set name = '" + input_textBox.Text + "' where id_person = " + comboxBox.SelectedValue.ToString() + ";";
                cmd.ExecuteNonQuery();
                cnx.Close();

                loadDbToCombox();
                selectedState();
                input_textBox.Text = comboxBox.Text;
                comboxBox.SelectedIndex = this.index;
            }
            else if (this.Text.Equals("Delete"))
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from persons where id_person = " + comboxBox.SelectedValue.ToString() + ";";
                cmd.ExecuteNonQuery();
                cnx.Close();

                loadDbToCombox();
                initialState();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add"))
            {
                initialState();
            }
            else if(this.Text.Equals("Modify") || this.Text.Equals("Delete"))
            {
                selectedState();
                input_textBox.Text = comboxBox.Text;
                comboxBox.SelectedIndex = this.index;
            }

        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            modifyState();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            deleteState();
        }
    }
}
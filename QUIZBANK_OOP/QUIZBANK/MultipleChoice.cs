using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZBANK
{
    public partial class MultipleChoice : Form
    {
        public MultipleChoice()
        {
            InitializeComponent();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                // First, load the subjects from the database
                var dt = ConnectDB.GetData("SELECT Subject_id, Subject_name FROM tbl_subjects", null);

                // Clear existing items in ComboBox
                cmbSubject.Items.Clear();

                // Optionally, add default subjects
                cmbSubject.Items.Add(new { Subject_id = 1, Subject_name = "English" });
                cmbSubject.Items.Add(new { Subject_id = 2, Subject_name = "Math" });
                cmbSubject.Items.Add(new { Subject_id = 3, Subject_name = "Science" });

                // Add subjects from the database
                foreach (DataRow row in dt.Rows)
                {
                    cmbSubject.Items.Add(new
                    {
                        Subject_id = row["Subject_id"],
                        Subject_name = row["Subject_name"]
                    });
                }

                // Set the display member and value member
                cmbSubject.DisplayMember = "Subject_name";
                cmbSubject.ValueMember = "Subject_id";

                // Optionally, set the selected index to -1 to indicate no subject is selected
                cmbSubject.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                int questionId = ConnectDB.getMaxID();  // Get the next available ID for the question
                int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
                string questionText = txtQuestion.Text;
                string[] options = { txtOptionA.Text, txtOptionB.Text, txtOptionC.Text, txtOptionD.Text };
                string correctAnswer = GetCorrectAnswer();

                // Save question
                Dictionary<string, object> questionParams = new Dictionary<string, object>
                {
                    {"@Question_id", questionId},
                    {"@Category_id", 1},  // Assuming 1 represents multiple-choice category
                    {"@Subject_id", subjectId},
                    {"@Question", questionText}
                };
                ConnectDB.saveUpdateDeleteData("INSERT INTO tbl_questions (Question_id, Category_id, Subject_id, Question) VALUES (@Question_id, @Category_id, @Subject_id, @Question)", questionParams);

                // Get the current maximum Option_id from the tbl_options
                int currentOptionId = GetMaxOptionId();

                // Save options with sequential IDs starting from the current max Option_id
                for (int i = 0; i < options.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(options[i])) // Only save non-empty options
                    {
                        currentOptionId++;  // Increment Option_id for each option
                        Dictionary<string, object> optionParams = new Dictionary<string, object>
                        {
                            {"@Option_id", currentOptionId},
                            {"@Question_id", questionId},
                            {"@Option", options[i]}
                        };
                        ConnectDB.saveUpdateDeleteData("INSERT INTO tbl_options (Option_id, Question_id, Option) VALUES (@Option_id, @Question_id, @Option)", optionParams);
                    }
                }
                
                // Save correct answer
                Dictionary<string, object> answerParams = new Dictionary<string, object>
                {
                    {"@Answer_id", ConnectDB.getMaxID()},  // Get the next available ID for the answer
                    {"@Question_id", questionId},
                    {"@Answer", correctAnswer}
                };
                ConnectDB.saveUpdateDeleteData("INSERT INTO tbl_answers (Answer_id, Question_id, Answer) VALUES (@Answer_id, @Question_id, @Answer)", answerParams);

                MessageBox.Show("Question saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
        }

        private int GetMaxOptionId()
        {
            int maxOptionId = 0;
            try
            {
                var dt = ConnectDB.GetData("SELECT MAX(Option_id) FROM tbl_options", null);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    maxOptionId = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching max Option_id: " + ex.Message);
            }
            return maxOptionId;
        }
        private bool ValidateFields()
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtOptionA.Text) || string.IsNullOrWhiteSpace(txtOptionB.Text) ||
                string.IsNullOrWhiteSpace(txtOptionC.Text) || string.IsNullOrWhiteSpace(txtOptionD.Text) ||
                GetCorrectAnswer() == null)
            {
                MessageBox.Show("Please fill in all fields and select the correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ResetFields()
        {
            cmbSubject.SelectedIndex = -1;
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
        }
        
        private string GetCorrectAnswer()
        {
            if (rbtnA.Checked) return txtOptionA.Text;
            if (rbtnB.Checked) return txtOptionB.Text;
            if (rbtnC.Checked) return txtOptionC.Text;
            if (rbtnD.Checked) return txtOptionD.Text;
            return null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }
    }
}

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
    public partial class Identificationcs : Form
    {
        public Identificationcs()
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
        private bool ValidateFields()
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuestion.Text) || string.IsNullOrWhiteSpace(txtCorrectAnswer.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    // Get required inputs
                    int questionId = ConnectDB.getMaxID(); // Generate next Question ID
                    int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
                    string questionText = txtQuestion.Text;
                    string correctAnswer = txtCorrectAnswer.Text;

                    // Save question
                    Dictionary<string, object> questionParams = new Dictionary<string, object>
                    {
                        {"@Question_id", questionId},
                        {"@Category_id", 2}, // Assuming 2 represents Identification category
                        {"@Subject_id", subjectId},
                        {"@Question", questionText}
                    };
                    ConnectDB.saveUpdateDeleteData("INSERT INTO tbl_questions (Question_id, Category_id, Subject_id, Question) VALUES (@Question_id, @Category_id, @Subject_id, @Question)", questionParams);

                    // Save correct answer
                    Dictionary<string, object> answerParams = new Dictionary<string, object>
                    {
                        {"@Answer_id", ConnectDB.getMaxID()},  // Generate next Answer ID
                        {"@Question_id", questionId},
                        {"@Answer", correctAnswer}
                    };
                    ConnectDB.saveUpdateDeleteData("INSERT INTO tbl_answers (Answer_id, Question_id, Answer) VALUES (@Answer_id, @Question_id, @Answer)", answerParams);

                    MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding question: " + ex.Message);
                }
            }
        }
        private void ResetFields()
        {
            cmbSubject.SelectedIndex = -1;
            txtQuestion.Clear();
            txtCorrectAnswer.Clear();
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

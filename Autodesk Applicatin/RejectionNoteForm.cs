using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class RejectionNoteForm : Form
    {
        private readonly int assetID;
        private readonly string editorEmail;
        private readonly string managerEmail;

        public RejectionNoteForm(int assetId, string email, string manager)
        {
            InitializeComponent();
            assetID = assetId;
            editorEmail = email;
            managerEmail = manager;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string note = txtNote.Text.Trim();

            if (string.IsNullOrWhiteSpace(note))
            {
                MessageBox.Show("Please write a reason for rejection.", "Empty Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Update asset status to Rejected
                    string updateQuery = @"UPDATE Assets 
                                           SET status = 'Rejected',
                                               status_updated_by = @manager,
                                               status_updated_at = @updatedAt 
                                           WHERE AssetID = @assetID";

                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@manager", managerEmail);
                        cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@assetID", assetID);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert rejection note as notification
                    string fullMessage = $"Your asset #{assetID} has been rejected: {note}";

                    string insertNote = @"INSERT INTO Notifications 
                                          (AssetID, EditorEmail, Message, IsRead, CreatedAt) 
                                          VALUES (@assetID, @editorEmail, @message, 0, NOW())";

                    using (var cmd = new MySqlCommand(insertNote, conn))
                    {
                        cmd.Parameters.AddWithValue("@assetID", assetID);
                        cmd.Parameters.AddWithValue("@editorEmail", editorEmail);
                        cmd.Parameters.AddWithValue("@message", fullMessage);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Rejection note sent to the Editor.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the note:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RejectionNoteForm_Load(object sender, EventArgs e)
        {
            txtNote.Focus();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

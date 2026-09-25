using System.Drawing;
using System.Windows.Forms;

namespace SwimProAcadamy;

// This is the first page shown after a user logs in.
public class FrmDashboard : Form
{
    public FrmDashboard(string fullName)
    {
        Text = "SwimPro Academy - Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(720, 470);
        BackColor = Color.White;

        Label title = new Label
        {
            Dock = DockStyle.Top,
            Height = 82,
            Text = "SWIMPRO ACADEMY\nSwimming Management System",
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.MidnightBlue
        };

        Label welcome = new Label
        {
            AutoSize = true,
            Text = "Welcome, " + fullName,
            Location = new Point(55, 115),
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            ForeColor = Color.MidnightBlue
        };

        Button btnSwimmers = CreateButton("SWIMMERS", new Point(65, 175));
        Button btnFeeCalculator = CreateButton("FEE CALCULATOR", new Point(380, 175));
        Button btnReports = CreateButton("REPORTS", new Point(65, 275));
        Button btnLogout = CreateButton("LOGOUT", new Point(380, 275));

        btnSwimmers.Click += ShowComingSoon;
        btnFeeCalculator.Click += ShowComingSoon;
        btnReports.Click += ShowComingSoon;
        btnLogout.Click += (sender, e) => Close();

        Controls.AddRange(new Control[] { title, welcome, btnSwimmers, btnFeeCalculator, btnReports, btnLogout });
    }

    private static Button CreateButton(string text, Point location)
    {
        return new Button
        {
            Text = text,
            Location = location,
            Size = new Size(270, 65),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 11, FontStyle.Bold),
            ForeColor = Color.MidnightBlue,
            BackColor = Color.White,
            Cursor = Cursors.Hand
        };
    }

    private void InitializeComponent()
    {

    }

    private void ShowComingSoon(object? sender, EventArgs e)
    {
        MessageBox.Show("This feature will be developed later.", "SwimPro Academy",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

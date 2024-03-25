namespace DriverInstallerWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.White;


            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.Logo;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pictureBox);

            Label label = new Label();
            label.Text = "Install Printers and Drivers";
            label.AutoSize = true;
            label.Font = new Font(label.Font.FontFamily, 16, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.BackColor = Color.White;
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label);


            Label additionalLabel = new Label();
            additionalLabel.Text = "Welcome! This tool will seamlessly install the printers and drivers you've\nrented directly onto your computer. Let's get started.\n\nIf you need any assistance during installation, please call ";
            additionalLabel.AutoSize = true;
            additionalLabel.Font = new Font(additionalLabel.Font, FontStyle.Regular);
            additionalLabel.ForeColor = Color.Black;
            additionalLabel.BackColor = Color.White;
            additionalLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(additionalLabel);


            Label phoneNumberLabel = new Label();
            phoneNumberLabel.Text = "301-359-6804";
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font(phoneNumberLabel.Font, FontStyle.Bold);
            phoneNumberLabel.ForeColor = Color.Black;
            phoneNumberLabel.BackColor = Color.White;
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(phoneNumberLabel);


            Button button = new Button();
            button.Text = "Continue";
            button.BackColor = Color.Blue;
            button.ForeColor = Color.White;
            button.Size = new Size(100, 30);
            button.Location = new Point((this.ClientSize.Width - button.Width) / 2, (this.ClientSize.Height - button.Height) / 2 + label.Height + additionalLabel.Height + phoneNumberLabel.Height + 50); // Располагаем кнопку внизу по центру, ближе к тексту
            this.Controls.Add(button);
            button.Click += (sender, e) =>
            {

                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();
            };
            Label copyrightLabel = new Label();
            copyrightLabel.Text = "Copyright(c) 2024 - We rent Copiers";
            copyrightLabel.AutoSize = true;
            copyrightLabel.Font = new Font(label.Font.FontFamily, 10, FontStyle.Regular);
            copyrightLabel.ForeColor = Color.Black;
            copyrightLabel.BackColor = Color.White;
            copyrightLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(copyrightLabel);
            this.Resize += (sender, e) =>
            {
                pictureBox.Location = new Point((this.ClientSize.Width - pictureBox.Width) / 2, 20);
                label.Location = new Point((this.ClientSize.Width - label.Width) / 2, pictureBox.Bottom + 20);
                additionalLabel.Location = new Point((this.ClientSize.Width - additionalLabel.Width) / 2, label.Bottom + 20);
                phoneNumberLabel.Location = new Point((this.ClientSize.Width - phoneNumberLabel.Width) / 2, additionalLabel.Bottom + 20);
                button.Location = new Point((this.ClientSize.Width - button.Width) / 2, (this.ClientSize.Height - button.Height) / 2 + label.Height + additionalLabel.Height + phoneNumberLabel.Height + 50);
                copyrightLabel.Location = new Point((this.ClientSize.Width - copyrightLabel.Width) / 2, this.ClientSize.Height - copyrightLabel.Height);
            };
        }


    }
}

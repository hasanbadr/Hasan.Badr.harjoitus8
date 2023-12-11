namespace Hasan.Badr.harjoitus8
{
    partial class RoomalaisiksiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomalaisiksiForm));
            label1 = new Label();
            label2 = new Label();
            TekstiTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(518, 67);
            label1.TabIndex = 0;
            label1.Text = "Roomalaoset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 109);
            label2.Name = "label2";
            label2.Size = new Size(554, 27);
            label2.TabIndex = 1;
            label2.Text = "Anna numero välillä 1-3999 niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(574, 106);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(100, 34);
            TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.Location = new Point(14, 161);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(161, 51);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.Location = new Point(574, 172);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(100, 40);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Nuuta";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // RoomalaisiksiForm
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(692, 231);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(TekstiTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "RoomalaisiksiForm";
            Text = "Numeroiden muutos latinalaisita roomalaisiksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}
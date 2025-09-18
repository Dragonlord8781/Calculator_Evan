namespace Calculator_Evan
{
    partial class Abacus
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
            lblTtitle = new Label();
            result = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            buttonCE = new Button();
            btnE = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblTtitle
            // 
            lblTtitle.AutoSize = true;
            lblTtitle.Font = new Font("Viner Hand ITC", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            lblTtitle.Location = new Point(351, 35);
            lblTtitle.Name = "lblTtitle";
            lblTtitle.Size = new Size(409, 76);
            lblTtitle.TabIndex = 0;
            lblTtitle.Text = "disesdi digatlisisgi";
            lblTtitle.Click += lblTtitle_Click;
            lblTtitle.Layout += label1_Layout;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(34, 179);
            result.Name = "result";
            result.Size = new Size(231, 65);
            result.TabIndex = 1;
            result.Text = "nulistanv:\r\n";
            result.Click += lblResult_Click;
            result.Layout += lblResult_Layout;
            // 
            // button7
            // 
            button7.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(215, 342);
            button7.Name = "button7";
            button7.Size = new Size(149, 132);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(392, 342);
            button8.Name = "button8";
            button8.Size = new Size(149, 132);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(572, 342);
            button9.Name = "button9";
            button9.Size = new Size(149, 132);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(215, 516);
            button4.Name = "button4";
            button4.Size = new Size(149, 132);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(392, 516);
            button5.Name = "button5";
            button5.Size = new Size(149, 132);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(572, 516);
            button6.Name = "button6";
            button6.Size = new Size(149, 132);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(215, 691);
            button1.Name = "button1";
            button1.Size = new Size(149, 132);
            button1.TabIndex = 8;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(392, 691);
            button2.Name = "button2";
            button2.Size = new Size(149, 132);
            button2.TabIndex = 9;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(572, 691);
            button3.Name = "button3";
            button3.Size = new Size(149, 132);
            button3.TabIndex = 10;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(392, 855);
            button0.Name = "button0";
            button0.Size = new Size(149, 132);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCE.Location = new Point(215, 855);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(149, 132);
            buttonCE.TabIndex = 12;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.Location = new Point(572, 855);
            btnE.Name = "btnE";
            btnE.Size = new Size(149, 132);
            btnE.TabIndex = 13;
            btnE.Text = "=";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += buttonEquals_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(764, 342);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(149, 132);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnMult.Location = new Point(764, 516);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(149, 132);
            btnMult.TabIndex = 15;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += buttonMultiply_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.Location = new Point(764, 691);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(149, 132);
            btnSub.TabIndex = 16;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Viner Hand ITC", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(764, 855);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 132);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // Abacus
            // 
            AutoScaleDimensions = new SizeF(19F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 1127);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnE);
            Controls.Add(buttonCE);
            Controls.Add(button0);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(result);
            Controls.Add(lblTtitle);
            Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Abacus";
            Text = "Form1";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTtitle;
        private Label result;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button buttonCE;
        private Button btnE;
        private Button btnDiv;
        private Button btnMult;
        private Button btnSub;
        private Button btnAdd;
    }
}
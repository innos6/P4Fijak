
namespace zadanie5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginLoginBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterPasswordConfirmBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordBox = new System.Windows.Forms.TextBox();
            this.RegisterLoginBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.LoginPasswordBox);
            this.groupBox1.Controls.Add(this.LoginLoginBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPasswordBox
            // 
            resources.ApplyResources(this.LoginPasswordBox, "LoginPasswordBox");
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            // 
            // LoginLoginBox
            // 
            resources.ApplyResources(this.LoginLoginBox, "LoginLoginBox");
            this.LoginLoginBox.Name = "LoginLoginBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegisterButton);
            this.groupBox2.Controls.Add(this.RegisterCheckBox);
            this.groupBox2.Controls.Add(this.RegisterPasswordConfirmBox);
            this.groupBox2.Controls.Add(this.RegisterPasswordBox);
            this.groupBox2.Controls.Add(this.RegisterLoginBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // RegisterButton
            // 
            resources.ApplyResources(this.RegisterButton, "RegisterButton");
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterCheckBox
            // 
            resources.ApplyResources(this.RegisterCheckBox, "RegisterCheckBox");
            this.RegisterCheckBox.Name = "RegisterCheckBox";
            this.RegisterCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterPasswordConfirmBox
            // 
            resources.ApplyResources(this.RegisterPasswordConfirmBox, "RegisterPasswordConfirmBox");
            this.RegisterPasswordConfirmBox.Name = "RegisterPasswordConfirmBox";
            this.RegisterPasswordConfirmBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RegisterPasswordBox
            // 
            resources.ApplyResources(this.RegisterPasswordBox, "RegisterPasswordBox");
            this.RegisterPasswordBox.Name = "RegisterPasswordBox";
            // 
            // RegisterLoginBox
            // 
            resources.ApplyResources(this.RegisterLoginBox, "RegisterLoginBox");
            this.RegisterLoginBox.Name = "RegisterLoginBox";
            this.RegisterLoginBox.TextChanged += new System.EventHandler(this.RegisterLoginBox_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RegisterPasswordConfirmBox;
        private System.Windows.Forms.TextBox RegisterPasswordBox;
        private System.Windows.Forms.TextBox RegisterLoginBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.CheckBox RegisterCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.TextBox LoginLoginBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


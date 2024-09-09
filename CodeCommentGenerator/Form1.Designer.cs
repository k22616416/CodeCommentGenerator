
namespace CodeCommentGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_Generator = new System.Windows.Forms.TextBox();
            this.Input_Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Gen_H_Comment = new System.Windows.Forms.Button();
            this.Btn_Gen_C_Comment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lable_Error_Info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Brief = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_Company = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Input_Desc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Input_Return = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Input_Param = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Function_Comment = new System.Windows.Forms.Button();
            this.Input_FunctionName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Generator
            // 
            this.Input_Generator.Location = new System.Drawing.Point(408, 12);
            this.Input_Generator.Multiline = true;
            this.Input_Generator.Name = "Input_Generator";
            this.Input_Generator.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input_Generator.Size = new System.Drawing.Size(549, 572);
            this.Input_Generator.TabIndex = 0;
            this.Input_Generator.WordWrap = false;
            // 
            // Input_Author
            // 
            this.Input_Author.Location = new System.Drawing.Point(5, 38);
            this.Input_Author.Name = "Input_Author";
            this.Input_Author.Size = new System.Drawing.Size(164, 29);
            this.Input_Author.TabIndex = 1;
            this.Input_Author.Text = "Tim.Chen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "編輯者 Author:";
            // 
            // Btn_Gen_H_Comment
            // 
            this.Btn_Gen_H_Comment.Location = new System.Drawing.Point(256, 48);
            this.Btn_Gen_H_Comment.Name = "Btn_Gen_H_Comment";
            this.Btn_Gen_H_Comment.Size = new System.Drawing.Size(125, 36);
            this.Btn_Gen_H_Comment.TabIndex = 6;
            this.Btn_Gen_H_Comment.Text = "產生.h檔註解";
            this.Btn_Gen_H_Comment.UseVisualStyleBackColor = true;
            this.Btn_Gen_H_Comment.Click += new System.EventHandler(this.Btn_Gen_H_Comment_Click);
            // 
            // Btn_Gen_C_Comment
            // 
            this.Btn_Gen_C_Comment.Location = new System.Drawing.Point(256, 6);
            this.Btn_Gen_C_Comment.Name = "Btn_Gen_C_Comment";
            this.Btn_Gen_C_Comment.Size = new System.Drawing.Size(125, 36);
            this.Btn_Gen_C_Comment.TabIndex = 5;
            this.Btn_Gen_C_Comment.Text = "產生.c檔註解";
            this.Btn_Gen_C_Comment.UseVisualStyleBackColor = true;
            this.Btn_Gen_C_Comment.Click += new System.EventHandler(this.Btn_Gen_C_Comment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "檔名 File name:";
            // 
            // Input_FileName
            // 
            this.Input_FileName.Location = new System.Drawing.Point(5, 102);
            this.Input_FileName.Name = "Input_FileName";
            this.Input_FileName.Size = new System.Drawing.Size(164, 29);
            this.Input_FileName.TabIndex = 2;
            this.Input_FileName.Text = "main";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ".c / .h";
            // 
            // Lable_Error_Info
            // 
            this.Lable_Error_Info.AutoSize = true;
            this.Lable_Error_Info.ForeColor = System.Drawing.Color.Red;
            this.Lable_Error_Info.Location = new System.Drawing.Point(8, 600);
            this.Lable_Error_Info.Name = "Lable_Error_Info";
            this.Lable_Error_Info.Size = new System.Drawing.Size(77, 20);
            this.Lable_Error_Info.TabIndex = 8;
            this.Lable_Error_Info.Text = "錯誤訊息:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "檔案簡介 Brief:";
            // 
            // Input_Brief
            // 
            this.Input_Brief.Location = new System.Drawing.Point(5, 167);
            this.Input_Brief.Name = "Input_Brief";
            this.Input_Brief.Size = new System.Drawing.Size(164, 29);
            this.Input_Brief.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "公司 Company:";
            // 
            // Input_Company
            // 
            this.Input_Company.Location = new System.Drawing.Point(5, 232);
            this.Input_Company.Name = "Input_Company";
            this.Input_Company.Size = new System.Drawing.Size(164, 29);
            this.Input_Company.TabIndex = 4;
            this.Input_Company.Text = "Microprogram";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 572);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Btn_Gen_C_Comment);
            this.tabPage1.Controls.Add(this.Btn_Gen_H_Comment);
            this.tabPage1.Controls.Add(this.Input_Author);
            this.tabPage1.Controls.Add(this.Input_Company);
            this.tabPage1.Controls.Add(this.Input_FileName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Input_Brief);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = ".c / .h註解";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Input_Desc);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Input_Return);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Input_Param);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Btn_Function_Comment);
            this.tabPage2.Controls.Add(this.Input_FunctionName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Function註解";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Input_Desc
            // 
            this.Input_Desc.Location = new System.Drawing.Point(6, 108);
            this.Input_Desc.Name = "Input_Desc";
            this.Input_Desc.Size = new System.Drawing.Size(225, 29);
            this.Input_Desc.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Function簡介:";
            // 
            // Input_Return
            // 
            this.Input_Return.Location = new System.Drawing.Point(5, 218);
            this.Input_Return.Name = "Input_Return";
            this.Input_Return.Size = new System.Drawing.Size(225, 29);
            this.Input_Return.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "回傳型態:";
            // 
            // Input_Param
            // 
            this.Input_Param.Location = new System.Drawing.Point(5, 163);
            this.Input_Param.Name = "Input_Param";
            this.Input_Param.Size = new System.Drawing.Size(225, 29);
            this.Input_Param.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "參數:";
            // 
            // Btn_Function_Comment
            // 
            this.Btn_Function_Comment.Location = new System.Drawing.Point(229, 6);
            this.Btn_Function_Comment.Name = "Btn_Function_Comment";
            this.Btn_Function_Comment.Size = new System.Drawing.Size(152, 41);
            this.Btn_Function_Comment.TabIndex = 5;
            this.Btn_Function_Comment.Text = "產生Function註解";
            this.Btn_Function_Comment.UseVisualStyleBackColor = true;
            this.Btn_Function_Comment.Click += new System.EventHandler(this.Btn_Function_Comment_Click);
            // 
            // Input_FunctionName
            // 
            this.Input_FunctionName.Location = new System.Drawing.Point(6, 53);
            this.Input_FunctionName.Name = "Input_FunctionName";
            this.Input_FunctionName.Size = new System.Drawing.Size(225, 29);
            this.Input_FunctionName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Function名稱:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lable_Error_Info);
            this.Controls.Add(this.Input_Generator);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(985, 668);
            this.MinimumSize = new System.Drawing.Size(985, 668);
            this.Name = "Form1";
            this.Text = "CodeCommentGenerator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Generator;
        private System.Windows.Forms.TextBox Input_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Gen_H_Comment;
        private System.Windows.Forms.Button Btn_Gen_C_Comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input_FileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lable_Error_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input_Brief;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Input_Company;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Function_Comment;
        private System.Windows.Forms.TextBox Input_FunctionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Input_Param;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Input_Return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Input_Desc;
        private System.Windows.Forms.Label label9;
    }
}


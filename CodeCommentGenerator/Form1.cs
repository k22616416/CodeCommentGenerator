using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeCommentGenerator
{
    public partial class Form1 : Form
    {
        //----- .c 註解參數 -----//
        string c_File_Format_Str_Filename = "{{fileName}}";
        string c_File_Format_Str_Brief = "{{brief}}";
        string c_File_Format_Str_Company = "{{company}}";
        string c_File_Format_Str_Author = "{{author}}";
        string c_file_comment = "";
        string c_comment_path = @"C_File_Comment.c";

        //----- .h 註解參數 -----//
        string h_File_Format_Str_Filename = "{{fileName}}";
        string h_File_Format_Str_FilenameUpper;
        string h_File_Format_Str_Brief = "{{brief}}";
        string h_File_Format_Str_Author = "{{author}}";
        string h_File_Format_Str_Company = "{{company}}";
        string h_file_comment = "";
        string h_comment_path = @"H_File_Comment.h";

        //----- Function註解參數 -----//
        string function_Format_Str_FunctionName = "{{functionName}}";
        string function_Format_Str_Desc = "{{desc}}";
        string function_Format_Str_Param = "{{param}}";
        string function_Format_Str_Return = "{{return}}";
        string function_comment = "";
        string function_comment_path = @"Function_Comment.c";

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Btn_Gen_C_Comment_Click(object sender, EventArgs e)
        {
            c_file_comment = Read_File(c_comment_path);
            c_file_comment = c_file_comment.Replace(c_File_Format_Str_Filename, Input_FileName.Text)
                                           .Replace(c_File_Format_Str_Author,Input_Author.Text)
                                           .Replace(c_File_Format_Str_Brief, Input_Brief.Text)
                                           .Replace(c_File_Format_Str_Company, Input_Company.Text);
            
            Input_Generator.Text = "";
            Input_Generator.Text = c_file_comment;
        }

        private void Btn_Function_Comment_Click(object sender, EventArgs e)
        {
            function_comment = Read_File(function_comment_path);
            function_comment = function_comment.Replace(function_Format_Str_FunctionName, Input_FunctionName.Text)
                                               .Replace(function_Format_Str_Desc, Input_Desc.Text)
                                               .Replace(function_Format_Str_Param, Input_Param.Text)
                                               .Replace(function_Format_Str_Return, Input_Return.Text);
            Input_Generator.Text = "";
            Input_Generator.Text = function_comment;
        }

        private string Read_File(string file_path)
        {
            string read_str;
            try
            {
                read_str = "";
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file_path))
                {
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    read_str = sr.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Lable_Error_Info.Text = "The file could not be read:" + e.Message;
                read_str = "";
                return read_str;
            }
            return read_str;
        }

        private void Btn_Gen_H_Comment_Click(object sender, EventArgs e)
        {
            h_File_Format_Str_FilenameUpper = h_File_Format_Str_Filename.ToUpper();
            h_file_comment = Read_File(h_comment_path);
            h_file_comment = h_file_comment.Replace(h_File_Format_Str_Filename, Input_FileName.Text)
                                           .Replace(h_File_Format_Str_Author, Input_Author.Text)
                                           .Replace(h_File_Format_Str_FilenameUpper, Input_FileName.Text)
                                           .Replace(h_File_Format_Str_Brief, Input_Brief.Text)
                                           .Replace(h_File_Format_Str_Company, Input_Company.Text);

            Input_Generator.Text = "";
            Input_Generator.Text = h_file_comment;

        }
    }
}

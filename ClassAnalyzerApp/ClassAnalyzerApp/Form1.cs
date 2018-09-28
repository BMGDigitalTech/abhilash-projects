using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ClassAnalyzerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            string typeName = typeNameTxtBox.Text.ToString();
           

            Type T = Type.GetType(typeName);
            MethodsLstBox.Items.Clear();
            PropertiesLstBox.Items.Clear();
            ConstructorsLstBox.Items.Clear();

            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                MethodsLstBox.Items.Add(method.ReturnType + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                PropertiesLstBox.Items.Add(property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                ConstructorsLstBox.Items.Add(constructor.ToString());
            }
        }
    }
}

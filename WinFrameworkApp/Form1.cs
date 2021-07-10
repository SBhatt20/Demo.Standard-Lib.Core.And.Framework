using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrameworkApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      AppUnityContainer appUnityContainer = new AppUnityContainer();
      appUnityContainer.Register();
       Helper myHelper = new Helper(appUnityContainer.ResolveStorageManager());

      textBox1.Text = myHelper.MySettingData();
    }
  }
}

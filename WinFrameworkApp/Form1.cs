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

    AppUnityContainer appUnityContainer = new AppUnityContainer();

    public Form1()
    {
      InitializeComponent();
      // Register StorageManager in Local Unity instance
      appUnityContainer.RegisterStorageManager();
      // Register Helper in Local Unity instance
      appUnityContainer.RegisterHelper();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Example 1: Create Helper Class instance manually
       Helper myHelper = new Helper(appUnityContainer.ResolveStorageManager());

      textBox1.Text = myHelper.MySettingData();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      // Example 2: Get Helper object from Unity (Unity Resolve Helper Class and also resolve StorageManager instance via DI)
      IHelper myHelper = appUnityContainer.ResolveHelper();

      textBox1.Text = myHelper.MySettingData();
    }

      }
}

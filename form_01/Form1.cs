using System.Diagnostics;

namespace form_01;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void action_Click(object sender, EventArgs e)
    {
        Debug.WriteLine("DBG:こんにちは世界");
    }
}

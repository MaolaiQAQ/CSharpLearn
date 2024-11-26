namespace HelloWorldByWinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    //按钮的点击事件
    private void button1_Click(object sender, EventArgs e)
    {
        //当前窗口的textBox的文本修改
        this.textBox1.Text = "Hello World!!!!";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello World!");
    }
}
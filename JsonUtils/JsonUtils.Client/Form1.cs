using System;
using System.Windows.Forms;
using JsonUtils.Parser;
using JsonUtils.Parser.Exceptions;

namespace JsonUtils.Client
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnParse_Click(object sender, System.EventArgs e)
    {
      try
      {
        var parsed = new JsonParser(txtInput.Text.Trim()).Parse();
        txtOutput.Text = "Parse Successful";
      }
      catch (Exception exception)
      {
        txtOutput.Text = "Invalid Json" + (exception is InvalidJsonException ? " at line " + exception.Message : "") + ".";
      }
    }
  }
}

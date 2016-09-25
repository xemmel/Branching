using GridList.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridList.App
{
  public partial class Form1 : Form
  {
    private List<Person> _Persons;
    public Form1()
    {
      InitializeComponent();

      //Create dummy people
      _Persons = new List<Person>()
      {
        new Person() {Name = "Morten", BirthDay = new DateTime(1971,11,10)},
        new Person() {Name = "Mogens", BirthDay = new DateTime(1944,8,24), Death = new DateTime(1989,10,29)}
      };

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}

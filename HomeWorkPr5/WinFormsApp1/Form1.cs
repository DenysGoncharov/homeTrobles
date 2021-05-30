using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFromRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser;
                regKey = regKey.OpenSubKey("Software\\CyberBionic\\Lessons\\HW5pr");

                // GetValue(имя ключа для чтения, значение по умолчанию если ключ не найден)
                if (regKey != null)
                {

                    listBox1.Items.Clear();
                    listBox1.Items.Insert(0, (string)regKey.GetValue("BackColor"));
                    listBox1.BackColor = ColorTranslator.FromHtml((string)regKey.GetValue("BackColor"));
                    listBox1.Items.Insert(1, (string)regKey.GetValue("ForeColor"));
                    listBox1.Items.Insert(2, (string)regKey.GetValue("Font"));
                    listBox1.Items.Insert(3, (string)regKey.GetValue("Font.Style"));
                    listBox1.Items.Insert(4, (string)regKey.GetValue("Font.Size"));
                    MessageBox.Show("Reading complete");
                }
                else
                {
                    MessageBox.Show("NO key");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Инициализируем объект RegistryKey для работы с веткой реестра CurrentUser.
                RegistryKey regKey = Registry.CurrentUser;

                // CreateSubKey - создать по указаному пути ключ.
                regKey = regKey.CreateSubKey("Software\\CyberBionic\\Lessons\\HW5pr");

                // Запись значений в реестр. SetValue( имя ключа, значение).
                regKey.SetValue("BackColor", ColorTranslator.ToHtml(listBox1.BackColor));
                regKey.SetValue("ForeColor", ColorTranslator.ToHtml(listBox1.ForeColor));
                regKey.SetValue("Font", listBox1.Font.Name);
                regKey.SetValue("Font.Style", listBox1.Font.Style.ToString());
                regKey.SetValue("Font.Size", listBox1.Font.Size.ToString());


                MessageBox.Show("Saving complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void loadFromXML_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("books.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    // Проверка на тип узла необходима, иначе будут найдены не только открывающие элементы (XmlNodeType.Element),
                    // но и закрывающие (XmlNodeType.EndElement).
                    if (xmlReader.Name.Equals("listBox1"))   
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Insert(0, "BackGround Color: " + xmlReader.GetAttribute("BackColor"));
                        listBox1.BackColor = ColorTranslator.FromHtml(xmlReader.GetAttribute("BackColor"));
                        listBox1.Items.Insert(1, "Foreground Color: " + xmlReader.GetAttribute("ForeColor"));
                        listBox1.Items.Insert(2, "Font: " + xmlReader.GetAttribute("Font"));
                        listBox1.Items.Insert(3, "Font Stile: " + xmlReader.GetAttribute("Font.Style"));
                        listBox1.Items.Insert(4, "Font Size: " + xmlReader.GetAttribute("Font.Size"));
                    }
                }
            }
            xmlReader.Close();
            stream.Close();
            MessageBox.Show($"XML file loaded");
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            listBox1.Items.Clear();
              if (color.ShowDialog() == DialogResult.OK)
              {
                  listBox1.BackColor = color.Color;
                  listBox1.Items.Insert(0, "BackGround Color: " + listBox1.BackColor.Name.ToString());
                  listBox1.Items.Insert(1, "Foreground Color: " + listBox1.ForeColor.Name.ToString());
                  listBox1.Items.Insert(2, "Font: " +             listBox1.Font.Name);
                  listBox1.Items.Insert(3, "Font Stile: "+        listBox1.Font.Style.ToString());
                  listBox1.Items.Insert(4, "Font Size: " +        listBox1.Font.Size.ToString());
              }
        }

        private void saveToXML_Click(object sender, EventArgs e)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null);

            xmlWriter.WriteStartDocument();                  // Заголовок XML - <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListBoxParams");      // Корневой элемент - <ListBoxParams>
            
           

            xmlWriter.WriteStartElement("listBox1");             // Книга 1 - <Book
            xmlWriter.WriteStartAttribute("BackColor");       // Атрибут - listBox1.BackColor
            xmlWriter.WriteString($"{ColorTranslator.ToHtml(listBox1.BackColor)}");
            xmlWriter.WriteStartAttribute("ForeColor");       // Атрибут - listBox1.ForeColor
            xmlWriter.WriteString($"{ColorTranslator.ToHtml(listBox1.ForeColor)}");
            xmlWriter.WriteStartAttribute("Font");       // Атрибут - listBox1.Font
            xmlWriter.WriteString($"{listBox1.Font.Name}");
            xmlWriter.WriteStartAttribute("Font.Style");       // Атрибут - listBox1.Font.Style
            xmlWriter.WriteString($"{listBox1.Font.Style.ToString()}");
            xmlWriter.WriteStartAttribute("Font.Size");
            xmlWriter.WriteString($"{listBox1.Font.Size.ToString()}");


            xmlWriter.WriteEndAttribute();                   // >
           
            xmlWriter.WriteEndElement();                     // </Book>

            xmlWriter.WriteEndElement();                     // </ListBoxParams>

            xmlWriter.Close();

            MessageBox.Show($"XML file saved");
        }
    }
}

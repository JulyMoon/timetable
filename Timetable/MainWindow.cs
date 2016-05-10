using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class MainWindow : Form
    {
        private Timetable timetable;
        private static readonly Random random = new Random();
        private bool lockComboBox = false;
        private bool lockListBox = false;
        private bool lockCheckBox = false;

        public MainWindow()
        {
            InitializeComponent();
            TimetableReset();
        }

        private void TimetableReset()
        {
            timetable = new Timetable(Properties.Resources.Timetable);
        }

        private void UpdateListBoxes()
        {
            var selected = classListBox.SelectedIndex;
            classListBox.Items.Clear();

            for (int i = 0; i < timetable.Classes.Count; i++)
                classListBox.Items.Add($"{i + (earlyClassCheckBox.Checked ? 0 : 1)}. {timetable.Classes[i]}");
            classListBox.SelectedIndex = classListBox.Items.Count > selected ? selected : classListBox.Items.Count - 1;

            bringBookClassListBox.Items.Clear();

            for (int i = 0; i < timetable.BringBookClasses.Count; i++)
                bringBookClassListBox.Items.Add(timetable.BringBookClasses[i]);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            classesComboBox.Items.AddRange(timetable.AllTheClasses.ToArray());
            UpdateListBoxes();
        }

        private void classesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockComboBox = true;

            if (!lockListBox)
            {
                timetable.ChangeAt(classListBox.SelectedIndex, classesComboBox.SelectedItem.ToString());
                UpdateListBoxes();
                resetButton.Enabled = true;
            }

            lockComboBox = false;
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockListBox = true;

            if (!lockComboBox && classListBox.SelectedIndex != -1)
            {
                classesComboBox.SelectedItem = timetable.Classes[classListBox.SelectedIndex];
                UpdateRemoveButtonAndComboBox();
            }

            UpdateArrowButtons();

            lockListBox = false;
        }

        private void UpdateRemoveButtonAndComboBox()
        {
            classesComboBox.Enabled = removeButton.Enabled = classListBox.SelectedIndex != -1;
        }

        private string GetRandomClass() => timetable.AllTheClasses[random.Next(timetable.AllTheClasses.Count)];

        private void addButton_Click(object sender, EventArgs e)
        {
            timetable.Add(GetRandomClass());
            UpdateListBoxes();
            classListBox.SelectedIndex = classListBox.Items.Count - 1;
            UpdateRemoveButtonAndComboBox();
            UpdateArrowButtons();
            resetButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            timetable.RemoveAt(classListBox.SelectedIndex);
            UpdateListBoxes();

            if (timetable.Classes.Count == 0)
                UpdateRemoveButtonAndComboBox();

            UpdateArrowButtons();
            resetButton.Enabled = true;
        }

        private void UpdateArrowButtons()
        {
            if (classListBox.SelectedIndex == -1)
            {
                upButton.Enabled = downButton.Enabled = false;
            }
            else
            {
                upButton.Enabled = classListBox.SelectedIndex > 0;
                downButton.Enabled = classListBox.SelectedIndex != classListBox.Items.Count - 1;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            TimetableReset();
            classListBox.SelectedIndex = -1;
            UpdateRemoveButtonAndComboBox();

            lockCheckBox = true;
            earlyClassCheckBox.Checked = false;
            lockCheckBox = false;

            UpdateListBoxes();
            UpdateArrowButtons();
            resetButton.Enabled = false;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            timetable.MoveAt(classListBox.SelectedIndex, true);
            UpdateListBoxes();
            UpdateArrowButtons();
            classListBox.SelectedIndex--;
            resetButton.Enabled = true;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            timetable.MoveAt(classListBox.SelectedIndex, false);
            UpdateListBoxes();
            UpdateArrowButtons();
            classListBox.SelectedIndex++;
            resetButton.Enabled = true;
        }

        private void earlyClassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lockCheckBox)
                return;

            if (earlyClassCheckBox.Checked)
            {
                timetable.InsertAt(0, GetRandomClass());
            }
            else if (timetable.Classes.Count > 0)
            {
                timetable.RemoveAt(0);
            }

            UpdateListBoxes();
            UpdateRemoveButtonAndComboBox();

            if (classListBox.Items.Count > 0)
            {
                classListBox.SelectedIndex = 0;
            }
            
            UpdateArrowButtons();
            resetButton.Enabled = true;
        }
    }
}

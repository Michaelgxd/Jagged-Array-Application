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


namespace jaggedArrayDemo
{

    public partial class frmScores : Form
    {
        //declared jaggedarray with three rows
        int[][] jaggedArray = new int[3][];

        public frmScores()
        {
            InitializeComponent();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {
            //jagged array initialized
            jaggedArray[0] = new int[12];  //row 0 with 12 elements
            jaggedArray[1] = new int[8];   //row 1 with 8 elements
            jaggedArray[2] = new int[10];  //row 2 with 10 elements

            //reading files
            fileRead("Section1.txt", 0, lstSection1);
            fileRead("Section2.txt", 1, lstSection2);
            fileRead("Section3.txt", 2, lstSection3);

            //calculating section averages
            txtAvgSection1.Text = avgEachSection(0).ToString("#.000");
            txtAvgSection2.Text = avgEachSection(1).ToString("#.000");
            txtAvgSection3.Text = avgEachSection(2).ToString("#.000");
            allStudents();
        }

        private void fileRead(string fileName, int row, ListBox box)
        {
            //read file according to filename
            try
            {
                using (StreamReader stRead = new StreamReader(fileName))
                {
                    int i = 0;
                    while (!stRead.EndOfStream)
                    {
                        int value = Convert.ToInt32(stRead.ReadLine());
                        jaggedArray[row][i] = value; //storing each line value to jaggedarray
                        i++;
                        box.Items.Add(value.ToString()); //storing same value to listbox also
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("file not found!");
            }

        }
        private double avgEachSection(int row) //row number indicates section
        {
            //finding section average
            int sum = 0;
            double avg;
            for (int i = 0; i < jaggedArray[row].Length; i++)
            {
                sum = sum + jaggedArray[row][i]; //finding sum
            }
            avg = (double)sum / jaggedArray[row].Length; //individual section average 
            return avg;  //return average
        }
        private void allStudents()
        {
            int sum = 0;
            double avg;
            int highScore = jaggedArray[0][0];  //highscore initialized
            int highestScoreRow = 0;
            int lowestscore = jaggedArray[0][0]; //lowestscore initialized
            int lowestScoreRow = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {

                    sum = sum + jaggedArray[i][j];  //finding sum
                    if (jaggedArray[i][j] > highScore)
                    {
                        //update highest score  
                        highScore = jaggedArray[i][j];
                        highestScoreRow = i;
                    }
                    if (jaggedArray[i][j] < lowestscore)
                    {
                        //update lowest score
                        lowestscore = jaggedArray[i][j];
                        lowestScoreRow = i;
                    }
                }
            }
            avg = (double)sum / (jaggedArray[0].Length + jaggedArray[1].Length + jaggedArray[2].Length);
            txtAvgAll.Text = avg.ToString("#.000"); //all section average
            //highest score found in
            txtHighestScore.Text = highScore.ToString() + ", in section " + (highestScoreRow + 1).ToString();
            //lowest score found in
            txtLowestScore.Text = lowestscore.ToString() + ", in section " + (lowestScoreRow + 1).ToString();

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel.CyDrivers.Tools
{
    class Helper
    {
        private string[][] helpText = new string[11][];
        
        public Helper(){
            for(int i = 0; i<helpText.Length; i++) helpText[i]=new string[2];
            helpText[0][0] = "dir"; helpText[0][1] = "Shows directory contents.";
            helpText[1][0]="cd"; helpText[1][1]="Enters directory.";
            helpText[2][0]="cls";helpText[2][1]="Clears console.";
            helpText[3][0]="md"; helpText[3][1]="Makes directory.";
            helpText[4][0]="make";helpText[4][1]="Makes file.";
            helpText[5][0]="time";helpText[5][1]="Displays time.";
            helpText[6][0]="edit";helpText[6][1]="Edits file.";
            helpText[7][0]="read";helpText[7][1]="Reads file.";
            helpText[8][0]="hi"; helpText[8][1]="Says hello.";
            helpText[9][0]="ls"; helpText[9][1]="Also lists contents.";
            helpText[10][0]="help";helpText[10][1]="Displays help text.";
        }

        public void displayHelp(){
            for(int i = 0; i<helpText.Length; i++){
                Console.WriteLine(helpText[i][0]+" - "+helpText[i][1]);
            }
        }


    }
}

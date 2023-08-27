using System;
using System.Collections.Generic;
using System.Drawing;
/*
 * A program that creates a thumbnail for next week's livestream. 
 * 
 * The input template is baked into the built EXE file, so if you are
 * changing it please make sure you update the position where the date
 * is printed.
 *
 * v1.0
 * Original Creation Date: 10/10/2021
 * by Jamie Wright for Templepatrick Presbyterain Church
 * Contact: jwright3478@gmail.com
 *
 * Contributers:
 * [Hey, you reading this! If you make a change to
 * this file make sure you put your name and contact details
 * in here so we can know who last changed the file!]
 */

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // im sorry, person who must maintain this code in the future.
            // I stole this code from some random website
            // I patched it for us one sunday morning (10th october 2021) at around 00:49

            // feel free to discard it or reuse some of the code if you are the person who
            // has taken over maintaining our livestreaming service!

            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile("input.jpg"); // set image (is baked into the EXE)   
            Font font = new Font("Bahnschrift", 170, GraphicsUnit.Pixel); // select the font we are using
            Color color = Color.FromArgb(255, 255, 255, 255); // select the color we are using (in ARGB values, look up a website to get the colour codes)
            Point atpoint = new Point(bitmap.Width / 2, bitmap.Height / 2 + 175); // this is the position where the text we are going to insert will be
            SolidBrush brush = new SolidBrush(color); // this is the object that will draw for us
            Graphics graphics = Graphics.FromImage(bitmap); // create a graphics object in memory from the image we called earlier
            StringFormat sf = new StringFormat(); // create a new StringFormat object in membory
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center; // set the alignment of the text to center
            var sunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek); // get the date of the next upcoming Sunday
            graphics.DrawString(sunday.ToString("dd MMMM yyy"), font, brush, atpoint, sf); // format the date to the correct format (XXth XXX 20XX) and draw it on the graphics object
            graphics.Dispose(); // free memory
            MemoryStream m = new MemoryStream();
            bitmap.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg); // save the image we just created to memory
            byte[] convertedToBytes = m.ToArray(); // convert the bitmap to bytes
            System.IO.File.WriteAllBytes("Auto Generated Thumbnail for " + sunday.ToString("dd MMMM yyy") + ".jpg", convertedToBytes); // write the image to the hard drive
        }
    }
}

namespace My_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi editor de texto\nVersión 1.0\nDesarrollado" + "por Shannon Flores", "Acerca de... ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null; //sistema, trabajar con entradas y salidas de archivos, y dice que leeere un stream (flujo de datos)
            //configurar el filtro para rchivos de texto
            Open.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true; //verifica que el archivo exista
            Open.Title = "Abrir archivo de texto";
            Open.ShowDialog(this);
            try
            {
                // mostrar la info en el rich text box
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd(); //lee todo el contenido del archivo y lo muestra en el rich text box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close(); //cierra la aplicación
        }

        private void fuenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //creamo el objeto font dialog para cambiar la fuente del texto
            FontDialog font = new FontDialog();
            //Aplicamos el tipo de fuente al rich text box
            font.Font = richTextBox1.Font;
            //se hace la validacion para que el usuario pueda cambiar la fuente y se aplique al rich text box
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font; //cambia la fuente del texto en el RichTextBox
            }
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //limpia el contenido del RichTextBox
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog(); //creamos el objeto color dialog para cambiar el color de la fuente
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color; //cambia el color de la fuente en el RichTextBox
            }
        }


        private void azulToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }



        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se crea el objeto SaveFileDialog para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null; //sistema, trabajar con entradas y salidas de archivos, y dice que escribira un stream (flujo de datos)}
                                                          //al igual que para abrir ponemos filtras para guardar
            Save.Filter = "Archivos de texto (*.txt)|HTML (*.html)|Todos los archivos (*.*)|*.*";
            Save.Title = "Guardar archivo de texto";
            Save.CheckPathExists = true; //Enrealidad hay que ver si existe el directorio, no el archivo, pero bueno, lo dejamos así
            Save.Title = "Guardar archivo de texto";
            Save.ShowDialog(this);
            try
            {
                //este codigo para guadar la info del rich text box en el archivo
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void coralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo(); //deshace la última acción realizada en el RichTextBox
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo(); //rehace la última acción deshecha en el RichTextBox
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); //copia el texto seleccionado en el RichTextBox al portapapeles
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); //pega el contenido del portapapeles en el RichTextBox
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); //corta el texto seleccionado en el RichTextBox y lo coloca en el portapapeles
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll(); //selecciona todo el texto en el RichTextBox
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //borra todo el texto en el RichTextBox
        }



        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog(); //creamos el objeto color dialog para cambiar el color de la fuente
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = color.Color; //cambia el color de fondo en el RichTextBox
            }
        }
    }
}



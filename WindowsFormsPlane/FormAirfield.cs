using System;
using System.Drawing;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsPlane
{
    public partial class FormAirfield : Form
    {
        private readonly AirfieldCollection airfieldCollection;
        private readonly Logger logger;

        public FormAirfield()
        {
            InitializeComponent();
            airfieldCollection = new AirfieldCollection(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Draw();
            logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxAirfield.SelectedIndex;
            listBoxAirfield.Items.Clear();
            for (int i = 0; i < airfieldCollection.Keys.Count; i++)
            {
                listBoxAirfield.Items.Add(airfieldCollection.Keys[i]);
            }
            if (listBoxAirfield.Items.Count > 0 && (index == -1 || index >= listBoxAirfield.Items.Count))
            {
                listBoxAirfield.SelectedIndex = 0;
            }
            else if (listBoxAirfield.Items.Count > 0 && index > -1 && index < listBoxAirfield.Items.Count)
            {
                listBoxAirfield.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAirfield.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airfieldCollection[listBoxAirfield.SelectedItem.ToString()].Draw(gr);
                pictureBoxAirfield.Image = bmp;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAirfieldName.Text))
            {
                logger.Warn("Не введено название аэродрома");
                MessageBox.Show("Введите название аэродрома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили аэродром {textBoxAirfieldName.Text}");
            airfieldCollection.AddAirfield(textBoxAirfieldName.Text);
            ReloadLevels();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAirfield.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром {listBoxAirfield.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку {listBoxAirfield.SelectedItem.ToString()}");
                    airfieldCollection.DelParking(listBoxAirfield.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxAirfield.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var plane = airfieldCollection[listBoxAirfield.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (plane != null)
                    {
                        FormSeaplane form = new FormSeaplane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят автомобиль {plane} с места{ maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (PlaneNotFoundException ex)
                {
                    logger.Warn("Не найден самолёт");
                    MessageBox.Show(ex.Message, "Не найден самолёт", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxAirfield_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxAirfield.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonPlane_Click(object sender, EventArgs e)
        {
            var seaPlaneConfig = new FormSeaPlaneConfig();
            seaPlaneConfig.AddEvent(AddPlane);
            seaPlaneConfig.Show();
        }

        private void AddPlane(AirPlane plane)
        {
            if (plane != null && listBoxAirfield.SelectedIndex > -1)
            {
                try
                {
                    if ((airfieldCollection[listBoxAirfield.SelectedItem.ToString()]) + plane)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else
                    {
                        logger.Warn("Самолет не удалось поставить");
                        MessageBox.Show("Самолет не удалось поставить");
                    }
                    Draw();
                }
                catch (AirfieldOverflowException ex)
                {
                    logger.Warn("Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    airfieldCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    airfieldCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxAirfield.SelectedIndex > -1)
            {
                airfieldCollection[listBoxAirfield.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
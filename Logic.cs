using Emgu;
using Emgu.CV;
using Emgu.CV.Dai;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.Util;
using System;
using System.Collections.Generic;
using System.Text;



namespace VirtCam
{
    internal class Logic
    {
        public static string[] filters = { "B&W", "Lightness+", "Lightness-" };
        public static List<string> ActiveFilters = new List<string>();

        private VideoCapture _cap;
        private bool _running = false;
        public Mat _frame;
        public Mat _processedFrame;
        public static void initcb2(ComboBox comboBox, TextBox textBox)
        {
            for (int i = 0; i < filters.Count(); i++)
            {
                ActiveFilters.Add(filters[i]);
                comboBox.Items.Add(ActiveFilters[i]);
                textBox.Text += $"Фильтр: ^{filters[i]}^ добавлен ---";
            }
        }

        public static void initcb1(ComboBox comboBox, TextBox textBox)
        {
            var Devices = new List<VideoCapture>();
            for (int i = 0; i > Devices.Count; i++)
            {
                using (var cap = new VideoCapture(i))
                {
                    Devices.Add(cap);
                    comboBox.Items.Add(cap);
                }
            }
        }

        public void startCam(ImageBox imageBox)
        {
            // Устанавливаем режим отображения перед началом захвата
            if (imageBox.InvokeRequired)
            {
                imageBox.Invoke(new Action(() =>
                {
                    imageBox.SizeMode = PictureBoxSizeMode.AutoSize; // или другой режим
                }));
            }
            else
            {
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            _running = true;
            _cap = new VideoCapture(0);

            new Thread(() =>
            {

                while (_running)
                {
                    _cap.Read(_frame);
                    if (_frame.IsEmpty) break;

                    // Создаем копию кадра для UI потока
                    Mat frameCopy = _frame.Clone();

                    // Обновляем ImageBox в UI потоке
                    if (imageBox.InvokeRequired)
                    {
                        imageBox.BeginInvoke(new Action(() =>
                        {
                            // Способ 1: Используем Image<TColor, TDepth>
                            imageBox.Image = frameCopy.ToImage<Bgr, byte>();

                            // Или Способ 2: Преобразуем в Bitmap и оборачиваем
                            // imageBox.Image = new Bitmap(frameCopy.ToBitmap());

                            // Освобождаем копию после использования
                            frameCopy.Dispose();
                        }));
                    }
                    else
                    {
                        imageBox.Image = frameCopy.ToImage<Bgr, byte>();
                        frameCopy.Dispose();
                    }

                    if (CvInvoke.WaitKey(1) == 27) // ESC
                    {
                        _running = false;
                        break;
                    }
                }
                _frame.Dispose();
            }).Start();
        }
        public void stopCam()
        {
            _running = false;
            Thread.Sleep(100);

            _cap?.Dispose();
            _cap = null;

            CvInvoke.DestroyAllWindows();
        }
        public void StartCam2WithFilterBW(ImageBox imageBox)
        {
            // Устанавливаем режим отображения перед началом захвата
            if (imageBox.InvokeRequired)
            {
                imageBox.Invoke(new Action(() =>
                {
                    imageBox.SizeMode = PictureBoxSizeMode.AutoSize; // или другой режим
                }));
            }
            else
            {
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            _running = true;
            _cap = new VideoCapture(0);

            new Thread(() =>
            {

                while (_running)
                {
                    _cap.Read(_frame);

                    if (_frame.IsEmpty) break;

                    // Создаем копию кадра для UI потока
                    Mat frameCopy = _frame.Clone();

                    // Обновляем ImageBox в UI потоке
                    if (imageBox.InvokeRequired)
                    {
                        imageBox.BeginInvoke(new Action(() =>
                        {
                            // Способ 1: Используем Image<TColor, TDepth>
                            imageBox.Image = frameCopy.ToImage<Bgr, byte>();

                            // Или Способ 2: Преобразуем в Bitmap и оборачиваем
                            // imageBox.Image = new Bitmap(frameCopy.ToBitmap());

                            // Освобождаем копию после использования
                            frameCopy.Dispose();
                        }));
                    }
                    else
                    {
                        imageBox.Image = frameCopy.ToImage<Bgr, byte>();
                        frameCopy.Dispose();
                    }

                    if (CvInvoke.WaitKey(1) == 27) // ESC
                    {
                        _running = false;
                        break;
                    }
                }
            });
        }
        public void StartCam2WithFilterBW(ImageBox imageBox)
        {
            _cap = new VideoCapture(0); // Тоже открываем камеру 0!
            while (true)
            {
                _cap.Read(_frame); // Читаем КАКОЙ-ТО кадр в потоке 2
                filtered = ApplyFilter(frame2);
                ShowInWindow2(filtered);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.Util;



namespace VirtCam
{
    internal class Logic
    {
        private VideoCapture _cap;
        private bool _running = false;

        public void startCam(PictureBox pictureBox)
        {
            _running = true;
            _cap = new VideoCapture(0);

            new Thread(() =>
            {
                Mat frame = new Mat();
                while (_running)
                {
                    _cap.Read(frame);
                    if (frame.IsEmpty) break;
                    CvInvoke.Imshow("Камера", frame);

                    if (CvInvoke.WaitKey(1) == 27) // ESC
                    {
                        _running = false;
                        break;
                    }
                }
                frame.Dispose();
            }).Start(); }
        public void stopCam()
        {
            _running = false;
            Thread.Sleep(100);

            _cap?.Dispose();
            _cap = null;

            CvInvoke.DestroyAllWindows();
        }
    
    }
}
